namespace proje
{
    partial class AddProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProjectForm));
            this.AppBarPanel4 = new System.Windows.Forms.Panel();
            this.ExitButton4 = new System.Windows.Forms.Button();
            this.AddProjectPanel = new System.Windows.Forms.Panel();
            this.EndDateTextBox = new System.Windows.Forms.TextBox();
            this.StartDateTextBox = new System.Windows.Forms.TextBox();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.EndDateLabel1 = new System.Windows.Forms.Label();
            this.StartDateLabel1 = new System.Windows.Forms.Label();
            this.ProjectLabel3 = new System.Windows.Forms.Label();
            this.calisanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet2 = new proje.dmsDataSet2();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet1 = new proje.dmsDataSet1();
            this.dmsDataSet = new proje.dmsDataSet();
            this.dmsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter = new proje.dmsDataSet1TableAdapters.calisanTableAdapter();
            this.calisanTableAdapter1 = new proje.dmsDataSet2TableAdapters.calisanTableAdapter();
            this.dmsDataSet3 = new proje.dmsDataSet3();
            this.AppBarPanel4.SuspendLayout();
            this.AddProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet3)).BeginInit();
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
            // 
            // AddProjectPanel
            // 
            this.AddProjectPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddProjectPanel.BackgroundImage")));
            this.AddProjectPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddProjectPanel.Controls.Add(this.EndDateTextBox);
            this.AddProjectPanel.Controls.Add(this.StartDateTextBox);
            this.AddProjectPanel.Controls.Add(this.ProjectTextBox);
            this.AddProjectPanel.Controls.Add(this.AddProjectButton);
            this.AddProjectPanel.Controls.Add(this.EndDateLabel1);
            this.AddProjectPanel.Controls.Add(this.StartDateLabel1);
            this.AddProjectPanel.Controls.Add(this.ProjectLabel3);
            this.AddProjectPanel.Location = new System.Drawing.Point(270, 97);
            this.AddProjectPanel.Name = "AddProjectPanel";
            this.AddProjectPanel.Size = new System.Drawing.Size(249, 278);
            this.AddProjectPanel.TabIndex = 5;
            // 
            // EndDateTextBox
            // 
            this.EndDateTextBox.Location = new System.Drawing.Point(28, 163);
            this.EndDateTextBox.Name = "EndDateTextBox";
            this.EndDateTextBox.Size = new System.Drawing.Size(187, 20);
            this.EndDateTextBox.TabIndex = 19;
            // 
            // StartDateTextBox
            // 
            this.StartDateTextBox.Location = new System.Drawing.Point(28, 111);
            this.StartDateTextBox.Name = "StartDateTextBox";
            this.StartDateTextBox.Size = new System.Drawing.Size(187, 20);
            this.StartDateTextBox.TabIndex = 18;
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.Location = new System.Drawing.Point(28, 61);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.Size = new System.Drawing.Size(187, 20);
            this.ProjectTextBox.TabIndex = 6;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(145, 245);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(70, 23);
            this.AddProjectButton.TabIndex = 9;
            this.AddProjectButton.Text = "Add Project";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // EndDateLabel1
            // 
            this.EndDateLabel1.AutoSize = true;
            this.EndDateLabel1.BackColor = System.Drawing.Color.Transparent;
            this.EndDateLabel1.ForeColor = System.Drawing.Color.White;
            this.EndDateLabel1.Location = new System.Drawing.Point(25, 147);
            this.EndDateLabel1.Name = "EndDateLabel1";
            this.EndDateLabel1.Size = new System.Drawing.Size(88, 13);
            this.EndDateLabel1.TabIndex = 6;
            this.EndDateLabel1.Text = "End Date Project";
            // 
            // StartDateLabel1
            // 
            this.StartDateLabel1.AutoSize = true;
            this.StartDateLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StartDateLabel1.ForeColor = System.Drawing.Color.White;
            this.StartDateLabel1.Location = new System.Drawing.Point(25, 95);
            this.StartDateLabel1.Name = "StartDateLabel1";
            this.StartDateLabel1.Size = new System.Drawing.Size(91, 13);
            this.StartDateLabel1.TabIndex = 5;
            this.StartDateLabel1.Text = "Start Date Project";
            // 
            // ProjectLabel3
            // 
            this.ProjectLabel3.AutoSize = true;
            this.ProjectLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ProjectLabel3.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel3.Location = new System.Drawing.Point(25, 45);
            this.ProjectLabel3.Name = "ProjectLabel3";
            this.ProjectLabel3.Size = new System.Drawing.Size(40, 13);
            this.ProjectLabel3.TabIndex = 1;
            this.ProjectLabel3.Text = "Project";
            // 
            // calisanBindingSource1
            // 
            this.calisanBindingSource1.DataMember = "calisan";
            this.calisanBindingSource1.DataSource = this.dmsDataSet2;
            // 
            // dmsDataSet2
            // 
            this.dmsDataSet2.DataSetName = "dmsDataSet2";
            this.dmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "calisan";
            this.calisanBindingSource.DataSource = this.dmsDataSet1;
            // 
            // dmsDataSet1
            // 
            this.dmsDataSet1.DataSetName = "dmsDataSet1";
            this.dmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dmsDataSet
            // 
            this.dmsDataSet.DataSetName = "dmsDataSet";
            this.dmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dmsDataSetBindingSource
            // 
            this.dmsDataSetBindingSource.DataSource = this.dmsDataSet;
            this.dmsDataSetBindingSource.Position = 0;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // calisanTableAdapter1
            // 
            this.calisanTableAdapter1.ClearBeforeFill = true;
            // 
            // dmsDataSet3
            // 
            this.dmsDataSet3.DataSetName = "dmsDataSet3";
            this.dmsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProjectPanel);
            this.Controls.Add(this.AppBarPanel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProjectForm";
            this.AppBarPanel4.ResumeLayout(false);
            this.AddProjectPanel.ResumeLayout(false);
            this.AddProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AppBarPanel4;
        private System.Windows.Forms.Button ExitButton4;
        private System.Windows.Forms.Panel AddProjectPanel;
        private System.Windows.Forms.Label EndDateLabel1;
        private System.Windows.Forms.Label StartDateLabel1;
        private System.Windows.Forms.Label ProjectLabel3;
        private System.Windows.Forms.Button AddProjectButton;
        private dmsDataSet dmsDataSet;
        private System.Windows.Forms.BindingSource dmsDataSetBindingSource;
        private dmsDataSet1 dmsDataSet1;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private dmsDataSet1TableAdapters.calisanTableAdapter calisanTableAdapter;
        private dmsDataSet2 dmsDataSet2;
        private System.Windows.Forms.BindingSource calisanBindingSource1;
        private dmsDataSet2TableAdapters.calisanTableAdapter calisanTableAdapter1;
        private dmsDataSet3 dmsDataSet3;
        private System.Windows.Forms.TextBox EndDateTextBox;
        private System.Windows.Forms.TextBox StartDateTextBox;
        private System.Windows.Forms.TextBox ProjectTextBox;
    }
}