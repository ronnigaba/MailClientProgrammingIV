namespace ProgrammingIVMailClient
{
    partial class NewMail
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
            this.tb_to = new System.Windows.Forms.TextBox();
            this.tb_topic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_body = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_cc = new System.Windows.Forms.TextBox();
            this.tb_bcc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_encrypt = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(73, 12);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(374, 20);
            this.tb_to.TabIndex = 0;
            // 
            // tb_topic
            // 
            this.tb_topic.Location = new System.Drawing.Point(60, 19);
            this.tb_topic.Name = "tb_topic";
            this.tb_topic.Size = new System.Drawing.Size(368, 20);
            this.tb_topic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topic";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_body);
            this.groupBox1.Controls.Add(this.tb_topic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 369);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(6, 45);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.Size = new System.Drawing.Size(422, 314);
            this.tb_body.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(372, 441);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_cc
            // 
            this.tb_cc.Location = new System.Drawing.Point(73, 38);
            this.tb_cc.Name = "tb_cc";
            this.tb_cc.Size = new System.Drawing.Size(147, 20);
            this.tb_cc.TabIndex = 6;
            // 
            // tb_bcc
            // 
            this.tb_bcc.Location = new System.Drawing.Point(300, 38);
            this.tb_bcc.Name = "tb_bcc";
            this.tb_bcc.Size = new System.Drawing.Size(147, 20);
            this.tb_bcc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BCC";
            // 
            // cb_encrypt
            // 
            this.cb_encrypt.AutoSize = true;
            this.cb_encrypt.Location = new System.Drawing.Point(22, 440);
            this.cb_encrypt.Name = "cb_encrypt";
            this.cb_encrypt.Size = new System.Drawing.Size(108, 17);
            this.cb_encrypt.TabIndex = 10;
            this.cb_encrypt.Text = "Encrypt with AES";
            this.cb_encrypt.UseVisualStyleBackColor = true;
            // 
            // NewMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 476);
            this.Controls.Add(this.cb_encrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_bcc);
            this.Controls.Add(this.tb_cc);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_to);
            this.Name = "NewMail";
            this.Text = "Compose Mail...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.TextBox tb_topic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tb_cc;
        private System.Windows.Forms.TextBox tb_bcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_encrypt;
    }
}