using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
                flowLayoutPanel1.Controls.Clear();
                connection.Open();
                OleDbCommand command = new OleDbCommand(cmdText, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MemoryStream memoryStream = new MemoryStream();
                    memoryStream.Write((byte[])reader["Product_image"], 0, ((byte[])reader["Product_image"]).Length);
                    Image image = Image.FromStream(memoryStream);
                    // создаем карточку с продуктом
                    Carts cart = new Carts(reader["Product_name"].ToString(),
                                           reader["Product_count"].ToString(),
                                           reader["Product_description"].ToString(),
                                           reader["Product_country"].ToString(),
                                           image );
                    memoryStream.Dispose();
                    flowLayoutPanel1.Controls.Add(cart);
                }
            }
            catch(Exception ex)
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
            flowLayoutPanel1.Controls.Clear();
            AdminPanel adminPanel = new AdminPanel();
            flowLayoutPanel1.Controls.Add(adminPanel);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Герметики'");
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Гидроизоляция'");
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Гипсокартон'");
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Клеи монтажные'");
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Окна'");
        }

        private void metroLink6_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Пены монтажные'");
        }

        private void metroLink7_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Цемент'");
        }

        private void metroLink8_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Штукатурки'");
        }

        private void metroLink9_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Изоляция'");
        }

        private void metroLink10_Click(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_cutegory = 'Канализация'");
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            GetDataFromCategories("SELECT * FROM Products WHERE Product_name LIKE '%"+metroTextBox1.Text+"%'");
        }
    }
}
