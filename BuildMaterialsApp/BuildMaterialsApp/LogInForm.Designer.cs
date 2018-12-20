namespace BuildMaterialsApp
{
    partial class LogInForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbLogin = new MetroFramework.Controls.MetroTextBox();
            this.mtbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 155);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Логин:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Пароль:";
            // 
            // mtbLogin
            // 
            // 
            // 
            // 
            this.mtbLogin.CustomButton.Image = null;
            this.mtbLogin.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.mtbLogin.CustomButton.Name = "";
            this.mtbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbLogin.CustomButton.TabIndex = 1;
            this.mtbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbLogin.CustomButton.UseSelectable = true;
            this.mtbLogin.CustomButton.Visible = false;
            this.mtbLogin.Lines = new string[0];
            this.mtbLogin.Location = new System.Drawing.Point(86, 155);
            this.mtbLogin.MaxLength = 32767;
            this.mtbLogin.Name = "mtbLogin";
            this.mtbLogin.PasswordChar = '\0';
            this.mtbLogin.PromptText = "user_name";
            this.mtbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbLogin.SelectedText = "";
            this.mtbLogin.SelectionLength = 0;
            this.mtbLogin.SelectionStart = 0;
            this.mtbLogin.ShortcutsEnabled = true;
            this.mtbLogin.Size = new System.Drawing.Size(158, 23);
            this.mtbLogin.TabIndex = 1;
            this.mtbLogin.UseSelectable = true;
            this.mtbLogin.WaterMark = "user_name";
            this.mtbLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbPassword
            // 
            // 
            // 
            // 
            this.mtbPassword.CustomButton.Image = null;
            this.mtbPassword.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.mtbPassword.CustomButton.Name = "";
            this.mtbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPassword.CustomButton.TabIndex = 1;
            this.mtbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPassword.CustomButton.UseSelectable = true;
            this.mtbPassword.CustomButton.Visible = false;
            this.mtbPassword.Lines = new string[0];
            this.mtbPassword.Location = new System.Drawing.Point(86, 184);
            this.mtbPassword.MaxLength = 32767;
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.PasswordChar = '\0';
            this.mtbPassword.PromptText = "user_password";
            this.mtbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPassword.SelectedText = "";
            this.mtbPassword.SelectionLength = 0;
            this.mtbPassword.SelectionStart = 0;
            this.mtbPassword.ShortcutsEnabled = true;
            this.mtbPassword.Size = new System.Drawing.Size(158, 23);
            this.mtbPassword.TabIndex = 1;
            this.mtbPassword.UseSelectable = true;
            this.mtbPassword.WaterMark = "user_password";
            this.mtbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(169, 328);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Войти";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 328);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(93, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Регистрация";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Location = new System.Drawing.Point(134, 215);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(50, 17);
            this.metroToggle1.TabIndex = 3;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Администратор";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 392);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mtbPassword);
            this.Controls.Add(this.mtbLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LogInForm";
            this.Resizable = false;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbLogin;
        private MetroFramework.Controls.MetroTextBox mtbPassword;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

