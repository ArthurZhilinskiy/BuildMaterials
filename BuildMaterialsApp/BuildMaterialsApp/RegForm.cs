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
    public partial class RegForm : MetroFramework.Forms.MetroForm
    {
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

        public RegForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                string cmdText = "";

                OleDbCommand command = new OleDbCommand("SELECT * FROM Users WHERE Login_User = '" + mtbLogin.Text + "'", connection);
                OleDbDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    throw new Exception("Логин занят другим пользователем! Введеите другой логин");
                }
                reader.Close();
                cmdText = "INSERT INTO Users(Login_User, Password_User, E_mail_User) VALUES('" + mtbLogin.Text + "', '" + mtbPassword.Text + "', '" + mtbE_mail.Text + "')";
                OleDbCommand command1 = new OleDbCommand(cmdText, connection);
                command1.ExecuteNonQuery();
                this.Close();
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
            this.Close();
        }
    }
}
