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
            this.AccessLevelLabel = new System.Windows.Forms.Label();
            this.AccessLevelField = new System.Windows.Forms.TextBox();
            this.AreaOfWorkLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.WorkPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyPanel.BackgroundImage")));
            this.BodyPanel.Controls.Add(this.AccessLevelLabel);
            this.BodyPanel.Controls.Add(this.AccessLevelField);
            this.BodyPanel.Controls.Add(this.AreaOfWorkLabel);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.WorkPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.PhoneLabel);
            this.BodyPanel.Controls.Add(this.DeadlineLabel);
            this.BodyPanel.Controls.Add(this.PhoneField);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.PasswordLabel);
            this.BodyPanel.Controls.Add(this.LoginLabel);
            this.BodyPanel.Controls.Add(this.EmailField);
            this.BodyPanel.Controls.Add(this.PasswordField);
            this.BodyPanel.Controls.Add(this.LoginField);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 450);
            this.BodyPanel.TabIndex = 5;
            // 
            // AccessLevelLabel
            // 
            this.AccessLevelLabel.AutoSize = true;
            this.AccessLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccessLevelLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessLevelLabel.ForeColor = System.Drawing.Color.Violet;
            this.AccessLevelLabel.Location = new System.Drawing.Point(125, 270);
            this.AccessLevelLabel.Name = "AccessLevelLabel";
            this.AccessLevelLabel.Size = new System.Drawing.Size(122, 16);
            this.AccessLevelLabel.TabIndex = 25;
            this.AccessLevelLabel.Text = "Уровень доступа";
            // 
            // AccessLevelField
            // 
            this.AccessLevelField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AccessLevelField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AccessLevelField.Location = new System.Drawing.Point(260, 269);
            this.AccessLevelField.Name = "AccessLevelField";
            this.AccessLevelField.Size = new System.Drawing.Size(187, 21);
            this.AccessLevelField.TabIndex = 24;
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
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.CancelButton.Location = new System.Drawing.Point(260, 359);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(95, 450);
            this.LeftPanel.TabIndex = 20;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.Violet;
            this.PhoneLabel.Location = new System.Drawing.Point(181, 216);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(66, 16);
            this.PhoneLabel.TabIndex = 16;
            this.PhoneLabel.Text = "Телефон";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeadlineLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeadlineLabel.ForeColor = System.Drawing.Color.Violet;
            this.DeadlineLabel.Location = new System.Drawing.Point(208, 162);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(39, 16);
            this.DeadlineLabel.TabIndex = 15;
            this.DeadlineLabel.Text = "Email";
            // 
            // PhoneField
            // 
            this.PhoneField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PhoneField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneField.Location = new System.Drawing.Point(260, 215);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(187, 21);
            this.PhoneField.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddButton.Location = new System.Drawing.Point(260, 319);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(187, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.PasswordLabel.Location = new System.Drawing.Point(190, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 16);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.LoginLabel.Location = new System.Drawing.Point(115, 56);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(132, 16);
            this.LoginLabel.TabIndex = 8;
            this.LoginLabel.Text = "Имя пользователя";
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.EmailField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailField.Location = new System.Drawing.Point(260, 161);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(187, 21);
            this.EmailField.TabIndex = 7;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PasswordField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordField.Location = new System.Drawing.Point(260, 108);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(187, 21);
            this.PasswordField.TabIndex = 5;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.LoginField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginField.Location = new System.Drawing.Point(260, 55);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(187, 21);
            this.LoginField.TabIndex = 4;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
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
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox WorkPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label AccessLevelLabel;
        private System.Windows.Forms.TextBox AccessLevelField;
    }
}