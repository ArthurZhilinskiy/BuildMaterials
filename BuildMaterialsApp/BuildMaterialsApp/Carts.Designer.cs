namespace BuildMaterialsApp
{
    partial class Carts
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
            this.pbImageProduct = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lCountProduct = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lCountryProduct = new MetroFramework.Controls.MetroLabel();
            this.lNameProduct = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.Location = new System.Drawing.Point(3, 3);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(184, 97);
            this.pbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageProduct.TabIndex = 0;
            this.pbImageProduct.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(3, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 15);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "На складе:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(3, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 15);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Название:";
            // 
            // lCountProduct
            // 
            this.lCountProduct.AutoSize = true;
            this.lCountProduct.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lCountProduct.Location = new System.Drawing.Point(70, 122);
            this.lCountProduct.Name = "lCountProduct";
            this.lCountProduct.Size = new System.Drawing.Size(23, 15);
            this.lCountProduct.TabIndex = 1;
            this.lCountProduct.Text = "100";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(3, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 15);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Страна:";
            // 
            // lCountryProduct
            // 
            this.lCountryProduct.AutoSize = true;
            this.lCountryProduct.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lCountryProduct.Location = new System.Drawing.Point(70, 142);
            this.lCountryProduct.Name = "lCountryProduct";
            this.lCountryProduct.Size = new System.Drawing.Size(59, 15);
            this.lCountryProduct.TabIndex = 1;
            this.lCountryProduct.Text = "Германия";
            // 
            // lNameProduct
            // 
            this.lNameProduct.AutoSize = true;
            this.lNameProduct.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lNameProduct.Location = new System.Drawing.Point(68, 103);
            this.lNameProduct.Name = "lNameProduct";
            this.lNameProduct.Size = new System.Drawing.Size(71, 15);
            this.lNameProduct.TabIndex = 1;
            this.lNameProduct.Text = "Имя_товара";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(97, 185);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(90, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Купить";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(3, 185);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(90, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Подробнее";
            this.metroButton2.UseSelectable = true;
            // 
            // Carts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lNameProduct);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lCountryProduct);
            this.Controls.Add(this.lCountProduct);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pbImageProduct);
            this.Name = "Carts";
            this.Size = new System.Drawing.Size(190, 211);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageProduct;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroLabel lCountProduct;
        public MetroFramework.Controls.MetroLabel lCountryProduct;
        public MetroFramework.Controls.MetroLabel lNameProduct;
    }
}
