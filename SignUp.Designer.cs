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
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.AuthLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.CreatePicture = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.SingUpLabel.Location = new System.Drawing.Point(20, 21);
            this.SingUpLabel.Name = "SingUpLabel";
            this.SingUpLabel.Size = new System.Drawing.Size(294, 25);
            this.SingUpLabel.TabIndex = 3;
            this.SingUpLabel.Text = "Создайте учётную запись";
            this.SingUpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Additional_Background;
            this.BodyPanel.Controls.Add(this.FooterPanel);
            this.BodyPanel.Controls.Add(this.EmailField);
            this.BodyPanel.Controls.Add(this.AuthLinkLabel);
            this.BodyPanel.Controls.Add(this.CreateButton);
            this.BodyPanel.Controls.Add(this.PhoneLabel);
            this.BodyPanel.Controls.Add(this.EmailLabel);
            this.BodyPanel.Controls.Add(this.PasswordLabel);
            this.BodyPanel.Controls.Add(this.LoginLabel);
            this.BodyPanel.Controls.Add(this.PhoneField);
            this.BodyPanel.Controls.Add(this.PasswordField);
            this.BodyPanel.Controls.Add(this.LoginField);
            this.BodyPanel.Controls.Add(this.CreatePicture);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 70);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(334, 416);
            this.BodyPanel.TabIndex = 0;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.Transparent;
            this.FooterPanel.Controls.Add(this.pictureBox1);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 302);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(334, 114);
            this.FooterPanel.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Course_work.Properties.Resources.Saturn;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(72, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.EmailField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailField.Location = new System.Drawing.Point(117, 182);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(100, 21);
            this.EmailField.TabIndex = 6;
            // 
            // AuthLinkLabel
            // 
            this.AuthLinkLabel.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.AuthLinkLabel.AutoSize = true;
            this.AuthLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthLinkLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AuthLinkLabel.LinkColor = System.Drawing.Color.Coral;
            this.AuthLinkLabel.Location = new System.Drawing.Point(70, 281);
            this.AuthLinkLabel.Name = "AuthLinkLabel";
            this.AuthLinkLabel.Size = new System.Drawing.Size(195, 16);
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
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreateButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.CreateButton.Location = new System.Drawing.Point(117, 252);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.Violet;
            this.PhoneLabel.Location = new System.Drawing.Point(134, 206);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(66, 16);
            this.PhoneLabel.TabIndex = 11;
            this.PhoneLabel.Text = "Телефон";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Violet;
            this.EmailLabel.Location = new System.Drawing.Point(146, 163);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 16);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.PasswordLabel.Location = new System.Drawing.Point(139, 120);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 16);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.LoginLabel.Location = new System.Drawing.Point(144, 77);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 16);
            this.LoginLabel.TabIndex = 8;
            this.LoginLabel.Text = "Логин";
            // 
            // PhoneField
            // 
            this.PhoneField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PhoneField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneField.Location = new System.Drawing.Point(117, 225);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(100, 21);
            this.PhoneField.TabIndex = 7;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PasswordField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordField.Location = new System.Drawing.Point(117, 139);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(100, 21);
            this.PasswordField.TabIndex = 5;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.LoginField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginField.Location = new System.Drawing.Point(117, 96);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(100, 21);
            this.LoginField.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label SingUpLabel;
        private System.Windows.Forms.PictureBox CreatePicture;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.LinkLabel AuthLinkLabel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}