import json

##f=open("testing.txt",'r')
##x=f.read()
##
##w=json.loads(x)
##print w
##f.close()

p1= {}
p1['name']="ben"
p1['ip']='1234'

p2= {}
p2['name']="dan"
p2['ip']='4567'

p3= {}
p3['name']="gg"
p3['ip']='7899'


person=[p1,p2,p3]

print json.dumps(person)

##with open('test2.txt','w') as f:
##    json.dump(person,f)
##
##a=open('test2.txt','r')
##w=json.loads(a.read())
##print w
##a.close()
