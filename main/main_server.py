import socket
import select
import sqlite3
import sys
import os
import Queue
import hashlib
import json
import threading

class main:
    def __init__(self,port=8080):
        self.sock = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
        self.sock.bind(('127.0.0.1',port))
        self.sock.listen(100)
        self.db = DB_manager('a')
        self.users = self.db.load()
        self.running = True
        print self.users

    def Handler(self):
        self.sock_list = [self.sock]
        self.output = [ ]
        self.msg_queue = {}
        
        while self.running:
            rlist , wlist , xlist = select.select(self.sock_list,self.output,[])
            for s in rlist:
                
                if s is self.sock:
                    conn, addr = s.accept()
                    conn.setblocking(0)
                    self.sock_list.append(conn)
                    self.msg_queue[conn] = Queue.Queue()
                    print "-- new connection from %s \n" %str(addr)

                else:
                    data = s.recv(1024)
                    if data:
                        while True:
                            try:
                                data+=conn.recv(1024)
                            except:
                                break
                        self.msg_queue[s].put(data)
                        if s not in self.output:
                            self.output.append(s)
                    else:
                        print 'you got am empty socket'
                        if s in output:
                            self.output.remove(s)
                        self.sock_list.remove(s)
                        del msg_queue[s]
                        
            for s in wlist:
                try:
                    pkt = self.msg_queue[s].get()
                except Queue.Empty:
                    print 'output queue for '+s.getpeername+' is empty'
                    output.remove(s)
                else:
                    response = self.Parser(pkt,s)
                    s.send(response)

    #voice_req = ["voice" , "join/create" , room_name , user_name ]
    #msg_req = ["msg" , name , group , hash , message ]
    #users = [( name , group , adress , hash )]
    #disconnect_req = ["disconnect" , name , hash ]
    def Parser(self,data,conn):
        req = data.split(',') #split data to request
        if req[3]=="":
            return "err,invalid"
        if req[0]=='voice': #voice chat request
            if req[1]=='join': #req to join to existing room
                if self.users.has_key(req[2]): #is room exist
                    #is nickname taken in room
                    index = [ p[0] for p in self.users[req[2]] if p[0]==req[3]]
                    if len(index)!=0:
                        return "err,taken"                    
                else: #therefore room not exist
                    return "err,not_exist"
            elif req[1]=='create': #req to create new room
                if self.users.has_key(req[2]): #is room exist
                    return "err,exist"
            else: #invalid request
                return "err,invalid"
            code=hashlib.md5()
            code.update(str(req[2]+req[3]))
            self.db.new_user(req[3],req[2],conn.getpeername()[0],code.hexdigest())
            if req[1]=="join":
                self.users[req[2]].append((req[3],req[2],conn.getpeername()[0],code.hexdigest()))
                other_users = [ {'name':u[0],'ip':u[2]} for u in self.users[req[2]] if u[0]!=req[3]]
                return str("ok,"+json.dumps(other_users))
            else:
                self.users[req[2]] = []
                self.users[req[2]].append((req[3],req[2],conn.getpeername()[0],code.hexdigest()))                
                return str("ok,")
            
            
        
        elif req[0]=='msg': #message request
            if self.users.has_key(req[2]):
                index = [ p for p in self.users[req[2]] if p[0]==req[1]]
                if len(index)==1:
                    if req[3]==index[3]:
                        adresses = [ p[2] for p in self.users[req[2]] ]
                        t = threading.Thread(target=self.Msg_sender,args=(adresses,req[4]))
                        t.start()
                        return "sent,"
            return "err,invalid"

        elif req[0]=='disconnect':
            if self.users.has_key(req[2]):
                user = [ p for p in self.users[req[2]] if p[0]==req[1] and p[3]==req[3]]
                if len(user)==1:
                    self.users[req[2]].remove(user[0])
                    self.sock_list.remove(conn)
                    self.output.remove(conn)
                    self.db.del_user(user[0][0],user[0][3])
                    adresses = [ p[2] for p in self.users[req[2]] ]                    
                    t = threading.Thread(target=self.Disconnect_Sender,args=(adresses,user[0][0]))
                    t.start()
                    return str('ok,')
            return 'err,invalid'
                    
            
    def Disconnect_Sender(self,adresses,name):
        connections = [ c for c in self.sock_list if c.getpeername() in adresses]
        for conn in connections:
            conn.send("diconnect,"+name)
        

    def Msg_sender(self,adresses,msg):
        connections = [ c for c in self.sock_list if c.getpeername() in adresses]
        for conn in connections:
            conn.send('msg,"'+msg+'",end')

#self.users[ (u_name,g_name,adress,hash_code) ]
class DB_manager:
    def __init__(self,DBname):
        self.conn = sqlite3.connect(str(DBname)+'.db')
        self.c = self.conn.cursor()
        if len(self.c.execute("SELECT name FROM sqlite_master WHERE type='table' AND name='USERS';").fetchall())==0:
            self.c.execute('''CREATE TABLE USERS (user_n TEXT, group_n TEXT, adress TEXT, code TEXT);''')
        self.conn.commit()

    def load(self):
        data = self.c.execute('select * from users order by group_n')
        rows = data.fetchall()
        group = {}
        for i in rows:
            if group.has_key(i[1]):
                group[i[1]].append(i)
            else:
                group[i[1]]=[]
                group[i[1]].append(i)
        return group

    def new_user(self,u_name,g_name,adress,code):
        t=(u_name,g_name,adress,code)
        self.c.execute("INSERT INTO USERS (user_n, group_n, adress, code) \
      VALUES (?,?,?,? )",t)
        self.conn.commit()
        
    def del_user(self,u_name,code):
        self.c.execute("DELETE from USERS where user_n=?,code=?;",(u_name,code))
        self.c.commit()

    def printAll(self):
        cursor = self.conn.execute("SELECT user_n, group_n, adress, code from USERS")
        for row in cursor:
            print "User=%s, Group=%s, Adress=%s, Code=%s"%(row[0],row[1],row[2],row[3])

    def close(self):
        self.c.close()
        self.conn.close()

m=main()
m.Handler()
