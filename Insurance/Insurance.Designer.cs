namespace Course_work
{
    partial class Insurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insurance));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.InsurancePicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TermOfInsuranceLabel = new System.Windows.Forms.Label();
            this.InsuranceCompanyLabel = new System.Windows.Forms.Label();
            this.DateOfInsuranceLabel = new System.Windows.Forms.Label();
            this.InsuranceTypeLabel = new System.Windows.Forms.Label();
            this.TermOfInsuranceField = new System.Windows.Forms.TextBox();
            this.DateOfInsuranceField = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.InsurancePolicyLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.InsuranceTypeField = new System.Windows.Forms.TextBox();
            this.InsuranceCompanyField = new System.Windows.Forms.TextBox();
            this.InsurancePolicyField = new System.Windows.Forms.TextBox();
            this.FIOField = new System.Windows.Forms.TextBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsurancePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyPanel.BackgroundImage")));
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.InsurancePicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.TermOfInsuranceLabel);
            this.BodyPanel.Controls.Add(this.InsuranceCompanyLabel);
            this.BodyPanel.Controls.Add(this.DateOfInsuranceLabel);
            this.BodyPanel.Controls.Add(this.InsuranceTypeLabel);
            this.BodyPanel.Controls.Add(this.TermOfInsuranceField);
            this.BodyPanel.Controls.Add(this.DateOfInsuranceField);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.InsurancePolicyLabel);
            this.BodyPanel.Controls.Add(this.FIOLabel);
            this.BodyPanel.Controls.Add(this.InsuranceTypeField);
            this.BodyPanel.Controls.Add(this.InsuranceCompanyField);
            this.BodyPanel.Controls.Add(this.InsurancePolicyField);
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
            this.CancelButton.Location = new System.Drawing.Point(256, 391);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InsurancePicture
            // 
            this.InsurancePicture.BackColor = System.Drawing.Color.Transparent;
            this.InsurancePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsurancePicture.ErrorImage = null;
            this.InsurancePicture.Image = global::Course_work.Properties.Resources.Insurance;
            this.InsurancePicture.InitialImage = null;
            this.InsurancePicture.Location = new System.Drawing.Point(505, 55);
            this.InsurancePicture.Name = "InsurancePicture";
            this.InsurancePicture.Size = new System.Drawing.Size(256, 256);
            this.InsurancePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsurancePicture.TabIndex = 3;
            this.InsurancePicture.TabStop = false;
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
            // TermOfInsuranceLabel
            // 
            this.TermOfInsuranceLabel.AutoSize = true;
            this.TermOfInsuranceLabel.BackColor = System.Drawing.Color.Transparent;
            this.TermOfInsuranceLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermOfInsuranceLabel.ForeColor = System.Drawing.Color.Violet;
            this.TermOfInsuranceLabel.Location = new System.Drawing.Point(112, 290);
            this.TermOfInsuranceLabel.Name = "TermOfInsuranceLabel";
            this.TermOfInsuranceLabel.Size = new System.Drawing.Size(127, 16);
            this.TermOfInsuranceLabel.TabIndex = 19;
            this.TermOfInsuranceLabel.Text = "Срок страхования";
            // 
            // InsuranceCompanyLabel
            // 
            this.InsuranceCompanyLabel.AutoSize = true;
            this.InsuranceCompanyLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsuranceCompanyLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsuranceCompanyLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.InsuranceCompanyLabel.Location = new System.Drawing.Point(93, 139);
            this.InsuranceCompanyLabel.Name = "InsuranceCompanyLabel";
            this.InsuranceCompanyLabel.Size = new System.Drawing.Size(146, 16);
            this.InsuranceCompanyLabel.TabIndex = 18;
            this.InsuranceCompanyLabel.Text = "Страховая компания";
            // 
            // DateOfInsuranceLabel
            // 
            this.DateOfInsuranceLabel.AutoSize = true;
            this.DateOfInsuranceLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateOfInsuranceLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfInsuranceLabel.ForeColor = System.Drawing.Color.Violet;
            this.DateOfInsuranceLabel.Location = new System.Drawing.Point(111, 239);
            this.DateOfInsuranceLabel.Name = "DateOfInsuranceLabel";
            this.DateOfInsuranceLabel.Size = new System.Drawing.Size(128, 16);
            this.DateOfInsuranceLabel.TabIndex = 16;
            this.DateOfInsuranceLabel.Text = "Дата страхования";
            // 
            // InsuranceTypeLabel
            // 
            this.InsuranceTypeLabel.AutoSize = true;
            this.InsuranceTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsuranceTypeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsuranceTypeLabel.ForeColor = System.Drawing.Color.Violet;
            this.InsuranceTypeLabel.Location = new System.Drawing.Point(120, 189);
            this.InsuranceTypeLabel.Name = "InsuranceTypeLabel";
            this.InsuranceTypeLabel.Size = new System.Drawing.Size(119, 16);
            this.InsuranceTypeLabel.TabIndex = 15;
            this.InsuranceTypeLabel.Text = "Вид страхования";
            // 
            // TermOfInsuranceField
            // 
            this.TermOfInsuranceField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TermOfInsuranceField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TermOfInsuranceField.Location = new System.Drawing.Point(256, 290);
            this.TermOfInsuranceField.Name = "TermOfInsuranceField";
            this.TermOfInsuranceField.Size = new System.Drawing.Size(187, 21);
            this.TermOfInsuranceField.TabIndex = 14;
            // 
            // DateOfInsuranceField
            // 
            this.DateOfInsuranceField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DateOfInsuranceField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DateOfInsuranceField.Location = new System.Drawing.Point(256, 238);
            this.DateOfInsuranceField.Name = "DateOfInsuranceField";
            this.DateOfInsuranceField.Size = new System.Drawing.Size(187, 21);
            this.DateOfInsuranceField.TabIndex = 13;
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
            this.AddButton.Location = new System.Drawing.Point(256, 346);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(187, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InsurancePolicyLabel
            // 
            this.InsurancePolicyLabel.AutoSize = true;
            this.InsurancePolicyLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsurancePolicyLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsurancePolicyLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.InsurancePolicyLabel.Location = new System.Drawing.Point(120, 88);
            this.InsurancePolicyLabel.Name = "InsurancePolicyLabel";
            this.InsurancePolicyLabel.Size = new System.Drawing.Size(119, 16);
            this.InsurancePolicyLabel.TabIndex = 10;
            this.InsurancePolicyLabel.Text = "Страховой полис";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.BackColor = System.Drawing.Color.Transparent;
            this.FIOLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.FIOLabel.Location = new System.Drawing.Point(198, 39);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(35, 16);
            this.FIOLabel.TabIndex = 8;
            this.FIOLabel.Text = "ФИО";
            // 
            // InsuranceTypeField
            // 
            this.InsuranceTypeField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.InsuranceTypeField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InsuranceTypeField.Location = new System.Drawing.Point(256, 188);
            this.InsuranceTypeField.Name = "InsuranceTypeField";
            this.InsuranceTypeField.Size = new System.Drawing.Size(187, 21);
            this.InsuranceTypeField.TabIndex = 7;
            // 
            // InsuranceCompanyField
            // 
            this.InsuranceCompanyField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.InsuranceCompanyField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InsuranceCompanyField.Location = new System.Drawing.Point(256, 138);
            this.InsuranceCompanyField.Name = "InsuranceCompanyField";
            this.InsuranceCompanyField.Size = new System.Drawing.Size(187, 21);
            this.InsuranceCompanyField.TabIndex = 6;
            // 
            // InsurancePolicyField
            // 
            this.InsurancePolicyField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.InsurancePolicyField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InsurancePolicyField.Location = new System.Drawing.Point(256, 87);
            this.InsurancePolicyField.Name = "InsurancePolicyField";
            this.InsurancePolicyField.Size = new System.Drawing.Size(187, 21);
            this.InsurancePolicyField.TabIndex = 5;
            // 
            // FIOField
            // 
            this.FIOField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FIOField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FIOField.Location = new System.Drawing.Point(256, 34);
            this.FIOField.Name = "FIOField";
            this.FIOField.Size = new System.Drawing.Size(187, 21);
            this.FIOField.TabIndex = 4;
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyPanel);
            this.Name = "Insurance";
            this.Text = "Insurance";
            this.Load += new System.EventHandler(this.Insurance_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsurancePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox InsurancePicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label TermOfInsuranceLabel;
        private System.Windows.Forms.Label InsuranceCompanyLabel;
        private System.Windows.Forms.Label DateOfInsuranceLabel;
        private System.Windows.Forms.Label InsuranceTypeLabel;
        private System.Windows.Forms.TextBox TermOfInsuranceField;
        private System.Windows.Forms.TextBox DateOfInsuranceField;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label InsurancePolicyLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.TextBox InsuranceTypeField;
        private System.Windows.Forms.TextBox InsuranceCompanyField;
        private System.Windows.Forms.TextBox InsurancePolicyField;
        private System.Windows.Forms.TextBox FIOField;
    }
}