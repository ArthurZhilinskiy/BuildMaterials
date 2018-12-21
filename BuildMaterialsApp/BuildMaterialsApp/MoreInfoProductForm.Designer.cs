namespace BuildMaterialsApp
{
    partial class MoreInfoProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lName = new MetroFramework.Controls.MetroLabel();
            this.tbDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lCountry = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Silver;
            this.pbImage.Location = new System.Drawing.Point(24, 66);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(250, 150);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lName.Location = new System.Drawing.Point(24, 38);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(103, 25);
            this.lName.TabIndex = 1;
            this.lName.Text = "metroLabel1";
            // 
            // tbDescription
            // 
            // 
            // 
            // 
            this.tbDescription.CustomButton.Image = null;
            this.tbDescription.CustomButton.Location = new System.Drawing.Point(44, 2);
            this.tbDescription.CustomButton.Name = "";
            this.tbDescription.CustomButton.Size = new System.Drawing.Size(203, 203);
            this.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescription.CustomButton.TabIndex = 1;
            this.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescription.CustomButton.UseSelectable = true;
            this.tbDescription.CustomButton.Visible = false;
            this.tbDescription.Lines = new string[0];
            this.tbDescription.Location = new System.Drawing.Point(24, 247);
            this.tbDescription.MaxLength = 32767;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.ShortcutsEnabled = true;
            this.tbDescription.Size = new System.Drawing.Size(250, 208);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.UseSelectable = true;
            this.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 222);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Страна производитель:";
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Location = new System.Drawing.Point(183, 222);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(81, 19);
            this.lCountry.TabIndex = 1;
            this.lCountry.Text = "metroLabel1";
            // 
            // MoreInfoProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 496);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lCountry);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lName);
            this.MaximizeBox = false;
            this.Name = "MoreInfoProductForm";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroLabel lName;
        public System.Windows.Forms.PictureBox pbImage;
        private MetroFramework.Controls.MetroTextBox tbDescription;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel lCountry;
    }
}