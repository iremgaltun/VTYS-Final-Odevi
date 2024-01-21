namespace proje
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.AppBarPanel1 = new System.Windows.Forms.Panel();
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.UsersPictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordLabel1 = new System.Windows.Forms.Label();
            this.EmailLabel1 = new System.Windows.Forms.Label();
            this.NexAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.EmailTextBox1 = new System.Windows.Forms.TextBox();
            this.AppBarPanel1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AppBarPanel1
            // 
            this.AppBarPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AppBarPanel1.Controls.Add(this.ExitButton1);
            this.AppBarPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBarPanel1.Location = new System.Drawing.Point(0, 0);
            this.AppBarPanel1.Name = "AppBarPanel1";
            this.AppBarPanel1.Size = new System.Drawing.Size(800, 37);
            this.AppBarPanel1.TabIndex = 0;
            // 
            // ExitButton1
            // 
            this.ExitButton1.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton1.BackgroundImage")));
            this.ExitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton1.FlatAppearance.BorderSize = 0;
            this.ExitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton1.Location = new System.Drawing.Point(758, 0);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(42, 37);
            this.ExitButton1.TabIndex = 0;
            this.ExitButton1.UseVisualStyleBackColor = false;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel.BackgroundImage")));
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginPanel.Controls.Add(this.PasswordPictureBox);
            this.LoginPanel.Controls.Add(this.UsersPictureBox);
            this.LoginPanel.Controls.Add(this.PasswordLabel1);
            this.LoginPanel.Controls.Add(this.EmailLabel1);
            this.LoginPanel.Controls.Add(this.NexAccountLinkLabel);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordTextBox1);
            this.LoginPanel.Controls.Add(this.EmailTextBox1);
            this.LoginPanel.Location = new System.Drawing.Point(275, 84);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(249, 281);
            this.LoginPanel.TabIndex = 1;
            // 
            // PasswordPictureBox
            // 
            this.PasswordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordPictureBox.BackgroundImage")));
            this.PasswordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasswordPictureBox.Location = new System.Drawing.Point(14, 158);
            this.PasswordPictureBox.Name = "PasswordPictureBox";
            this.PasswordPictureBox.Size = new System.Drawing.Size(28, 22);
            this.PasswordPictureBox.TabIndex = 7;
            this.PasswordPictureBox.TabStop = false;
            // 
            // UsersPictureBox
            // 
            this.UsersPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UsersPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsersPictureBox.BackgroundImage")));
            this.UsersPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UsersPictureBox.Location = new System.Drawing.Point(14, 102);
            this.UsersPictureBox.Name = "UsersPictureBox";
            this.UsersPictureBox.Size = new System.Drawing.Size(28, 22);
            this.UsersPictureBox.TabIndex = 6;
            this.UsersPictureBox.TabStop = false;
            // 
            // PasswordLabel1
            // 
            this.PasswordLabel1.AutoSize = true;
            this.PasswordLabel1.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel1.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel1.Location = new System.Drawing.Point(51, 142);
            this.PasswordLabel1.Name = "PasswordLabel1";
            this.PasswordLabel1.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel1.TabIndex = 5;
            this.PasswordLabel1.Text = "Password";
            // 
            // EmailLabel1
            // 
            this.EmailLabel1.AutoSize = true;
            this.EmailLabel1.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel1.ForeColor = System.Drawing.Color.White;
            this.EmailLabel1.Location = new System.Drawing.Point(45, 86);
            this.EmailLabel1.Name = "EmailLabel1";
            this.EmailLabel1.Size = new System.Drawing.Size(34, 13);
            this.EmailLabel1.TabIndex = 4;
            this.EmailLabel1.Text = "Email";
            // 
            // NexAccountLinkLabel
            // 
            this.NexAccountLinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.NexAccountLinkLabel.AutoSize = true;
            this.NexAccountLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.NexAccountLinkLabel.LinkColor = System.Drawing.Color.Gray;
            this.NexAccountLinkLabel.Location = new System.Drawing.Point(68, 244);
            this.NexAccountLinkLabel.Name = "NexAccountLinkLabel";
            this.NexAccountLinkLabel.Size = new System.Drawing.Size(111, 13);
            this.NexAccountLinkLabel.TabIndex = 3;
            this.NexAccountLinkLabel.TabStop = true;
            this.NexAccountLinkLabel.Text = "Create New Account";
            this.NexAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NexAccountLinkLabel_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(86, 208);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.Location = new System.Drawing.Point(48, 158);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.Size = new System.Drawing.Size(160, 22);
            this.PasswordTextBox1.TabIndex = 1;
            // 
            // EmailTextBox1
            // 
            this.EmailTextBox1.Location = new System.Drawing.Point(48, 102);
            this.EmailTextBox1.Name = "EmailTextBox1";
            this.EmailTextBox1.Size = new System.Drawing.Size(160, 22);
            this.EmailTextBox1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ExitButton1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.AppBarPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.AppBarPanel1.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AppBarPanel1;
        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox PasswordTextBox1;
        private System.Windows.Forms.TextBox EmailTextBox1;
        private System.Windows.Forms.Label PasswordLabel1;
        private System.Windows.Forms.Label EmailLabel1;
        private System.Windows.Forms.LinkLabel NexAccountLinkLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox UsersPictureBox;
        private System.Windows.Forms.PictureBox PasswordPictureBox;
    }
}