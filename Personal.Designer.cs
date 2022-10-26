namespace Course_work
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PersonalPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ChangeOfJobLabel = new System.Windows.Forms.Label();
            this.NumberPhoneLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.ChangeOfJobField = new System.Windows.Forms.TextBox();
            this.SalaryField = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.PositionField = new System.Windows.Forms.TextBox();
            this.NumberPhoneField = new System.Windows.Forms.TextBox();
            this.DateOfBirthField = new System.Windows.Forms.TextBox();
            this.FIOField = new System.Windows.Forms.TextBox();
            this.PersonalLabel = new System.Windows.Forms.Label();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyPanel.BackgroundImage")));
            this.BodyPanel.Controls.Add(this.PersonalLabel);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.PersonalPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.ChangeOfJobLabel);
            this.BodyPanel.Controls.Add(this.NumberPhoneLabel);
            this.BodyPanel.Controls.Add(this.SalaryLabel);
            this.BodyPanel.Controls.Add(this.PositionLabel);
            this.BodyPanel.Controls.Add(this.ChangeOfJobField);
            this.BodyPanel.Controls.Add(this.SalaryField);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.DateOfBirthLabel);
            this.BodyPanel.Controls.Add(this.FIOLabel);
            this.BodyPanel.Controls.Add(this.PositionField);
            this.BodyPanel.Controls.Add(this.NumberPhoneField);
            this.BodyPanel.Controls.Add(this.DateOfBirthField);
            this.BodyPanel.Controls.Add(this.FIOField);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 450);
            this.BodyPanel.TabIndex = 5;
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
            this.CancelButton.Location = new System.Drawing.Point(261, 412);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PersonalPicture
            // 
            this.PersonalPicture.BackColor = System.Drawing.Color.Transparent;
            this.PersonalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PersonalPicture.ErrorImage = null;
            this.PersonalPicture.Image = global::Course_work.Properties.Resources.Personal;
            this.PersonalPicture.InitialImage = null;
            this.PersonalPicture.Location = new System.Drawing.Point(505, 55);
            this.PersonalPicture.Name = "PersonalPicture";
            this.PersonalPicture.Size = new System.Drawing.Size(256, 256);
            this.PersonalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonalPicture.TabIndex = 3;
            this.PersonalPicture.TabStop = false;
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
            // ChangeOfJobLabel
            // 
            this.ChangeOfJobLabel.AutoSize = true;
            this.ChangeOfJobLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChangeOfJobLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeOfJobLabel.ForeColor = System.Drawing.Color.Violet;
            this.ChangeOfJobLabel.Location = new System.Drawing.Point(189, 312);
            this.ChangeOfJobLabel.Name = "ChangeOfJobLabel";
            this.ChangeOfJobLabel.Size = new System.Drawing.Size(49, 16);
            this.ChangeOfJobLabel.TabIndex = 19;
            this.ChangeOfJobLabel.Text = "Смена";
            // 
            // NumberPhoneLabel
            // 
            this.NumberPhoneLabel.AutoSize = true;
            this.NumberPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberPhoneLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPhoneLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.NumberPhoneLabel.Location = new System.Drawing.Point(172, 164);
            this.NumberPhoneLabel.Name = "NumberPhoneLabel";
            this.NumberPhoneLabel.Size = new System.Drawing.Size(66, 16);
            this.NumberPhoneLabel.TabIndex = 18;
            this.NumberPhoneLabel.Text = "Телефон";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.SalaryLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryLabel.ForeColor = System.Drawing.Color.Violet;
            this.SalaryLabel.Location = new System.Drawing.Point(108, 264);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(130, 16);
            this.SalaryLabel.TabIndex = 16;
            this.SalaryLabel.Text = "Заработная плата";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PositionLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.ForeColor = System.Drawing.Color.Violet;
            this.PositionLabel.Location = new System.Drawing.Point(154, 210);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(84, 16);
            this.PositionLabel.TabIndex = 15;
            this.PositionLabel.Text = "Должность";
            // 
            // ChangeOfJobField
            // 
            this.ChangeOfJobField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChangeOfJobField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ChangeOfJobField.Location = new System.Drawing.Point(261, 311);
            this.ChangeOfJobField.Name = "ChangeOfJobField";
            this.ChangeOfJobField.Size = new System.Drawing.Size(187, 21);
            this.ChangeOfJobField.TabIndex = 14;
            // 
            // SalaryField
            // 
            this.SalaryField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SalaryField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SalaryField.Location = new System.Drawing.Point(261, 259);
            this.SalaryField.Name = "SalaryField";
            this.SalaryField.Size = new System.Drawing.Size(187, 21);
            this.SalaryField.TabIndex = 13;
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
            this.AddButton.Location = new System.Drawing.Point(261, 367);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(187, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(125, 109);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(113, 16);
            this.DateOfBirthLabel.TabIndex = 10;
            this.DateOfBirthLabel.Text = "Дата рождения";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.BackColor = System.Drawing.Color.Transparent;
            this.FIOLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.FIOLabel.Location = new System.Drawing.Point(203, 60);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(35, 16);
            this.FIOLabel.TabIndex = 8;
            this.FIOLabel.Text = "ФИО";
            // 
            // PositionField
            // 
            this.PositionField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PositionField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PositionField.Location = new System.Drawing.Point(261, 209);
            this.PositionField.Name = "PositionField";
            this.PositionField.Size = new System.Drawing.Size(187, 21);
            this.PositionField.TabIndex = 7;
            // 
            // NumberPhoneField
            // 
            this.NumberPhoneField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NumberPhoneField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NumberPhoneField.Location = new System.Drawing.Point(261, 159);
            this.NumberPhoneField.Name = "NumberPhoneField";
            this.NumberPhoneField.Size = new System.Drawing.Size(187, 21);
            this.NumberPhoneField.TabIndex = 6;
            // 
            // DateOfBirthField
            // 
            this.DateOfBirthField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DateOfBirthField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DateOfBirthField.Location = new System.Drawing.Point(261, 108);
            this.DateOfBirthField.Name = "DateOfBirthField";
            this.DateOfBirthField.Size = new System.Drawing.Size(187, 21);
            this.DateOfBirthField.TabIndex = 5;
            // 
            // FIOField
            // 
            this.FIOField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FIOField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FIOField.Location = new System.Drawing.Point(261, 55);
            this.FIOField.Name = "FIOField";
            this.FIOField.Size = new System.Drawing.Size(187, 21);
            this.FIOField.TabIndex = 4;
            // 
            // PersonalLabel
            // 
            this.PersonalLabel.AutoSize = true;
            this.PersonalLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonalLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalLabel.ForeColor = System.Drawing.Color.White;
            this.PersonalLabel.Location = new System.Drawing.Point(105, 22);
            this.PersonalLabel.Name = "PersonalLabel";
            this.PersonalLabel.Size = new System.Drawing.Size(529, 19);
            this.PersonalLabel.TabIndex = 23;
            this.PersonalLabel.Text = "Для внесения данных в таблицу заполните следующие поля:";
            this.PersonalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox PersonalPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label ChangeOfJobLabel;
        private System.Windows.Forms.Label NumberPhoneLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox ChangeOfJobField;
        private System.Windows.Forms.TextBox SalaryField;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.TextBox PositionField;
        private System.Windows.Forms.TextBox NumberPhoneField;
        private System.Windows.Forms.TextBox DateOfBirthField;
        private System.Windows.Forms.TextBox FIOField;
        private System.Windows.Forms.Label PersonalLabel;
    }
}