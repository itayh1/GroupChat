﻿namespace GroupChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnConnent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comType = new System.Windows.Forms.ComboBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rdVoice = new System.Windows.Forms.RadioButton();
            this.rdVideo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 219);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User name:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(21, 288);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(49, 17);
            this.lblRoom.TabIndex = 1;
            this.lblRoom.Text = "Room:";
            // 
            // btnConnent
            // 
            this.btnConnent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnConnent.Location = new System.Drawing.Point(25, 353);
            this.btnConnent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnent.Name = "btnConnent";
            this.btnConnent.Size = new System.Drawing.Size(100, 36);
            this.btnConnent.TabIndex = 2;
            this.btnConnent.Text = "Connect";
            this.btnConnent.UseVisualStyleBackColor = true;
            this.btnConnent.Click += new System.EventHandler(this.btnConnent_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 239);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(25, 308);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(132, 22);
            this.txtRoom.TabIndex = 4;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(21, 406);
            this.lblStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(52, 17);
            this.lblStat.TabIndex = 5;
            this.lblStat.Text = "Status:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(185, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(800, 415);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // comType
            // 
            this.comType.Items.AddRange(new object[] {
            "Create room",
            "Join room"});
            this.comType.Location = new System.Drawing.Point(25, 80);
            this.comType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(132, 24);
            this.comType.TabIndex = 0;
            this.comType.Text = "choose:";
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.Location = new System.Drawing.Point(185, 514);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(691, 22);
            this.txtMsg.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(885, 513);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rdVoice
            // 
            this.rdVoice.AutoSize = true;
            this.rdVoice.Location = new System.Drawing.Point(25, 114);
            this.rdVoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdVoice.Name = "rdVoice";
            this.rdVoice.Size = new System.Drawing.Size(64, 21);
            this.rdVoice.TabIndex = 9;
            this.rdVoice.TabStop = true;
            this.rdVoice.Text = "Voice";
            this.rdVoice.UseVisualStyleBackColor = true;
            // 
            // rdVideo
            // 
            this.rdVideo.AutoSize = true;
            this.rdVideo.Location = new System.Drawing.Point(25, 144);
            this.rdVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdVideo.Name = "rdVideo";
            this.rdVideo.Size = new System.Drawing.Size(65, 21);
            this.rdVideo.TabIndex = 10;
            this.rdVideo.TabStop = true;
            this.rdVideo.Text = "Video";
            this.rdVideo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 558);
            this.Controls.Add(this.rdVideo);
            this.Controls.Add(this.rdVoice);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.comType);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnConnent);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnConnent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rdVoice;
        private System.Windows.Forms.RadioButton rdVideo;
    }
}

