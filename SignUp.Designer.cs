namespace coursework
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SingUpLabel = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.PhoneField = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginField = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailField = new Guna.UI2.WinForms.Guna2TextBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AuthLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CreatePicture = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.HeaderPanel.BackgroundImage = global::Course_work.Properties.Resources.Additional_Panel_Background;
            this.HeaderPanel.Controls.Add(this.SingUpLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(334, 70);
            this.HeaderPanel.TabIndex = 0;
            // 
            // SingUpLabel
            // 
            this.SingUpLabel.AutoSize = true;
            this.SingUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.SingUpLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingUpLabel.ForeColor = System.Drawing.Color.White;
            this.SingUpLabel.Location = new System.Drawing.Point(21, 21);
            this.SingUpLabel.Name = "SingUpLabel";
            this.SingUpLabel.Size = new System.Drawing.Size(294, 25);
            this.SingUpLabel.TabIndex = 3;
            this.SingUpLabel.Text = "Создайте учётную запись";
            this.SingUpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Additional_Background;
            this.BodyPanel.Controls.Add(this.PhoneField);
            this.BodyPanel.Controls.Add(this.LoginField);
            this.BodyPanel.Controls.Add(this.PasswordField);
            this.BodyPanel.Controls.Add(this.EmailField);
            this.BodyPanel.Controls.Add(this.FooterPanel);
            this.BodyPanel.Controls.Add(this.AuthLinkLabel);
            this.BodyPanel.Controls.Add(this.CreateButton);
            this.BodyPanel.Controls.Add(this.CreatePicture);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 70);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(334, 416);
            this.BodyPanel.TabIndex = 0;
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
            this.PhoneField.ForeColor = System.Drawing.Color.Black;
            this.PhoneField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneField.Location = new System.Drawing.Point(94, 230);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.PasswordChar = '\0';
            this.PhoneField.PlaceholderText = "Телефон";
            this.PhoneField.SelectedText = "";
            this.PhoneField.Size = new System.Drawing.Size(145, 21);
            this.PhoneField.TabIndex = 37;
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
            this.LoginField.ForeColor = System.Drawing.Color.Black;
            this.LoginField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginField.Location = new System.Drawing.Point(94, 85);
            this.LoginField.Name = "LoginField";
            this.LoginField.PasswordChar = '\0';
            this.LoginField.PlaceholderText = "Логин";
            this.LoginField.SelectedText = "";
            this.LoginField.Size = new System.Drawing.Size(145, 21);
            this.LoginField.TabIndex = 38;
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
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordField.Location = new System.Drawing.Point(94, 130);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';
            this.PasswordField.PlaceholderText = "Пароль";
            this.PasswordField.SelectedText = "";
            this.PasswordField.Size = new System.Drawing.Size(145, 21);
            this.PasswordField.TabIndex = 37;
            this.PasswordField.UseSystemPasswordChar = true;
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
            this.EmailField.ForeColor = System.Drawing.Color.Black;
            this.EmailField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailField.Location = new System.Drawing.Point(94, 180);
            this.EmailField.Name = "EmailField";
            this.EmailField.PasswordChar = '\0';
            this.EmailField.PlaceholderText = "Email";
            this.EmailField.SelectedText = "";
            this.EmailField.Size = new System.Drawing.Size(145, 21);
            this.EmailField.TabIndex = 36;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.Transparent;
            this.FooterPanel.Controls.Add(this.guna2HtmlLabel2);
            this.FooterPanel.Controls.Add(this.guna2HtmlLabel1);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 346);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(334, 70);
            this.FooterPanel.TabIndex = 35;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(88, 40);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(156, 25);
            this.guna2HtmlLabel2.TabIndex = 46;
            this.guna2HtmlLabel2.Text = "Группа компаний";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(110, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(113, 35);
            this.guna2HtmlLabel1.TabIndex = 45;
            this.guna2HtmlLabel1.Text = "САТУРН";
            // 
            // AuthLinkLabel
            // 
            this.AuthLinkLabel.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.AuthLinkLabel.AutoSize = true;
            this.AuthLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthLinkLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AuthLinkLabel.LinkColor = System.Drawing.Color.White;
            this.AuthLinkLabel.Location = new System.Drawing.Point(69, 315);
            this.AuthLinkLabel.Name = "AuthLinkLabel";
            this.AuthLinkLabel.Size = new System.Drawing.Size(196, 16);
            this.AuthLinkLabel.TabIndex = 13;
            this.AuthLinkLabel.TabStop = true;
            this.AuthLinkLabel.Text = "Есть учётная запись? Войти!";
            this.AuthLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.AuthLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthLinkLabel_LinkClicked);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(117, 280);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreatePicture
            // 
            this.CreatePicture.BackColor = System.Drawing.Color.Transparent;
            this.CreatePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreatePicture.ErrorImage = null;
            this.CreatePicture.Image = ((System.Drawing.Image)(resources.GetObject("CreatePicture.Image")));
            this.CreatePicture.InitialImage = null;
            this.CreatePicture.Location = new System.Drawing.Point(135, 6);
            this.CreatePicture.Name = "CreatePicture";
            this.CreatePicture.Size = new System.Drawing.Size(64, 64);
            this.CreatePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreatePicture.TabIndex = 3;
            this.CreatePicture.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 486);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label SingUpLabel;
        private System.Windows.Forms.PictureBox CreatePicture;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.LinkLabel AuthLinkLabel;
        private System.Windows.Forms.Panel FooterPanel;
        private Guna.UI2.WinForms.Guna2TextBox PhoneField;
        private Guna.UI2.WinForms.Guna2TextBox EmailField;
        private Guna.UI2.WinForms.Guna2TextBox PasswordField;
        private Guna.UI2.WinForms.Guna2TextBox LoginField;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}