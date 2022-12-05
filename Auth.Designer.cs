namespace coursework
{
    partial class Auth
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
        public System.Windows.Forms.Button buttonAuth;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.AuthButton = new Guna.UI2.WinForms.Guna2Button();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AuthPicture = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.LoginField = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.BodyPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthPicture)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Additional_Background;
            this.BodyPanel.Controls.Add(this.PasswordField);
            this.BodyPanel.Controls.Add(this.LoginField);
            this.BodyPanel.Controls.Add(this.AuthButton);
            this.BodyPanel.Controls.Add(this.FooterPanel);
            this.BodyPanel.Controls.Add(this.CreateLinkLabel);
            this.BodyPanel.Controls.Add(this.AuthPicture);
            this.BodyPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 70);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(334, 416);
            this.BodyPanel.TabIndex = 0;
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.Transparent;
            this.AuthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AuthButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AuthButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AuthButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AuthButton.FillColor = System.Drawing.Color.Transparent;
            this.AuthButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AuthButton.ForeColor = System.Drawing.Color.White;
            this.AuthButton.ImageSize = new System.Drawing.Size(0, 0);
            this.AuthButton.Location = new System.Drawing.Point(117, 199);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(100, 21);
            this.AuthButton.TabIndex = 35;
            this.AuthButton.Text = "Войти";
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.Transparent;
            this.FooterPanel.Controls.Add(this.pictureBox1);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 281);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(334, 135);
            this.FooterPanel.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(72, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // CreateLinkLabel
            // 
            this.CreateLinkLabel.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.CreateLinkLabel.AutoSize = true;
            this.CreateLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateLinkLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreateLinkLabel.LinkColor = System.Drawing.Color.White;
            this.CreateLinkLabel.Location = new System.Drawing.Point(35, 247);
            this.CreateLinkLabel.Name = "CreateLinkLabel";
            this.CreateLinkLabel.Size = new System.Drawing.Size(266, 16);
            this.CreateLinkLabel.TabIndex = 6;
            this.CreateLinkLabel.TabStop = true;
            this.CreateLinkLabel.Text = "Нет учётной записи? Зарегистрируйся!";
            this.CreateLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.CreateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateLinkLabel_LinkClicked);
            // 
            // AuthPicture
            // 
            this.AuthPicture.BackColor = System.Drawing.Color.Transparent;
            this.AuthPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AuthPicture.ErrorImage = null;
            this.AuthPicture.Image = global::Course_work.Properties.Resources.Users;
            this.AuthPicture.InitialImage = null;
            this.AuthPicture.Location = new System.Drawing.Point(135, 6);
            this.AuthPicture.Name = "AuthPicture";
            this.AuthPicture.Size = new System.Drawing.Size(64, 64);
            this.AuthPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthPicture.TabIndex = 2;
            this.AuthPicture.TabStop = false;
            this.AuthPicture.Click += new System.EventHandler(this.AuthPicture_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.HeaderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderPanel.BackgroundImage")));
            this.HeaderPanel.Controls.Add(this.AuthLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(334, 70);
            this.HeaderPanel.TabIndex = 3;
            // 
            // AuthLabel
            // 
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLabel.ForeColor = System.Drawing.Color.White;
            this.AuthLabel.Location = new System.Drawing.Point(91, 25);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(155, 25);
            this.AuthLabel.TabIndex = 2;
            this.AuthLabel.Text = "Авторизация";
            this.AuthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.LoginField.Location = new System.Drawing.Point(75, 93);
            this.LoginField.Name = "LoginField";
            this.LoginField.PasswordChar = '\0';
            this.LoginField.PlaceholderText = "Логин";
            this.LoginField.SelectedText = "";
            this.LoginField.Size = new System.Drawing.Size(187, 21);
            this.LoginField.TabIndex = 36;
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
            this.PasswordField.Location = new System.Drawing.Point(75, 143);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';
            this.PasswordField.PlaceholderText = "Пароль";
            this.PasswordField.SelectedText = "";
            this.PasswordField.Size = new System.Drawing.Size(187, 21);
            this.PasswordField.TabIndex = 37;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 486);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.Text = "Auth";
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthPicture)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox AuthPicture;
        private System.Windows.Forms.LinkLabel CreateLinkLabel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AuthLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2Button AuthButton;
        private Guna.UI2.WinForms.Guna2TextBox PasswordField;
        private Guna.UI2.WinForms.Guna2TextBox LoginField;
    }
}