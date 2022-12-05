namespace Course_work.Users
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.AccessLevelField = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneField = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailField = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginField = new Guna.UI2.WinForms.Guna2TextBox();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.AreaOfWorkLabel = new System.Windows.Forms.Label();
            this.WorkPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.AccessLevelField);
            this.BodyPanel.Controls.Add(this.PhoneField);
            this.BodyPanel.Controls.Add(this.EmailField);
            this.BodyPanel.Controls.Add(this.PasswordField);
            this.BodyPanel.Controls.Add(this.LoginField);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.AreaOfWorkLabel);
            this.BodyPanel.Controls.Add(this.WorkPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(834, 461);
            this.BodyPanel.TabIndex = 5;
            // 
            // AccessLevelField
            // 
            this.AccessLevelField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccessLevelField.DefaultText = "";
            this.AccessLevelField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AccessLevelField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AccessLevelField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AccessLevelField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AccessLevelField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AccessLevelField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AccessLevelField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AccessLevelField.Location = new System.Drawing.Point(484, 271);
            this.AccessLevelField.Name = "AccessLevelField";
            this.AccessLevelField.PasswordChar = '\0';
            this.AccessLevelField.PlaceholderText = "Уровень доступа";
            this.AccessLevelField.SelectedText = "";
            this.AccessLevelField.Size = new System.Drawing.Size(190, 21);
            this.AccessLevelField.TabIndex = 37;
            // 
            // PhoneField
            // 
            this.PhoneField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneField.DefaultText = "";
            this.PhoneField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneField.Location = new System.Drawing.Point(484, 228);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.PasswordChar = '\0';
            this.PhoneField.PlaceholderText = "Телефон";
            this.PhoneField.SelectedText = "";
            this.PhoneField.Size = new System.Drawing.Size(190, 21);
            this.PhoneField.TabIndex = 36;
            // 
            // EmailField
            // 
            this.EmailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailField.DefaultText = "";
            this.EmailField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailField.Location = new System.Drawing.Point(484, 162);
            this.EmailField.Name = "EmailField";
            this.EmailField.PasswordChar = '\0';
            this.EmailField.PlaceholderText = "Email";
            this.EmailField.SelectedText = "";
            this.EmailField.Size = new System.Drawing.Size(190, 21);
            this.EmailField.TabIndex = 35;
            // 
            // PasswordField
            // 
            this.PasswordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordField.DefaultText = "";
            this.PasswordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordField.Location = new System.Drawing.Point(484, 109);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';
            this.PasswordField.PlaceholderText = "Пароль";
            this.PasswordField.SelectedText = "";
            this.PasswordField.Size = new System.Drawing.Size(190, 21);
            this.PasswordField.TabIndex = 34;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginField.DefaultText = "";
            this.LoginField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginField.Location = new System.Drawing.Point(484, 55);
            this.LoginField.Name = "LoginField";
            this.LoginField.PasswordChar = '\0';
            this.LoginField.PlaceholderText = "Имя пользователя";
            this.LoginField.SelectedText = "";
            this.LoginField.Size = new System.Drawing.Size(190, 21);
            this.LoginField.TabIndex = 33;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelButton.FillColor = System.Drawing.Color.Transparent;
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.ImageSize = new System.Drawing.Size(0, 0);
            this.CancelButton.Location = new System.Drawing.Point(545, 385);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 50);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.Transparent;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ImageSize = new System.Drawing.Size(0, 0);
            this.AddButton.Location = new System.Drawing.Point(545, 317);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AreaOfWorkLabel
            // 
            this.AreaOfWorkLabel.AutoSize = true;
            this.AreaOfWorkLabel.BackColor = System.Drawing.Color.Transparent;
            this.AreaOfWorkLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AreaOfWorkLabel.ForeColor = System.Drawing.Color.White;
            this.AreaOfWorkLabel.Location = new System.Drawing.Point(114, 21);
            this.AreaOfWorkLabel.Name = "AreaOfWorkLabel";
            this.AreaOfWorkLabel.Size = new System.Drawing.Size(529, 19);
            this.AreaOfWorkLabel.TabIndex = 23;
            this.AreaOfWorkLabel.Text = "Для внесения данных в таблицу заполните следующие поля:";
            this.AreaOfWorkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WorkPicture
            // 
            this.WorkPicture.BackColor = System.Drawing.Color.Transparent;
            this.WorkPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WorkPicture.ErrorImage = null;
            this.WorkPicture.Image = global::Course_work.Properties.Resources.Users;
            this.WorkPicture.InitialImage = null;
            this.WorkPicture.Location = new System.Drawing.Point(514, 55);
            this.WorkPicture.Name = "WorkPicture";
            this.WorkPicture.Size = new System.Drawing.Size(256, 256);
            this.WorkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WorkPicture.TabIndex = 3;
            this.WorkPicture.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.LeftPanel.BackgroundImage = global::Course_work.Properties.Resources.Panel_Background;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(95, 461);
            this.LeftPanel.TabIndex = 20;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accounts";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label AreaOfWorkLabel;
        private System.Windows.Forms.PictureBox WorkPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2TextBox AccessLevelField;
        private Guna.UI2.WinForms.Guna2TextBox PhoneField;
        private Guna.UI2.WinForms.Guna2TextBox EmailField;
        private Guna.UI2.WinForms.Guna2TextBox PasswordField;
        private Guna.UI2.WinForms.Guna2TextBox LoginField;
    }
}