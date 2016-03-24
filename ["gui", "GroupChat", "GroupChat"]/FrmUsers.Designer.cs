namespace GroupChat
{
    partial class FrmUsers
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
            this.boxList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boxList
            // 
            this.boxList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.boxList.FormattingEnabled = true;
            this.boxList.Location = new System.Drawing.Point(12, 12);
            this.boxList.Name = "boxList";
            this.boxList.Size = new System.Drawing.Size(160, 238);
            this.boxList.TabIndex = 0;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 262);
            this.ControlBox = false;
            this.Controls.Add(this.boxList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsers";
            this.Text = "Connected users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox boxList;
    }
}