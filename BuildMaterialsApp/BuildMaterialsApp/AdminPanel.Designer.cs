namespace BuildMaterialsApp
{
    partial class AdminPanel
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewAdmin = new MetroFramework.Controls.MetroButton();
            this.btnChangeProduct = new MetroFramework.Controls.MetroButton();
            this.btnRemoveProduct = new MetroFramework.Controls.MetroButton();
            this.btnAddNewProduct = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.flowLayoutPanel1);
            this.metroPanel1.Controls.Add(this.btnAddNewAdmin);
            this.metroPanel1.Controls.Add(this.btnChangeProduct);
            this.metroPanel1.Controls.Add(this.btnRemoveProduct);
            this.metroPanel1.Controls.Add(this.btnAddNewProduct);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(570, 370);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(67, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 280);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnAddNewAdmin
            // 
            this.btnAddNewAdmin.Location = new System.Drawing.Point(67, 48);
            this.btnAddNewAdmin.Name = "btnAddNewAdmin";
            this.btnAddNewAdmin.Size = new System.Drawing.Size(417, 23);
            this.btnAddNewAdmin.TabIndex = 2;
            this.btnAddNewAdmin.Text = "Добавить нового администратора";
            this.btnAddNewAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddNewAdmin.UseSelectable = true;
            this.btnAddNewAdmin.Click += new System.EventHandler(this.btnAddNewAdmin_Click);
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.Location = new System.Drawing.Point(208, 19);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(135, 23);
            this.btnChangeProduct.TabIndex = 2;
            this.btnChangeProduct.Text = "Изменить товар";
            this.btnChangeProduct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnChangeProduct.UseSelectable = true;
            this.btnChangeProduct.Click += new System.EventHandler(this.btnChangeProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(349, 19);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveProduct.TabIndex = 2;
            this.btnRemoveProduct.Text = "Удалить товар";
            this.btnRemoveProduct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveProduct.UseSelectable = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(67, 19);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(135, 23);
            this.btnAddNewProduct.TabIndex = 2;
            this.btnAddNewProduct.Text = "Добавить новый товар";
            this.btnAddNewProduct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddNewProduct.UseSelectable = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(570, 370);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnAddNewAdmin;
        private MetroFramework.Controls.MetroButton btnChangeProduct;
        private MetroFramework.Controls.MetroButton btnRemoveProduct;
        private MetroFramework.Controls.MetroButton btnAddNewProduct;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
