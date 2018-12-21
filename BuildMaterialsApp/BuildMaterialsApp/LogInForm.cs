using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BuildMaterialsApp
{
    public partial class LogInForm : MetroFramework.Forms.MetroForm
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+@"\BuildDB.mdb";

        private void metroButton1_Click(object sender, EventArgs e)
        {

            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                string cmdText = "";
                if (metroToggle1.Checked == true)
                {
                    cmdText = "Select * From Admins WHERE Login_Admin = '" + mtbLogin.Text + "' AND Password_Admin = '" + mtbPassword.Text + "'";
                }
                if(metroToggle1.Checked == false)
                {
                    cmdText = "Select * From Users WHERE Login_User = '" + mtbLogin.Text + "' AND Password_User = '" + mtbPassword.Text + "'";
                }
                OleDbCommand command = new OleDbCommand(cmdText, connection);
                OleDbDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (metroToggle1.Checked == true)
                    {
                        
                        MainForm mainForm = new MainForm(reader["ID_Admin"].ToString(), reader["Login_Admin"].ToString(), true);
                        mainForm.Show();
                    }
                    else
                    {
                        MainForm mainForm = new MainForm(reader["ID_User"].ToString(), reader["Login_User"].ToString());
                        mainForm.Show();
                    }
                }
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
        private void metroButton2_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
        }
    }
}
