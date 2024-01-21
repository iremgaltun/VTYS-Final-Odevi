namespace proje
{
    partial class NewAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccountForm));
            this.AppBarPanel5 = new System.Windows.Forms.Panel();
            this.ExitButton5 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox2 = new System.Windows.Forms.TextBox();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.EmailLabel2 = new System.Windows.Forms.Label();
            this.PasswordLabel2 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.AppBarPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppBarPanel5
            // 
            this.AppBarPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AppBarPanel5.Controls.Add(this.ExitButton5);
            this.AppBarPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBarPanel5.Location = new System.Drawing.Point(0, 0);
            this.AppBarPanel5.Name = "AppBarPanel5";
            this.AppBarPanel5.Size = new System.Drawing.Size(249, 27);
            this.AppBarPanel5.TabIndex = 0;
            // 
            // ExitButton5
            // 
            this.ExitButton5.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton5.BackgroundImage")));
            this.ExitButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton5.FlatAppearance.BorderSize = 0;
            this.ExitButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton5.Location = new System.Drawing.Point(214, 0);
            this.ExitButton5.Name = "ExitButton5";
            this.ExitButton5.Size = new System.Drawing.Size(35, 27);
            this.ExitButton5.TabIndex = 1;
            this.ExitButton5.UseVisualStyleBackColor = false;
            this.ExitButton5.Click += new System.EventHandler(this.ExitButton5_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(48, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(143, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(48, 106);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(143, 20);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // EmailTextBox2
            // 
            this.EmailTextBox2.Location = new System.Drawing.Point(48, 151);
            this.EmailTextBox2.Name = "EmailTextBox2";
            this.EmailTextBox2.Size = new System.Drawing.Size(143, 20);
            this.EmailTextBox2.TabIndex = 3;
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.Location = new System.Drawing.Point(48, 196);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.Size = new System.Drawing.Size(143, 20);
            this.PasswordTextBox2.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(45, 45);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SurnameLabel.ForeColor = System.Drawing.Color.White;
            this.SurnameLabel.Location = new System.Drawing.Point(45, 90);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Surname";
            // 
            // EmailLabel2
            // 
            this.EmailLabel2.AutoSize = true;
            this.EmailLabel2.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel2.ForeColor = System.Drawing.Color.White;
            this.EmailLabel2.Location = new System.Drawing.Point(45, 137);
            this.EmailLabel2.Name = "EmailLabel2";
            this.EmailLabel2.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel2.TabIndex = 7;
            this.EmailLabel2.Text = "Email";
            // 
            // PasswordLabel2
            // 
            this.PasswordLabel2.AutoSize = true;
            this.PasswordLabel2.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel2.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel2.Location = new System.Drawing.Point(45, 180);
            this.PasswordLabel2.Name = "PasswordLabel2";
            this.PasswordLabel2.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel2.TabIndex = 8;
            this.PasswordLabel2.Text = "Password";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(90, 233);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(59, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(249, 281);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordLabel2);
            this.Controls.Add(this.EmailLabel2);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.EmailTextBox2);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AppBarPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAccountForm";
            this.Load += new System.EventHandler(this.NewAccountForm_Load);
            this.AppBarPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AppBarPanel5;
        private System.Windows.Forms.Button ExitButton5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox2;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label EmailLabel2;
        private System.Windows.Forms.Label PasswordLabel2;
        private System.Windows.Forms.Button RegisterButton;
    }
}