using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;

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
            MailMessage mail = new MailMessage();
            mail.To.Add(tb_to.Text);
            if (tb_cc.Text != "")
                mail.CC.Add(tb_cc.Text);
            if (tb_bcc.Text != "")
                mail.Bcc.Add(tb_bcc.Text);
            mail.Subject = tb_topic.Text;
            if (cb_encrypt.Checked == true)
                mail.Body = encryptMessage(tb_body.Text,"", ""); //Currently using self-generated keys
            else
                mail.Body = tb_body.Text;
            mail.From = new System.Net.Mail.MailAddress("lala@lala.com"); //Dummy address, network credentials seems to figure out the right address regardless.
            SmtpClient smtp = new SmtpClient(Properties.Settings.Default["smtpaddress1"].ToString());
            smtp.Port = int.Parse(Properties.Settings.Default["smtpport1"].ToString());
            smtp.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default["username1"].ToString(), Properties.Settings.Default["password1"].ToString());
            smtp.EnableSsl = true;
                
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { this.Close(); }
        }
        private string encryptMessage(string message, string key, string iv)
        {
            RijndaelManaged aes = new RijndaelManaged();
            aes.Padding = PaddingMode.Zeros;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            MemoryStream memStream = new MemoryStream();
            using (CryptoStream csEncrypt = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(csEncrypt))
                {
                    streamWriter.Write(message);
                }
            }
            byte[] bytes = memStream.ToArray();
            message = System.Text.Encoding.ASCII.GetString(bytes);

            return message;
        }
        private string decryptMessage(string message, string key, string iv)
        {
            RijndaelManaged aes = new RijndaelManaged();
            aes.Padding = PaddingMode.Zeros;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            MemoryStream memStream = new MemoryStream(System.Text.Encoding.ASCII.GetBytes(message));
            using (CryptoStream csEncrypt = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
            {
                using (StreamReader streamReader = new StreamReader(csEncrypt))
                {
                    message = streamReader.ReadToEnd();
                }   
            }

            return message;
        }
    }
}
