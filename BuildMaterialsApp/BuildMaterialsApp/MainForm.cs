using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildMaterialsApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string Login_User)
        {
            InitializeComponent();
            mLogin_User.Text = Login_User;
        }

        public MainForm(string Login_User, bool isAdmin)
        {
            InitializeComponent();
            mLogin_User.Text = Login_User;
            btnAdminPanel.Visible = true;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnAdminPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnBacket.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Style = MetroFramework.MetroColorStyle.Red;
            foreach (Control control in this.Controls)
            {
                MetroFramework.Controls.MetroLabel metroLabel = control as MetroFramework.Controls.MetroLabel;
                if (metroLabel != null)
                {
                    metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                }
            }

            foreach (Control control in metroPanel1.Controls)
            {
                MetroFramework.Controls.MetroLabel metroLabel = control as MetroFramework.Controls.MetroLabel;
                if (metroLabel != null)
                {
                    metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                }
            }
            foreach (Control control in metroPanel1.Controls)
            {
                MetroFramework.Controls.MetroLink metroLink = control as MetroFramework.Controls.MetroLink;
                if (metroLink != null)
                {
                    metroLink.Theme = MetroFramework.MetroThemeStyle.Dark;
                }
            }

        }

        public void GetDataFromCategories(string cmdText)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(cmdText, connection);
                OleDbDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch
            {

            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            AdminPanel adminPanel = new AdminPanel();
            flowLayoutPanel1.Controls.Add(adminPanel);
        }
    }
}
