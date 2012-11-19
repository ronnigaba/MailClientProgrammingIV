using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingIVMailClient
{
    public partial class Form1 : Form
    {
        OpenPop.Pop3.Pop3Client popClient = new OpenPop.Pop3.Pop3Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void connectAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionProperties connProp = new ConnectionProperties();
            connProp.ShowDialog();
        }
        private void sendMailButton_Click(object sender, EventArgs e)
        {
            NewMail sendMail = new NewMail(); //Pass the connection# to the sendmail form
            sendMail.Show();
        }
        private void getMail(int connection) //Implement this function in a background-worker thread.
        {
            do{
            popClient.Connect(Properties.Settings.Default["popaddress" + connection].ToString(), int.Parse(Properties.Settings.Default["popport" + connection].ToString()), true);
            } while (popClient.Connected != true);
            
            popClient.Authenticate(Properties.Settings.Default["username" + connection].ToString(), Properties.Settings.Default["password" + connection].ToString());
            if (popClient.Connected == true)
            {
                createTab(connection);
                ListView lv_mail = (ListView)this.Controls.Find("lv_mails" + connection, true)[0];
                for (int i = popClient.GetMessageCount(); i >= (popClient.GetMessageCount() - 20); i--)
                    lv_mail.Items.Add(popClient.GetMessage(i).Headers.Subject.ToString());
            }
        }
        private void deleteMail(object sender, EventArgs e) //Currently broken
        {
            Button button = (Button)sender;
            int connection = int.Parse(button.Name.Substring(button.Name.Length - 1));

            ListView listview = (ListView)this.Controls.Find("lv_mails" + connection, true)[0];
            if (popClient.Connected == true)
            {
                foreach(int msg in listview.SelectedItems) //Here!
                {
                    popClient.DeleteMessage(msg);
                }
            }
        }
        private void mailSelectionChanged(object sender, EventArgs e)
        {
            ListView listview = (ListView)sender;
            int connection = int.Parse(listview.Name.Substring(listview.Name.Length - 1));

            //popClient.GetMessage(listview.SelectedItems[0].Index);
            TextBox tb_from = (TextBox)this.Controls.Find("tb_from" + connection, true)[0];
        }
        private void createTab(int connection)
        {
            TabPage page = new TabPage(Properties.Settings.Default["username" + connection].ToString());

            ListView listview = new ListView();
            listview.SetBounds(6, 40, 360, 430);
            listview.Name = "lv_mails" + connection;
            listview.View = View.List;
            listview.SelectedIndexChanged += new EventHandler(mailSelectionChanged);
            page.Controls.Add(listview);

            Button button_compose = new Button();
            button_compose.Name = "btn_compose" + connection;
            button_compose.SetBounds(6, 10, 75, 23);
            button_compose.Text = "New mail...";
            button_compose.Click += new EventHandler(sendMailButton_Click);
            page.Controls.Add(button_compose);

            Button button_delete = new Button();
            button_delete.Name = "btn_delete" + connection;
            button_delete.SetBounds(87 ,10, 75, 23);
            button_delete.Text = "Delete mail";
            button_delete.Click += new EventHandler(deleteMail);
            page.Controls.Add(button_delete);

            GroupBox groupbox = new GroupBox();
            groupbox.Text = "Mail";
            groupbox.SetBounds(372, 34, 432, 436);
            page.Controls.Add(groupbox);

            Label label_from = new Label();
            label_from.Text = "From:";
            label_from.SetBounds(6, 22, 33, 13);
            groupbox.Controls.Add(label_from);

            Label label_to = new Label();
            label_to.Text = "To:";
            label_to.SetBounds(6, 48, 23, 13);
            groupbox.Controls.Add(label_to);

            Label label_cc = new Label();
            label_cc.Text = "CC:";
            label_cc.SetBounds(6, 74, 24, 13);
            groupbox.Controls.Add(label_cc);

            Label label_bcc = new Label();
            label_bcc.Text = "BCC:";
            label_bcc.SetBounds(218, 74, 31, 13);
            groupbox.Controls.Add(label_bcc);

            TextBox tb_from = new TextBox();
            tb_from.Name = "tb_from" + connection;
            tb_from.SetBounds(42, 19, 384, 20);
            groupbox.Controls.Add(tb_from);

            TextBox tb_to = new TextBox();
            tb_to.Name = "tb_to" + connection;
            tb_to.SetBounds(42, 45, 384, 20);
            groupbox.Controls.Add(tb_to);

            TextBox tb_cc = new TextBox();
            tb_cc.Name = "tb_cc" + connection;
            tb_cc.SetBounds(42, 71, 170, 20);
            groupbox.Controls.Add(tb_cc);

            TextBox tb_bcc = new TextBox();
            tb_bcc.Name = "tb_bcc" + connection;
            tb_bcc.SetBounds(256, 71, 170, 20);
            groupbox.Controls.Add(tb_bcc);

            TextBox tb_msg = new TextBox();
            tb_msg.Name = "tb_msg" + connection;
            tb_msg.Multiline = true;
            tb_msg.SetBounds(9, 97, 417, 333);
            groupbox.Controls.Add(tb_msg);

            tabControl1.TabPages.Add(page);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //For-loop to check for properties.settings and run getmail(int) for each set of settings
            getMail(1);
        }
    }
}
