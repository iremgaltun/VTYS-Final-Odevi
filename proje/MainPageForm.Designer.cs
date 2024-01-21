namespace proje
{
    partial class MainPageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.AppBarPanel2 = new System.Windows.Forms.Panel();
            this.ExitButton2 = new System.Windows.Forms.Button();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.EndDateTextBox = new System.Windows.Forms.TextBox();
            this.StartDateTextBox = new System.Windows.Forms.TextBox();
            this.EndDateLabel1 = new System.Windows.Forms.Label();
            this.StartDateLabel1 = new System.Windows.Forms.Label();
            this.ViewIncumbentsButton = new System.Windows.Forms.Button();
            this.UpdateProjectButton1 = new System.Windows.Forms.Button();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.ProjectLabel1 = new System.Windows.Forms.Label();
            this.ProjectComboBox1 = new System.Windows.Forms.ComboBox();
            this.projeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet8 = new proje.dmsDataSet8();
            this.projeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet10 = new proje.dmsDataSet10();
            this.projeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet9 = new proje.dmsDataSet9();
            this.projeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet = new proje.dmsDataSet();
            this.projeTableAdapter = new proje.dmsDataSetTableAdapters.projeTableAdapter();
            this.projeTableAdapter1 = new proje.dmsDataSet8TableAdapters.projeTableAdapter();
            this.projeTableAdapter2 = new proje.dmsDataSet9TableAdapters.projeTableAdapter();
            this.projeTableAdapter3 = new proje.dmsDataSet10TableAdapters.projeTableAdapter();
            this.dmsDataSet13 = new proje.dmsDataSet13();
            this.projeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.projeTableAdapter4 = new proje.dmsDataSet13TableAdapters.projeTableAdapter();
            this.dmsDataSet14 = new proje.dmsDataSet14();
            this.projeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.projeTableAdapter5 = new proje.dmsDataSet14TableAdapters.projeTableAdapter();
            this.dmsDataSet15 = new proje.dmsDataSet15();
            this.projeBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.projeTableAdapter6 = new proje.dmsDataSet15TableAdapters.projeTableAdapter();
            this.AppBarPanel2.SuspendLayout();
            this.ProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // AppBarPanel2
            // 
            this.AppBarPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AppBarPanel2.Controls.Add(this.ExitButton2);
            this.AppBarPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBarPanel2.Location = new System.Drawing.Point(0, 0);
            this.AppBarPanel2.Name = "AppBarPanel2";
            this.AppBarPanel2.Size = new System.Drawing.Size(800, 37);
            this.AppBarPanel2.TabIndex = 1;
            // 
            // ExitButton2
            // 
            this.ExitButton2.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton2.BackgroundImage")));
            this.ExitButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton2.FlatAppearance.BorderSize = 0;
            this.ExitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton2.Location = new System.Drawing.Point(758, 0);
            this.ExitButton2.Name = "ExitButton2";
            this.ExitButton2.Size = new System.Drawing.Size(42, 37);
            this.ExitButton2.TabIndex = 0;
            this.ExitButton2.UseVisualStyleBackColor = false;
            this.ExitButton2.Click += new System.EventHandler(this.ExitButton2_Click);
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProjectPanel.BackgroundImage")));
            this.ProjectPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProjectPanel.Controls.Add(this.EndDateTextBox);
            this.ProjectPanel.Controls.Add(this.StartDateTextBox);
            this.ProjectPanel.Controls.Add(this.EndDateLabel1);
            this.ProjectPanel.Controls.Add(this.StartDateLabel1);
            this.ProjectPanel.Controls.Add(this.ViewIncumbentsButton);
            this.ProjectPanel.Controls.Add(this.UpdateProjectButton1);
            this.ProjectPanel.Controls.Add(this.AddProjectButton);
            this.ProjectPanel.Controls.Add(this.ProjectLabel1);
            this.ProjectPanel.Controls.Add(this.ProjectComboBox1);
            this.ProjectPanel.Location = new System.Drawing.Point(275, 84);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(249, 281);
            this.ProjectPanel.TabIndex = 4;
            // 
            // EndDateTextBox
            // 
            this.EndDateTextBox.Location = new System.Drawing.Point(27, 143);
            this.EndDateTextBox.Name = "EndDateTextBox";
            this.EndDateTextBox.Size = new System.Drawing.Size(187, 20);
            this.EndDateTextBox.TabIndex = 22;
            // 
            // StartDateTextBox
            // 
            this.StartDateTextBox.Location = new System.Drawing.Point(27, 99);
            this.StartDateTextBox.Name = "StartDateTextBox";
            this.StartDateTextBox.Size = new System.Drawing.Size(187, 20);
            this.StartDateTextBox.TabIndex = 21;
            // 
            // EndDateLabel1
            // 
            this.EndDateLabel1.AutoSize = true;
            this.EndDateLabel1.BackColor = System.Drawing.Color.Transparent;
            this.EndDateLabel1.ForeColor = System.Drawing.Color.White;
            this.EndDateLabel1.Location = new System.Drawing.Point(24, 127);
            this.EndDateLabel1.Name = "EndDateLabel1";
            this.EndDateLabel1.Size = new System.Drawing.Size(52, 13);
            this.EndDateLabel1.TabIndex = 20;
            this.EndDateLabel1.Text = "End Date";
            // 
            // StartDateLabel1
            // 
            this.StartDateLabel1.AutoSize = true;
            this.StartDateLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StartDateLabel1.ForeColor = System.Drawing.Color.White;
            this.StartDateLabel1.Location = new System.Drawing.Point(24, 83);
            this.StartDateLabel1.Name = "StartDateLabel1";
            this.StartDateLabel1.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel1.TabIndex = 19;
            this.StartDateLabel1.Text = "Start Date";
            // 
            // ViewIncumbentsButton
            // 
            this.ViewIncumbentsButton.Location = new System.Drawing.Point(117, 238);
            this.ViewIncumbentsButton.Name = "ViewIncumbentsButton";
            this.ViewIncumbentsButton.Size = new System.Drawing.Size(97, 23);
            this.ViewIncumbentsButton.TabIndex = 11;
            this.ViewIncumbentsButton.Text = "View Incumbents";
            this.ViewIncumbentsButton.UseVisualStyleBackColor = true;
            this.ViewIncumbentsButton.Click += new System.EventHandler(this.ViewIncumbentsButton_Click);
            // 
            // UpdateProjectButton1
            // 
            this.UpdateProjectButton1.Location = new System.Drawing.Point(54, 187);
            this.UpdateProjectButton1.Name = "UpdateProjectButton1";
            this.UpdateProjectButton1.Size = new System.Drawing.Size(83, 23);
            this.UpdateProjectButton1.TabIndex = 10;
            this.UpdateProjectButton1.Text = "UpdateProject";
            this.UpdateProjectButton1.UseVisualStyleBackColor = true;
            this.UpdateProjectButton1.Click += new System.EventHandler(this.UpdateProjectButton_Click);
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(144, 187);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(70, 23);
            this.AddProjectButton.TabIndex = 9;
            this.AddProjectButton.Text = "Add Project";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // ProjectLabel1
            // 
            this.ProjectLabel1.AutoSize = true;
            this.ProjectLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ProjectLabel1.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel1.Location = new System.Drawing.Point(24, 29);
            this.ProjectLabel1.Name = "ProjectLabel1";
            this.ProjectLabel1.Size = new System.Drawing.Size(40, 13);
            this.ProjectLabel1.TabIndex = 1;
            this.ProjectLabel1.Text = "Project";
            // 
            // ProjectComboBox1
            // 
            this.ProjectComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectComboBox1.FormattingEnabled = true;
            this.ProjectComboBox1.Location = new System.Drawing.Point(27, 45);
            this.ProjectComboBox1.Name = "ProjectComboBox1";
            this.ProjectComboBox1.Size = new System.Drawing.Size(187, 21);
            this.ProjectComboBox1.TabIndex = 0;
            this.ProjectComboBox1.SelectedIndexChanged += new System.EventHandler(this.ProjectComboBox1_SelectedIndexChanged);
            // 
            // projeBindingSource1
            // 
            this.projeBindingSource1.DataMember = "proje";
            this.projeBindingSource1.DataSource = this.dmsDataSet8;
            // 
            // dmsDataSet8
            // 
            this.dmsDataSet8.DataSetName = "dmsDataSet8";
            this.dmsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource3
            // 
            this.projeBindingSource3.DataMember = "proje";
            this.projeBindingSource3.DataSource = this.dmsDataSet10;
            // 
            // dmsDataSet10
            // 
            this.dmsDataSet10.DataSetName = "dmsDataSet10";
            this.dmsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource2
            // 
            this.projeBindingSource2.DataMember = "proje";
            this.projeBindingSource2.DataSource = this.dmsDataSet9;
            // 
            // dmsDataSet9
            // 
            this.dmsDataSet9.DataSetName = "dmsDataSet9";
            this.dmsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource
            // 
            this.projeBindingSource.DataMember = "proje";
            this.projeBindingSource.DataSource = this.dmsDataSet;
            // 
            // dmsDataSet
            // 
            this.dmsDataSet.DataSetName = "dmsDataSet";
            this.dmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeTableAdapter
            // 
            this.projeTableAdapter.ClearBeforeFill = true;
            // 
            // projeTableAdapter1
            // 
            this.projeTableAdapter1.ClearBeforeFill = true;
            // 
            // projeTableAdapter2
            // 
            this.projeTableAdapter2.ClearBeforeFill = true;
            // 
            // projeTableAdapter3
            // 
            this.projeTableAdapter3.ClearBeforeFill = true;
            // 
            // dmsDataSet13
            // 
            this.dmsDataSet13.DataSetName = "dmsDataSet13";
            this.dmsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource4
            // 
            this.projeBindingSource4.DataMember = "proje";
            this.projeBindingSource4.DataSource = this.dmsDataSet13;
            // 
            // projeTableAdapter4
            // 
            this.projeTableAdapter4.ClearBeforeFill = true;
            // 
            // dmsDataSet14
            // 
            this.dmsDataSet14.DataSetName = "dmsDataSet14";
            this.dmsDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource5
            // 
            this.projeBindingSource5.DataMember = "proje";
            this.projeBindingSource5.DataSource = this.dmsDataSet14;
            // 
            // projeTableAdapter5
            // 
            this.projeTableAdapter5.ClearBeforeFill = true;
            // 
            // dmsDataSet15
            // 
            this.dmsDataSet15.DataSetName = "dmsDataSet15";
            this.dmsDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource6
            // 
            this.projeBindingSource6.DataMember = "proje";
            this.projeBindingSource6.DataSource = this.dmsDataSet15;
            // 
            // projeTableAdapter6
            // 
            this.projeTableAdapter6.ClearBeforeFill = true;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProjectPanel);
            this.Controls.Add(this.AppBarPanel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.AppBarPanel2.ResumeLayout(false);
            this.ProjectPanel.ResumeLayout(false);
            this.ProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AppBarPanel2;
        private System.Windows.Forms.Button ExitButton2;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Label ProjectLabel1;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Button UpdateProjectButton1;
        private System.Windows.Forms.Button ViewIncumbentsButton;
        private dmsDataSet dmsDataSet;
        private System.Windows.Forms.BindingSource projeBindingSource;
        private dmsDataSetTableAdapters.projeTableAdapter projeTableAdapter;
        private System.Windows.Forms.Label EndDateLabel1;
        private System.Windows.Forms.Label StartDateLabel1;
        private System.Windows.Forms.ComboBox ProjectComboBox1;
        private dmsDataSet8 dmsDataSet8;
        private System.Windows.Forms.BindingSource projeBindingSource1;
        private dmsDataSet8TableAdapters.projeTableAdapter projeTableAdapter1;
        private dmsDataSet9 dmsDataSet9;
        private System.Windows.Forms.BindingSource projeBindingSource2;
        private dmsDataSet9TableAdapters.projeTableAdapter projeTableAdapter2;
        private dmsDataSet10 dmsDataSet10;
        private System.Windows.Forms.BindingSource projeBindingSource3;
        private dmsDataSet10TableAdapters.projeTableAdapter projeTableAdapter3;
        private System.Windows.Forms.TextBox EndDateTextBox;
        private System.Windows.Forms.TextBox StartDateTextBox;
        private dmsDataSet13 dmsDataSet13;
        private System.Windows.Forms.BindingSource projeBindingSource4;
        private dmsDataSet13TableAdapters.projeTableAdapter projeTableAdapter4;
        private dmsDataSet14 dmsDataSet14;
        private System.Windows.Forms.BindingSource projeBindingSource5;
        private dmsDataSet14TableAdapters.projeTableAdapter projeTableAdapter5;
        private dmsDataSet15 dmsDataSet15;
        private System.Windows.Forms.BindingSource projeBindingSource6;
        private dmsDataSet15TableAdapters.projeTableAdapter projeTableAdapter6;
    }
}