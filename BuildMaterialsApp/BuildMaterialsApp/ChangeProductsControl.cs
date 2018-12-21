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
    public partial class ChangeProductsControl : UserControl
    {
        string ID_Product;
        public ChangeProductsControl()
        {
            InitializeComponent();
            LoadDataOnDataGrid();
        }
        string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\BuildDB.mdb";

        void LoadDataOnDataGrid()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Products", connection);
                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader["ID"].ToString();
                    data[data.Count - 1][1] = reader["Product_name"].ToString();
                    data[data.Count - 1][2] = reader["Product_cutegory"].ToString();
                    data[data.Count - 1][3] = reader["Product_count"].ToString();
                    data[data.Count - 1][4] = reader["Product_description"].ToString();
                    data[data.Count - 1][5] = reader["Product_country"].ToString();
                }

                foreach (string[] s in data)
                    metroGrid1.Rows.Add(s);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand oleDbCommand = new OleDbCommand("UPDATE PRODUCTS SET Product_name = ?, Product_cutegory = ?, Product_count = ?, Product_description = ?, Product_country = ?, Product_image = ? WHERE ID = ?", connection);

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
                Image image = Image.FromFile(tbPath.Text);
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                OleDbParameter oleDbParameter5 = new OleDbParameter("Product_image", OleDbType.VarBinary);
                oleDbParameter5.Value = memoryStream.ToArray();
                oleDbCommand.Parameters.Add(oleDbParameter5);

                OleDbParameter oleDbParameter6 = new OleDbParameter("Product_country", OleDbType.VarChar);
                oleDbParameter6.Value = ID_Product;
                oleDbCommand.Parameters.Add(oleDbParameter6);

                oleDbCommand.ExecuteNonQuery();
                memoryStream.Dispose();

                metroGrid1.Rows.Clear();
                LoadDataOnDataGrid();

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
        
        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            ID_Product = (string)metroGrid1.CurrentRow.Cells[0].Value;
            tbName.Text = (string)metroGrid1.CurrentRow.Cells[1].Value;
            cbCutegory.Text = (string)metroGrid1.CurrentRow.Cells[2].Value;
            tbCount.Text = (string)metroGrid1.CurrentRow.Cells[3].Value;
            tbDescription.Text = (string)metroGrid1.CurrentRow.Cells[4].Value;
            tbCountry.Text = (string)metroGrid1.CurrentRow.Cells[5].Value;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG )| *.BMP; *.JPG; *.PNG | All files(*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = openFileDialog.FileName;
            }
        }
    }
}
