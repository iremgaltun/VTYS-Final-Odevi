namespace proje
{
    partial class UpdateProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProjectForm));
            this.AppBarPanel4 = new System.Windows.Forms.Panel();
            this.ExitButton4 = new System.Windows.Forms.Button();
            this.UpdateProjectPanel = new System.Windows.Forms.Panel();
            this.EndDateTextBox = new System.Windows.Forms.TextBox();
            this.StartDateTextBox = new System.Windows.Forms.TextBox();
            this.EndDateLabel1 = new System.Windows.Forms.Label();
            this.StartDateLabel1 = new System.Windows.Forms.Label();
            this.IncumbentComboBox2 = new System.Windows.Forms.ComboBox();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet5 = new proje.dmsDataSet5();
            this.UpdateProjectButton2 = new System.Windows.Forms.Button();
            this.IncumbentLabel2 = new System.Windows.Forms.Label();
            this.NewTaskLabel = new System.Windows.Forms.Label();
            this.NewTaskTextBox = new System.Windows.Forms.TextBox();
            this.ProjectLabel2 = new System.Windows.Forms.Label();
            this.ProjectComboBox2 = new System.Windows.Forms.ComboBox();
            this.dmsDataSet4 = new proje.dmsDataSet4();
            this.gorevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevTableAdapter = new proje.dmsDataSet4TableAdapters.gorevTableAdapter();
            this.kullaniciTableAdapter = new proje.dmsDataSet5TableAdapters.kullaniciTableAdapter();
            this.AppBarPanel4.SuspendLayout();
            this.UpdateProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AppBarPanel4
            // 
            this.AppBarPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AppBarPanel4.Controls.Add(this.ExitButton4);
            this.AppBarPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBarPanel4.Location = new System.Drawing.Point(0, 0);
            this.AppBarPanel4.Name = "AppBarPanel4";
            this.AppBarPanel4.Size = new System.Drawing.Size(800, 37);
            this.AppBarPanel4.TabIndex = 2;
            // 
            // ExitButton4
            // 
            this.ExitButton4.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton4.BackgroundImage")));
            this.ExitButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton4.FlatAppearance.BorderSize = 0;
            this.ExitButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton4.Location = new System.Drawing.Point(758, 0);
            this.ExitButton4.Name = "ExitButton4";
            this.ExitButton4.Size = new System.Drawing.Size(42, 37);
            this.ExitButton4.TabIndex = 0;
            this.ExitButton4.UseVisualStyleBackColor = false;
            this.ExitButton4.Click += new System.EventHandler(this.ExitButton4_Click);
            // 
            // UpdateProjectPanel
            // 
            this.UpdateProjectPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateProjectPanel.BackgroundImage")));
            this.UpdateProjectPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpdateProjectPanel.Controls.Add(this.EndDateTextBox);
            this.UpdateProjectPanel.Controls.Add(this.StartDateTextBox);
            this.UpdateProjectPanel.Controls.Add(this.EndDateLabel1);
            this.UpdateProjectPanel.Controls.Add(this.StartDateLabel1);
            this.UpdateProjectPanel.Controls.Add(this.IncumbentComboBox2);
            this.UpdateProjectPanel.Controls.Add(this.UpdateProjectButton2);
            this.UpdateProjectPanel.Controls.Add(this.IncumbentLabel2);
            this.UpdateProjectPanel.Controls.Add(this.NewTaskLabel);
            this.UpdateProjectPanel.Controls.Add(this.NewTaskTextBox);
            this.UpdateProjectPanel.Controls.Add(this.ProjectLabel2);
            this.UpdateProjectPanel.Controls.Add(this.ProjectComboBox2);
            this.UpdateProjectPanel.Location = new System.Drawing.Point(275, 81);
            this.UpdateProjectPanel.Name = "UpdateProjectPanel";
            this.UpdateProjectPanel.Size = new System.Drawing.Size(249, 308);
            this.UpdateProjectPanel.TabIndex = 5;
            // 
            // EndDateTextBox
            // 
            this.EndDateTextBox.Location = new System.Drawing.Point(27, 198);
            this.EndDateTextBox.Name = "EndDateTextBox";
            this.EndDateTextBox.Size = new System.Drawing.Size(187, 20);
            this.EndDateTextBox.TabIndex = 22;
            // 
            // StartDateTextBox
            // 
            this.StartDateTextBox.Location = new System.Drawing.Point(27, 150);
            this.StartDateTextBox.Name = "StartDateTextBox";
            this.StartDateTextBox.Size = new System.Drawing.Size(187, 20);
            this.StartDateTextBox.TabIndex = 21;
            // 
            // EndDateLabel1
            // 
            this.EndDateLabel1.AutoSize = true;
            this.EndDateLabel1.BackColor = System.Drawing.Color.Transparent;
            this.EndDateLabel1.ForeColor = System.Drawing.Color.White;
            this.EndDateLabel1.Location = new System.Drawing.Point(24, 182);
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
            this.StartDateLabel1.Location = new System.Drawing.Point(24, 134);
            this.StartDateLabel1.Name = "StartDateLabel1";
            this.StartDateLabel1.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel1.TabIndex = 19;
            this.StartDateLabel1.Text = "Start Date";
            // 
            // IncumbentComboBox2
            // 
            this.IncumbentComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IncumbentComboBox2.FormattingEnabled = true;
            this.IncumbentComboBox2.Location = new System.Drawing.Point(131, 105);
            this.IncumbentComboBox2.Name = "IncumbentComboBox2";
            this.IncumbentComboBox2.Size = new System.Drawing.Size(83, 21);
            this.IncumbentComboBox2.TabIndex = 11;
            this.IncumbentComboBox2.SelectedIndexChanged += new System.EventHandler(this.IncumbentComboBox2_SelectedIndexChanged);
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "kullanici";
            this.kullaniciBindingSource.DataSource = this.dmsDataSet5;
            // 
            // dmsDataSet5
            // 
            this.dmsDataSet5.DataSetName = "dmsDataSet5";
            this.dmsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UpdateProjectButton2
            // 
            this.UpdateProjectButton2.Location = new System.Drawing.Point(131, 268);
            this.UpdateProjectButton2.Name = "UpdateProjectButton2";
            this.UpdateProjectButton2.Size = new System.Drawing.Size(83, 23);
            this.UpdateProjectButton2.TabIndex = 10;
            this.UpdateProjectButton2.Text = "UpdateProject";
            this.UpdateProjectButton2.UseVisualStyleBackColor = true;
            this.UpdateProjectButton2.Click += new System.EventHandler(this.UpdateProjectButton2_Click);
            // 
            // IncumbentLabel2
            // 
            this.IncumbentLabel2.AutoSize = true;
            this.IncumbentLabel2.BackColor = System.Drawing.Color.Transparent;
            this.IncumbentLabel2.ForeColor = System.Drawing.Color.White;
            this.IncumbentLabel2.Location = new System.Drawing.Point(128, 89);
            this.IncumbentLabel2.Name = "IncumbentLabel2";
            this.IncumbentLabel2.Size = new System.Drawing.Size(57, 13);
            this.IncumbentLabel2.TabIndex = 6;
            this.IncumbentLabel2.Text = "Incumbent";
            // 
            // NewTaskLabel
            // 
            this.NewTaskLabel.AutoSize = true;
            this.NewTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewTaskLabel.ForeColor = System.Drawing.Color.White;
            this.NewTaskLabel.Location = new System.Drawing.Point(24, 89);
            this.NewTaskLabel.Name = "NewTaskLabel";
            this.NewTaskLabel.Size = new System.Drawing.Size(56, 13);
            this.NewTaskLabel.TabIndex = 5;
            this.NewTaskLabel.Text = "New Task";
            // 
            // NewTaskTextBox
            // 
            this.NewTaskTextBox.Location = new System.Drawing.Point(27, 105);
            this.NewTaskTextBox.Name = "NewTaskTextBox";
            this.NewTaskTextBox.Size = new System.Drawing.Size(83, 20);
            this.NewTaskTextBox.TabIndex = 2;
            // 
            // ProjectLabel2
            // 
            this.ProjectLabel2.AutoSize = true;
            this.ProjectLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ProjectLabel2.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel2.Location = new System.Drawing.Point(24, 27);
            this.ProjectLabel2.Name = "ProjectLabel2";
            this.ProjectLabel2.Size = new System.Drawing.Size(40, 13);
            this.ProjectLabel2.TabIndex = 1;
            this.ProjectLabel2.Text = "Project";
            // 
            // ProjectComboBox2
            // 
            this.ProjectComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectComboBox2.FormattingEnabled = true;
            this.ProjectComboBox2.Location = new System.Drawing.Point(27, 43);
            this.ProjectComboBox2.Name = "ProjectComboBox2";
            this.ProjectComboBox2.Size = new System.Drawing.Size(187, 21);
            this.ProjectComboBox2.TabIndex = 0;
            this.ProjectComboBox2.SelectedIndexChanged += new System.EventHandler(this.ProjectComboBox2_SelectedIndexChanged);
            // 
            // dmsDataSet4
            // 
            this.dmsDataSet4.DataSetName = "dmsDataSet4";
            this.dmsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gorevBindingSource
            // 
            this.gorevBindingSource.DataMember = "gorev";
            this.gorevBindingSource.DataSource = this.dmsDataSet4;
            // 
            // gorevTableAdapter
            // 
            this.gorevTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateProjectPanel);
            this.Controls.Add(this.AppBarPanel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "UpdateProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProjectForm";
            this.Load += new System.EventHandler(this.UpdateProjectForm_Load);
            this.AppBarPanel4.ResumeLayout(false);
            this.UpdateProjectPanel.ResumeLayout(false);
            this.UpdateProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AppBarPanel4;
        private System.Windows.Forms.Button ExitButton4;
        private System.Windows.Forms.Panel UpdateProjectPanel;
        private System.Windows.Forms.Button UpdateProjectButton2;
        private System.Windows.Forms.Label IncumbentLabel2;
        private System.Windows.Forms.Label NewTaskLabel;
        private System.Windows.Forms.TextBox NewTaskTextBox;
        private System.Windows.Forms.Label ProjectLabel2;
        private System.Windows.Forms.ComboBox ProjectComboBox2;
        private System.Windows.Forms.ComboBox IncumbentComboBox2;
        private System.Windows.Forms.Label EndDateLabel1;
        private System.Windows.Forms.Label StartDateLabel1;
        private dmsDataSet4 dmsDataSet4;
        private System.Windows.Forms.BindingSource gorevBindingSource;
        private dmsDataSet4TableAdapters.gorevTableAdapter gorevTableAdapter;
        private dmsDataSet5 dmsDataSet5;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private dmsDataSet5TableAdapters.kullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.TextBox EndDateTextBox;
        private System.Windows.Forms.TextBox StartDateTextBox;
    }
}