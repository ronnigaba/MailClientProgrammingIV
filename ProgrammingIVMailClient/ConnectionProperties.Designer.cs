namespace ProgrammingIVMailClient
{
    partial class ConnectionProperties
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
            this.tb_popAddress = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_connname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_smtp = new System.Windows.Forms.TextBox();
            this.tb_pop3Port = new System.Windows.Forms.TextBox();
            this.tb_smtpPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_popAddress
            // 
            this.tb_popAddress.Location = new System.Drawing.Point(122, 43);
            this.tb_popAddress.Name = "tb_popAddress";
            this.tb_popAddress.Size = new System.Drawing.Size(147, 20);
            this.tb_popAddress.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(122, 95);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(220, 20);
            this.tb_username.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(122, 121);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(220, 20);
            this.tb_password.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Connection Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "POP3 address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_connname
            // 
            this.cb_connname.FormattingEnabled = true;
            this.cb_connname.Location = new System.Drawing.Point(122, 12);
            this.cb_connname.Name = "cb_connname";
            this.cb_connname.Size = new System.Drawing.Size(220, 21);
            this.cb_connname.TabIndex = 0;
            this.cb_connname.SelectedIndexChanged += new System.EventHandler(this.cb_conname_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SMTP address";
            // 
            // tb_smtp
            // 
            this.tb_smtp.Location = new System.Drawing.Point(122, 69);
            this.tb_smtp.Name = "tb_smtp";
            this.tb_smtp.Size = new System.Drawing.Size(147, 20);
            this.tb_smtp.TabIndex = 3;
            // 
            // tb_pop3Port
            // 
            this.tb_pop3Port.Location = new System.Drawing.Point(308, 43);
            this.tb_pop3Port.Name = "tb_pop3Port";
            this.tb_pop3Port.Size = new System.Drawing.Size(34, 20);
            this.tb_pop3Port.TabIndex = 2;
            // 
            // tb_smtpPort
            // 
            this.tb_smtpPort.Location = new System.Drawing.Point(308, 69);
            this.tb_smtpPort.Name = "tb_smtpPort";
            this.tb_smtpPort.Size = new System.Drawing.Size(34, 20);
            this.tb_smtpPort.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Port";
            // 
            // ConnectionProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 179);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_smtpPort);
            this.Controls.Add(this.tb_pop3Port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_smtp);
            this.Controls.Add(this.cb_connname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_popAddress);
            this.Name = "ConnectionProperties";
            this.Text = "ConnectionProperties";
            this.Load += new System.EventHandler(this.ConnectionProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_popAddress;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_connname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_smtp;
        private System.Windows.Forms.TextBox tb_pop3Port;
        private System.Windows.Forms.TextBox tb_smtpPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}