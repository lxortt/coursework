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
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.SaturnLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CreateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AuthButton = new System.Windows.Forms.Button();
            this.AuthPicture = new System.Windows.Forms.PictureBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.FooterPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.FooterPanel.Controls.Add(this.SaturnLabel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 416);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(334, 70);
            this.FooterPanel.TabIndex = 0;
            // 
            // SaturnLabel
            // 
            this.SaturnLabel.AutoSize = true;
            this.SaturnLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaturnLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaturnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.SaturnLabel.Location = new System.Drawing.Point(76, 14);
            this.SaturnLabel.Name = "SaturnLabel";
            this.SaturnLabel.Size = new System.Drawing.Size(194, 16);
            this.SaturnLabel.TabIndex = 4;
            this.SaturnLabel.Text = "Group of companies \"Saturn\"";
            this.SaturnLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
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
            this.AuthLabel.Location = new System.Drawing.Point(96, 27);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(155, 25);
            this.AuthLabel.TabIndex = 2;
            this.AuthLabel.Text = "Авторизация";
            this.AuthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyPanel.BackgroundImage")));
            this.BodyPanel.Controls.Add(this.CreateLinkLabel);
            this.BodyPanel.Controls.Add(this.AuthButton);
            this.BodyPanel.Controls.Add(this.AuthPicture);
            this.BodyPanel.Controls.Add(this.PasswordLabel);
            this.BodyPanel.Controls.Add(this.LoginLabel);
            this.BodyPanel.Controls.Add(this.PasswordField);
            this.BodyPanel.Controls.Add(this.LoginField);
            this.BodyPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 70);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(334, 346);
            this.BodyPanel.TabIndex = 0;
            // 
            // CreateLinkLabel
            // 
            this.CreateLinkLabel.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.CreateLinkLabel.AutoSize = true;
            this.CreateLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateLinkLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreateLinkLabel.LinkColor = System.Drawing.Color.Coral;
            this.CreateLinkLabel.Location = new System.Drawing.Point(41, 257);
            this.CreateLinkLabel.Name = "CreateLinkLabel";
            this.CreateLinkLabel.Size = new System.Drawing.Size(265, 16);
            this.CreateLinkLabel.TabIndex = 6;
            this.CreateLinkLabel.TabStop = true;
            this.CreateLinkLabel.Text = "Нет учётной записи? Зарегистрируйся!";
            this.CreateLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.CreateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateLinkLabel_LinkClicked);
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.Transparent;
            this.AuthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AuthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthButton.FlatAppearance.BorderSize = 0;
            this.AuthButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.AuthButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.AuthButton.Location = new System.Drawing.Point(126, 181);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(100, 23);
            this.AuthButton.TabIndex = 5;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // AuthPicture
            // 
            this.AuthPicture.BackColor = System.Drawing.Color.Transparent;
            this.AuthPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AuthPicture.ErrorImage = null;
            this.AuthPicture.Image = ((System.Drawing.Image)(resources.GetObject("AuthPicture.Image")));
            this.AuthPicture.InitialImage = null;
            this.AuthPicture.Location = new System.Drawing.Point(142, 12);
            this.AuthPicture.Name = "AuthPicture";
            this.AuthPicture.Size = new System.Drawing.Size(64, 64);
            this.AuthPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthPicture.TabIndex = 2;
            this.AuthPicture.TabStop = false;
            this.AuthPicture.Click += new System.EventHandler(this.AuthPicture_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Violet;
            this.PasswordLabel.Location = new System.Drawing.Point(63, 128);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 16);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.LoginLabel.Location = new System.Drawing.Point(63, 83);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 16);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PasswordField.Location = new System.Drawing.Point(126, 128);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(100, 21);
            this.PasswordField.TabIndex = 1;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginField.Location = new System.Drawing.Point(126, 82);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(100, 21);
            this.LoginField.TabIndex = 0;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 486);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "Auth";
            this.Text = "Form2";
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label AuthLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.PictureBox AuthPicture;
        private System.Windows.Forms.LinkLabel CreateLinkLabel;
        private System.Windows.Forms.Label SaturnLabel;
    }
}