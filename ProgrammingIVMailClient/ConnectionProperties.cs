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
        int connection;

        public ConnectionProperties(int connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_connname.Text != "" && tb_username.Text != "" && tb_password.Text != "" && tb_popAddress.Text != "" && tb_smtp.Text != "" && tb_pop3Port.Text != "" && tb_smtpPort.Text != "")
            {
                savePropertiesTest("connname" + connection, cb_connname.Text);
                savePropertiesTest("username" + connection, tb_username.Text);
                savePropertiesTest("password" + connection, tb_password.Text);
                savePropertiesTest("popaddress" + connection, tb_popAddress.Text);
                savePropertiesTest("smtpaddress" + connection, tb_smtp.Text);
                savePropertiesTest("popport" + connection, tb_pop3Port.Text);
                savePropertiesTest("smtpport" + connection, tb_smtpPort.Text);
                Properties.Settings.Default.Save();

                updateList();
                connection++;
            }
            else
                MessageBox.Show("Please fill in the remaining fields");
        }
        private void savePropertiesTest(string propertyName, string value)
        {
            System.Configuration.SettingsProperty property = new System.Configuration.SettingsProperty(propertyName);
            property.DefaultValue = value;
            property.IsReadOnly = false;
            property.PropertyType = typeof(string);
            property.Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"];
            property.Attributes.Add(typeof(System.Configuration.UserScopedSettingAttribute), new System.Configuration.UserScopedSettingAttribute());
            try
            {
                Properties.Settings.Default.Properties.Add(property);
            }
            catch
            {
                Properties.Settings.Default.Properties.Remove(property.Name);
                Properties.Settings.Default.Properties.Add(property);
            }
        }

        private void ConnectionProperties_Load(object sender, EventArgs e)
        {
            updateList();
        }
        private void updateList()
        {
            cb_connname.Items.Clear();
            string str;
            for (int i = 1; i <= Properties.Settings.Default.Properties.Count / 7; i++)
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
            connection = cb_connname.SelectedIndex + 1;
        }
    }
}
