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
    public partial class ConnectionProperties : Form
    {
        public ConnectionProperties()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_connname.Text != "" && tb_username.Text != "" && tb_password.Text != "" && tb_popAddress.Text != "")
            {
                Properties.Settings.Default["connname1"] = cb_connname.Text;
                Properties.Settings.Default["username1"] = tb_username.Text;
                Properties.Settings.Default["password1"] = tb_password.Text;
                Properties.Settings.Default["popaddress1"] = tb_popAddress.Text;
                Properties.Settings.Default["smtpaddress1"] = tb_smtp.Text;
                Properties.Settings.Default["popport1"] = tb_pop3Port.Text;
                Properties.Settings.Default["smtpport1"] = tb_smtpPort.Text;
                Properties.Settings.Default.Save();
            }   
        }

        private void ConnectionProperties_Load(object sender, EventArgs e)
        {
            string str;
            for (int i = 1; i <= Properties.Settings.Default.Properties.Count / 4; i++)
            {
                str = "connname" + i;
                cb_connname.Items.Add(Properties.Settings.Default[str]);
            }
        }

        private void cb_conname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cb_connname.SelectedIndex + 1; //Compensates for the settings names starting at 1 rather than 0
            cb_connname.Text = Properties.Settings.Default["connname" + selectedIndex.ToString()].ToString();
            tb_username.Text = Properties.Settings.Default["username" + selectedIndex.ToString()].ToString();
            tb_password.Text = Properties.Settings.Default["password" + selectedIndex.ToString()].ToString();
            tb_popAddress.Text = Properties.Settings.Default["popaddress" + selectedIndex.ToString()].ToString();
            tb_pop3Port.Text = Properties.Settings.Default["popport" + selectedIndex.ToString()].ToString();
            tb_smtp.Text = Properties.Settings.Default["smtpaddress" + selectedIndex.ToString()].ToString();
            tb_smtpPort.Text = Properties.Settings.Default["smtpport" + selectedIndex.ToString()].ToString();
        }
    }
}
