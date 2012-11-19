using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace ProgrammingIVMailClient
{
    public partial class NewMail : Form
    {
        public NewMail()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try

            {
                MailMessage mail = new MailMessage();
                mail.To.Add(tb_to.Text);
                if(tb_cc.Text != "")
                    mail.CC.Add(tb_cc.Text);
                if(tb_bcc.Text != "")
                    mail.Bcc.Add(tb_bcc.Text);
                mail.Subject = tb_topic.Text;
                mail.Body = tb_body.Text;
                mail.From = new System.Net.Mail.MailAddress("lala@lala.com"); //Dummy address, network credentials seems to figure out the right address regardless.
                SmtpClient smtp = new SmtpClient(Properties.Settings.Default["smtpaddress1"].ToString());
                smtp.Port = int.Parse(Properties.Settings.Default["smtpport1"].ToString());
                smtp.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default["username1"].ToString(),Properties.Settings.Default["password1"].ToString());
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { this.Close(); }

        }
    }
}
