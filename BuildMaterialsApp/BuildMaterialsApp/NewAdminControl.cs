using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BuildMaterialsApp
{
    public partial class NewAdminControl : UserControl
    {
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

        public NewAdminControl()
        {
            InitializeComponent();
        }

        AdminPanel adminPanel;
        public NewAdminControl(AdminPanel adminPanel)
        {
            InitializeComponent();
            this.adminPanel = adminPanel;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                string cmdText = "";

                OleDbCommand command = new OleDbCommand("SELECT * FROM Admins WHERE Login_Admin = '" + mtbLogin.Text + "'", connection);
                OleDbDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    throw new Exception("Логин занят другим администратором! Введеите другой логин");
                }
                reader.Close();
                cmdText = "INSERT INTO Admins(Login_Admin, Password_Admin, E_mail_Admin) VALUES('" + mtbLogin.Text + "', '" + mtbPassword.Text + "', '" + mtbE_mail.Text + "')";
                OleDbCommand command1 = new OleDbCommand(cmdText, connection);
                command1.ExecuteNonQuery();
                adminPanel.flowLayoutPanel1.Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
