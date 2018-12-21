namespace BuildMaterialsApp
{
    partial class NewProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnChooseImage = new MetroFramework.Controls.MetroButton();
            this.cbCutegory = new MetroFramework.Controls.MetroComboBox();
            this.tbCountry = new MetroFramework.Controls.MetroTextBox();
            this.tbDescription = new MetroFramework.Controls.MetroTextBox();
            this.tbCount = new MetroFramework.Controls.MetroTextBox();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.btnChooseImage);
            this.metroPanel1.Controls.Add(this.cbCutegory);
            this.metroPanel1.Controls.Add(this.tbCountry);
            this.metroPanel1.Controls.Add(this.tbDescription);
            this.metroPanel1.Controls.Add(this.tbCount);
            this.metroPanel1.Controls.Add(this.tbName);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(400, 270);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(37, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(37, 114);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(181, 23);
            this.btnChooseImage.TabIndex = 4;
            this.btnChooseImage.Text = "Выбрать изображение";
            this.btnChooseImage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnChooseImage.UseSelectable = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // cbCutegory
            // 
            this.cbCutegory.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbCutegory.FormattingEnabled = true;
            this.cbCutegory.ItemHeight = 19;
            this.cbCutegory.Items.AddRange(new object[] {
            "Герметики",
            "Гидроизоляция",
            "Гипсокартон",
            "Клеи монтажные",
            "Окна",
            "Пены монтажные",
            "Цемент",
            "Штукатурка",
            "Изоляция",
            "Канализация"});
            this.cbCutegory.Location = new System.Drawing.Point(224, 83);
            this.cbCutegory.Name = "cbCutegory";
            this.cbCutegory.PromptText = "Категория товара";
            this.cbCutegory.Size = new System.Drawing.Size(139, 25);
            this.cbCutegory.TabIndex = 3;
            this.cbCutegory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbCutegory.UseSelectable = true;
            // 
            // tbCountry
            // 
            // 
            // 
            // 
            this.tbCountry.CustomButton.Image = null;
            this.tbCountry.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.tbCountry.CustomButton.Name = "";
            this.tbCountry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCountry.CustomButton.TabIndex = 1;
            this.tbCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCountry.CustomButton.UseSelectable = true;
            this.tbCountry.CustomButton.Visible = false;
            this.tbCountry.Lines = new string[0];
            this.tbCountry.Location = new System.Drawing.Point(37, 232);
            this.tbCountry.MaxLength = 32767;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.PasswordChar = '\0';
            this.tbCountry.PromptText = "Страна производитель";
            this.tbCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCountry.SelectedText = "";
            this.tbCountry.SelectionLength = 0;
            this.tbCountry.SelectionStart = 0;
            this.tbCountry.ShortcutsEnabled = true;
            this.tbCountry.Size = new System.Drawing.Size(181, 23);
            this.tbCountry.TabIndex = 2;
            this.tbCountry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbCountry.UseSelectable = true;
            this.tbCountry.WaterMark = "Страна производитель";
            this.tbCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDescription
            // 
            // 
            // 
            // 
            this.tbDescription.CustomButton.Image = null;
            this.tbDescription.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.tbDescription.CustomButton.Name = "";
            this.tbDescription.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescription.CustomButton.TabIndex = 1;
            this.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescription.CustomButton.UseSelectable = true;
            this.tbDescription.CustomButton.Visible = false;
            this.tbDescription.Lines = new string[0];
            this.tbDescription.Location = new System.Drawing.Point(37, 146);
            this.tbDescription.MaxLength = 32767;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.PromptText = "Описание товара";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.ShortcutsEnabled = true;
            this.tbDescription.Size = new System.Drawing.Size(326, 77);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbDescription.UseSelectable = true;
            this.tbDescription.WaterMark = "Описание товара";
            this.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbCount
            // 
            // 
            // 
            // 
            this.tbCount.CustomButton.Image = null;
            this.tbCount.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.tbCount.CustomButton.Name = "";
            this.tbCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCount.CustomButton.TabIndex = 1;
            this.tbCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCount.CustomButton.UseSelectable = true;
            this.tbCount.CustomButton.Visible = false;
            this.tbCount.Lines = new string[0];
            this.tbCount.Location = new System.Drawing.Point(224, 49);
            this.tbCount.MaxLength = 32767;
            this.tbCount.Name = "tbCount";
            this.tbCount.PasswordChar = '\0';
            this.tbCount.PromptText = "колчиество";
            this.tbCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCount.SelectedText = "";
            this.tbCount.SelectionLength = 0;
            this.tbCount.SelectionStart = 0;
            this.tbCount.ShortcutsEnabled = true;
            this.tbCount.Size = new System.Drawing.Size(139, 23);
            this.tbCount.TabIndex = 2;
            this.tbCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbCount.UseSelectable = true;
            this.tbCount.WaterMark = "колчиество";
            this.tbCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(224, 15);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PromptText = "Название товара";
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(139, 23);
            this.tbName.TabIndex = 2;
            this.tbName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMark = "Название товара";
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "NewProductControl";
            this.Size = new System.Drawing.Size(400, 270);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnChooseImage;
        private MetroFramework.Controls.MetroComboBox cbCutegory;
        private MetroFramework.Controls.MetroTextBox tbCountry;
        private MetroFramework.Controls.MetroTextBox tbDescription;
        private MetroFramework.Controls.MetroTextBox tbCount;
        private MetroFramework.Controls.MetroTextBox tbName;
    }
}
