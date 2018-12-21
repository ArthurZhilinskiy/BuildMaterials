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
using System.IO;

namespace BuildMaterialsApp
{
    public partial class NewProductControl : UserControl
    {
        AdminPanel adminPanel;
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";
        public NewProductControl()
        {
            InitializeComponent();
        }

        public NewProductControl(AdminPanel adminPanel)
        {
            InitializeComponent();
            this.adminPanel = adminPanel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO Products ( Product_name, Product_cutegory, Product_count, Product_description, Product_country, Product_image ) VALUES ( ?, ?, ?, ?, ?, ? ) ", connection);

                OleDbParameter oleDbParameter = new OleDbParameter("Product_name", OleDbType.VarChar);
                oleDbParameter.Value = tbName.Text;
                oleDbCommand.Parameters.Add(oleDbParameter);

                OleDbParameter oleDbParameter1 = new OleDbParameter("Product_cutegory", OleDbType.VarChar);
                oleDbParameter1.Value = cbCutegory.Text;
                oleDbCommand.Parameters.Add(oleDbParameter1);

                OleDbParameter oleDbParameter2 = new OleDbParameter("Product_count", OleDbType.VarChar);
                oleDbParameter2.Value = tbCount.Text;
                oleDbCommand.Parameters.Add(oleDbParameter2);

                OleDbParameter oleDbParameter3 = new OleDbParameter("Product_description", OleDbType.VarChar);
                oleDbParameter3.Value = tbDescription.Text;
                oleDbCommand.Parameters.Add(oleDbParameter3);

                OleDbParameter oleDbParameter4 = new OleDbParameter("Product_country", OleDbType.VarChar);
                oleDbParameter4.Value = tbCountry.Text;
                oleDbCommand.Parameters.Add(oleDbParameter4);

                MemoryStream memoryStream = new MemoryStream();
                Image image = pictureBox1.Image;
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                OleDbParameter oleDbParameter5 = new OleDbParameter("Product_image", OleDbType.VarBinary);
                oleDbParameter5.Value = memoryStream.ToArray();
                oleDbCommand.Parameters.Add(oleDbParameter5);

                oleDbCommand.ExecuteNonQuery();
                memoryStream.Dispose();
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

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG )| *.BMP; *.JPG; *.PNG | All files(*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = img;
            }
        }
    }
}
