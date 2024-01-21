namespace proje
{
    partial class ViewIncumbentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIncumbentsForm));
            this.AppBarPanel5 = new System.Windows.Forms.Panel();
            this.ExitButton5 = new System.Windows.Forms.Button();
            this.IncumbentsComboBox3 = new System.Windows.Forms.ComboBox();
            this.gorevBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet12 = new proje.dmsDataSet12();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet7 = new proje.dmsDataSet7();
            this.IncumbentLabel3 = new System.Windows.Forms.Label();
            this.ProjectLabel4 = new System.Windows.Forms.Label();
            this.OngoingTaskLabel = new System.Windows.Forms.Label();
            this.projeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmsDataSet6 = new proje.dmsDataSet6();
            this.projeTableAdapter = new proje.dmsDataSet6TableAdapters.projeTableAdapter();
            this.kullaniciTableAdapter = new proje.dmsDataSet7TableAdapters.kullaniciTableAdapter();
            this.dmsDataSet11 = new proje.dmsDataSet11();
            this.gorevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevTableAdapter = new proje.dmsDataSet11TableAdapters.gorevTableAdapter();
            this.gorevTableAdapter1 = new proje.dmsDataSet12TableAdapters.gorevTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.TasktoStartedLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.dmsDataSet1 = new proje.dmsDataSet();
            this.OngoingTextBox = new System.Windows.Forms.TextBox();
            this.CompletedTextBox = new System.Windows.Forms.TextBox();
            this.StartedTextBox = new System.Windows.Forms.TextBox();
            this.OngoingComboBox = new System.Windows.Forms.ComboBox();
            this.CompletedComboBox = new System.Windows.Forms.ComboBox();
            this.StartedComboBox = new System.Windows.Forms.ComboBox();
            this.AppBarPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorevBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppBarPanel5
            // 
            this.AppBarPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AppBarPanel5.Controls.Add(this.ExitButton5);
            this.AppBarPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBarPanel5.Location = new System.Drawing.Point(0, 0);
            this.AppBarPanel5.Name = "AppBarPanel5";
            this.AppBarPanel5.Size = new System.Drawing.Size(263, 27);
            this.AppBarPanel5.TabIndex = 1;
            // 
            // ExitButton5
            // 
            this.ExitButton5.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton5.BackgroundImage")));
            this.ExitButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton5.FlatAppearance.BorderSize = 0;
            this.ExitButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton5.Location = new System.Drawing.Point(225, 0);
            this.ExitButton5.Name = "ExitButton5";
            this.ExitButton5.Size = new System.Drawing.Size(35, 27);
            this.ExitButton5.TabIndex = 1;
            this.ExitButton5.UseVisualStyleBackColor = false;
            this.ExitButton5.Click += new System.EventHandler(this.ExitButton5_Click);
            // 
            // IncumbentsComboBox3
            // 
            this.IncumbentsComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IncumbentsComboBox3.FormattingEnabled = true;
            this.IncumbentsComboBox3.Location = new System.Drawing.Point(45, 54);
            this.IncumbentsComboBox3.Name = "IncumbentsComboBox3";
            this.IncumbentsComboBox3.Size = new System.Drawing.Size(177, 21);
            this.IncumbentsComboBox3.TabIndex = 2;
            this.IncumbentsComboBox3.SelectedIndexChanged += new System.EventHandler(this.IncumbentsComboBox3_SelectedIndexChanged);
            // 
            // gorevBindingSource1
            // 
            this.gorevBindingSource1.DataMember = "gorev";
            this.gorevBindingSource1.DataSource = this.dmsDataSet12;
            // 
            // dmsDataSet12
            // 
            this.dmsDataSet12.DataSetName = "dmsDataSet12";
            this.dmsDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "kullanici";
            this.kullaniciBindingSource.DataSource = this.dmsDataSet7;
            // 
            // dmsDataSet7
            // 
            this.dmsDataSet7.DataSetName = "dmsDataSet7";
            this.dmsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IncumbentLabel3
            // 
            this.IncumbentLabel3.AutoSize = true;
            this.IncumbentLabel3.BackColor = System.Drawing.Color.Transparent;
            this.IncumbentLabel3.ForeColor = System.Drawing.Color.White;
            this.IncumbentLabel3.Location = new System.Drawing.Point(42, 38);
            this.IncumbentLabel3.Name = "IncumbentLabel3";
            this.IncumbentLabel3.Size = new System.Drawing.Size(57, 13);
            this.IncumbentLabel3.TabIndex = 6;
            this.IncumbentLabel3.Text = "Incumbent";
            // 
            // ProjectLabel4
            // 
            this.ProjectLabel4.AutoSize = true;
            this.ProjectLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ProjectLabel4.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel4.Location = new System.Drawing.Point(42, 78);
            this.ProjectLabel4.Name = "ProjectLabel4";
            this.ProjectLabel4.Size = new System.Drawing.Size(45, 13);
            this.ProjectLabel4.TabIndex = 7;
            this.ProjectLabel4.Text = "Projects";
            // 
            // OngoingTaskLabel
            // 
            this.OngoingTaskLabel.AutoSize = true;
            this.OngoingTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.OngoingTaskLabel.ForeColor = System.Drawing.Color.White;
            this.OngoingTaskLabel.Location = new System.Drawing.Point(42, 174);
            this.OngoingTaskLabel.Name = "OngoingTaskLabel";
            this.OngoingTaskLabel.Size = new System.Drawing.Size(79, 13);
            this.OngoingTaskLabel.TabIndex = 8;
            this.OngoingTaskLabel.Text = "Ongoing Tasks";
            // 
            // projeBindingSource
            // 
            this.projeBindingSource.DataMember = "proje";
            this.projeBindingSource.DataSource = this.dmsDataSet6;
            // 
            // dmsDataSet6
            // 
            this.dmsDataSet6.DataSetName = "dmsDataSet6";
            this.dmsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeTableAdapter
            // 
            this.projeTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // dmsDataSet11
            // 
            this.dmsDataSet11.DataSetName = "dmsDataSet11";
            this.dmsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gorevBindingSource
            // 
            this.gorevBindingSource.DataMember = "gorev";
            this.gorevBindingSource.DataSource = this.dmsDataSet11;
            // 
            // gorevTableAdapter
            // 
            this.gorevTableAdapter.ClearBeforeFill = true;
            // 
            // gorevTableAdapter1
            // 
            this.gorevTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(45, 94);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(177, 69);
            this.ProjectListBox.TabIndex = 19;
            // 
            // TasktoStartedLabel
            // 
            this.TasktoStartedLabel.AutoSize = true;
            this.TasktoStartedLabel.BackColor = System.Drawing.Color.Transparent;
            this.TasktoStartedLabel.ForeColor = System.Drawing.Color.White;
            this.TasktoStartedLabel.Location = new System.Drawing.Point(38, 269);
            this.TasktoStartedLabel.Name = "TasktoStartedLabel";
            this.TasktoStartedLabel.Size = new System.Drawing.Size(83, 13);
            this.TasktoStartedLabel.TabIndex = 20;
            this.TasktoStartedLabel.Text = " Task to Started";
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompletedLabel.ForeColor = System.Drawing.Color.White;
            this.CompletedLabel.Location = new System.Drawing.Point(42, 218);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(89, 13);
            this.CompletedLabel.TabIndex = 22;
            this.CompletedLabel.Text = "Completed Tasks";
            // 
            // dmsDataSet1
            // 
            this.dmsDataSet1.DataSetName = "dmsDataSet";
            this.dmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OngoingTextBox
            // 
            this.OngoingTextBox.Location = new System.Drawing.Point(196, 190);
            this.OngoingTextBox.Name = "OngoingTextBox";
            this.OngoingTextBox.ReadOnly = true;
            this.OngoingTextBox.Size = new System.Drawing.Size(26, 20);
            this.OngoingTextBox.TabIndex = 24;
            // 
            // CompletedTextBox
            // 
            this.CompletedTextBox.Location = new System.Drawing.Point(196, 234);
            this.CompletedTextBox.Name = "CompletedTextBox";
            this.CompletedTextBox.ReadOnly = true;
            this.CompletedTextBox.Size = new System.Drawing.Size(26, 20);
            this.CompletedTextBox.TabIndex = 25;
            // 
            // StartedTextBox
            // 
            this.StartedTextBox.Location = new System.Drawing.Point(196, 285);
            this.StartedTextBox.Name = "StartedTextBox";
            this.StartedTextBox.ReadOnly = true;
            this.StartedTextBox.Size = new System.Drawing.Size(26, 20);
            this.StartedTextBox.TabIndex = 26;
            // 
            // OngoingComboBox
            // 
            this.OngoingComboBox.DataSource = this.gorevBindingSource1;
            this.OngoingComboBox.DisplayMember = "kullaniciAdSoyad";
            this.OngoingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OngoingComboBox.FormattingEnabled = true;
            this.OngoingComboBox.Location = new System.Drawing.Point(45, 189);
            this.OngoingComboBox.Name = "OngoingComboBox";
            this.OngoingComboBox.Size = new System.Drawing.Size(147, 21);
            this.OngoingComboBox.TabIndex = 27;
            // 
            // CompletedComboBox
            // 
            this.CompletedComboBox.DataSource = this.gorevBindingSource1;
            this.CompletedComboBox.DisplayMember = "kullaniciAdSoyad";
            this.CompletedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompletedComboBox.FormattingEnabled = true;
            this.CompletedComboBox.Location = new System.Drawing.Point(45, 233);
            this.CompletedComboBox.Name = "CompletedComboBox";
            this.CompletedComboBox.Size = new System.Drawing.Size(147, 21);
            this.CompletedComboBox.TabIndex = 28;
            // 
            // StartedComboBox
            // 
            this.StartedComboBox.DataSource = this.gorevBindingSource1;
            this.StartedComboBox.DisplayMember = "kullaniciAdSoyad";
            this.StartedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartedComboBox.FormattingEnabled = true;
            this.StartedComboBox.Location = new System.Drawing.Point(45, 285);
            this.StartedComboBox.Name = "StartedComboBox";
            this.StartedComboBox.Size = new System.Drawing.Size(145, 21);
            this.StartedComboBox.TabIndex = 29;
            // 
            // ViewIncumbentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.ExitButton5;
            this.ClientSize = new System.Drawing.Size(263, 344);
            this.Controls.Add(this.StartedComboBox);
            this.Controls.Add(this.CompletedComboBox);
            this.Controls.Add(this.OngoingComboBox);
            this.Controls.Add(this.StartedTextBox);
            this.Controls.Add(this.CompletedTextBox);
            this.Controls.Add(this.OngoingTextBox);
            this.Controls.Add(this.CompletedLabel);
            this.Controls.Add(this.TasktoStartedLabel);
            this.Controls.Add(this.ProjectListBox);
            this.Controls.Add(this.OngoingTaskLabel);
            this.Controls.Add(this.ProjectLabel4);
            this.Controls.Add(this.IncumbentLabel3);
            this.Controls.Add(this.IncumbentsComboBox3);
            this.Controls.Add(this.AppBarPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewIncumbentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewIncumbentsForm";
            this.Load += new System.EventHandler(this.ViewIncumbentsForm_Load);
            this.AppBarPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gorevBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AppBarPanel5;
        private System.Windows.Forms.Button ExitButton5;
        private System.Windows.Forms.ComboBox IncumbentsComboBox3;
        private System.Windows.Forms.Label IncumbentLabel3;
        private System.Windows.Forms.Label ProjectLabel4;
        private System.Windows.Forms.Label OngoingTaskLabel;
        private dmsDataSet6 dmsDataSet6;
        private System.Windows.Forms.BindingSource projeBindingSource;
        private dmsDataSet6TableAdapters.projeTableAdapter projeTableAdapter;
        private dmsDataSet7 dmsDataSet7;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private dmsDataSet7TableAdapters.kullaniciTableAdapter kullaniciTableAdapter;
        private dmsDataSet11 dmsDataSet11;
        private System.Windows.Forms.BindingSource gorevBindingSource;
        private dmsDataSet11TableAdapters.gorevTableAdapter gorevTableAdapter;
        private dmsDataSet12 dmsDataSet12;
        private System.Windows.Forms.BindingSource gorevBindingSource1;
        private dmsDataSet12TableAdapters.gorevTableAdapter gorevTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox ProjectListBox;
        private System.Windows.Forms.Label TasktoStartedLabel;
        private System.Windows.Forms.Label CompletedLabel;
        private dmsDataSet dmsDataSet1;
        private System.Windows.Forms.TextBox OngoingTextBox;
        private System.Windows.Forms.TextBox CompletedTextBox;
        private System.Windows.Forms.TextBox StartedTextBox;
        private System.Windows.Forms.ComboBox OngoingComboBox;
        private System.Windows.Forms.ComboBox CompletedComboBox;
        private System.Windows.Forms.ComboBox StartedComboBox;
    }
}