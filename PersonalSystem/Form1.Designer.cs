namespace PersonalSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPersonRegistry = new System.Windows.Forms.GroupBox();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.gbManage = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDatabaseDataSet1 = new PersonalSystem.PersonalDatabaseDataSet1();
            this.btnAdd = new System.Windows.Forms.Button();
            this.personalDatabaseTableAdapter = new PersonalSystem.PersonalDatabaseDataSet1TableAdapters.PersonalDatabaseTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPersonRegistry.SuspendLayout();
            this.gbManage.SuspendLayout();
            this.gbLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonRegistry
            // 
            this.gbPersonRegistry.Controls.Add(this.rdbSingle);
            this.gbPersonRegistry.Controls.Add(this.rdbMarried);
            this.gbPersonRegistry.Controls.Add(this.label7);
            this.gbPersonRegistry.Controls.Add(this.label6);
            this.gbPersonRegistry.Controls.Add(this.label5);
            this.gbPersonRegistry.Controls.Add(this.label4);
            this.gbPersonRegistry.Controls.Add(this.label3);
            this.gbPersonRegistry.Controls.Add(this.label2);
            this.gbPersonRegistry.Controls.Add(this.label1);
            this.gbPersonRegistry.Controls.Add(this.txtJob);
            this.gbPersonRegistry.Controls.Add(this.TxtSalary);
            this.gbPersonRegistry.Controls.Add(this.CmbCity);
            this.gbPersonRegistry.Controls.Add(this.TxtSurname);
            this.gbPersonRegistry.Controls.Add(this.TxtName);
            this.gbPersonRegistry.Controls.Add(this.TxtID);
            this.gbPersonRegistry.Location = new System.Drawing.Point(46, 12);
            this.gbPersonRegistry.Name = "gbPersonRegistry";
            this.gbPersonRegistry.Size = new System.Drawing.Size(361, 361);
            this.gbPersonRegistry.TabIndex = 0;
            this.gbPersonRegistry.TabStop = false;
            this.gbPersonRegistry.Text = "Person Registry";
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(233, 271);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(91, 32);
            this.rdbSingle.TabIndex = 15;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            this.rdbSingle.CheckedChanged += new System.EventHandler(this.rdbSingle_CheckedChanged);
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(120, 273);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(107, 32);
            this.rdbMarried.TabIndex = 14;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            this.rdbMarried.CheckedChanged += new System.EventHandler(this.rdbMarried_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Job:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(120, 313);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(140, 36);
            this.txtJob.TabIndex = 6;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(120, 228);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(140, 36);
            this.TxtSalary.TabIndex = 4;
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(120, 186);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(140, 36);
            this.CmbCity.TabIndex = 3;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(120, 144);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(140, 36);
            this.TxtSurname.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(120, 102);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(140, 36);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(120, 60);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(140, 36);
            this.TxtID.TabIndex = 0;
            // 
            // gbManage
            // 
            this.gbManage.Controls.Add(this.button1);
            this.gbManage.Controls.Add(this.btnGraphs);
            this.gbManage.Controls.Add(this.btnStatistics);
            this.gbManage.Controls.Add(this.btnClear);
            this.gbManage.Controls.Add(this.btnUpdate);
            this.gbManage.Controls.Add(this.btnDelete);
            this.gbManage.Controls.Add(this.btnList);
            this.gbManage.Location = new System.Drawing.Point(523, 12);
            this.gbManage.Name = "gbManage";
            this.gbManage.Size = new System.Drawing.Size(301, 361);
            this.gbManage.TabIndex = 1;
            this.gbManage.TabStop = false;
            this.gbManage.Text = "Management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraphs
            // 
            this.btnGraphs.Location = new System.Drawing.Point(89, 85);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(106, 35);
            this.btnGraphs.TabIndex = 6;
            this.btnGraphs.Text = "Graphs";
            this.btnGraphs.UseVisualStyleBackColor = true;
            this.btnGraphs.Click += new System.EventHandler(this.btnGraphs_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(89, 249);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(106, 35);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(89, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(89, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(89, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(89, 44);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(106, 35);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // gbLogs
            // 
            this.gbLogs.Controls.Add(this.dataGridView1);
            this.gbLogs.Location = new System.Drawing.Point(43, 423);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(1233, 176);
            this.gbLogs.TabIndex = 2;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perSurnameDataGridViewTextBoxColumn,
            this.perCityDataGridViewTextBoxColumn,
            this.perSalaryDataGridViewTextBoxColumn,
            this.perStatusDataGridViewCheckBoxColumn,
            this.perJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalDatabaseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "PerId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "PerId";
            this.perIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "PerName";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "PerName";
            this.perNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            this.perNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSurnameDataGridViewTextBoxColumn
            // 
            this.perSurnameDataGridViewTextBoxColumn.DataPropertyName = "PerSurname";
            this.perSurnameDataGridViewTextBoxColumn.HeaderText = "PerSurname";
            this.perSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSurnameDataGridViewTextBoxColumn.Name = "perSurnameDataGridViewTextBoxColumn";
            this.perSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // perCityDataGridViewTextBoxColumn
            // 
            this.perCityDataGridViewTextBoxColumn.DataPropertyName = "PerCity";
            this.perCityDataGridViewTextBoxColumn.HeaderText = "PerCity";
            this.perCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perCityDataGridViewTextBoxColumn.Name = "perCityDataGridViewTextBoxColumn";
            this.perCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSalaryDataGridViewTextBoxColumn
            // 
            this.perSalaryDataGridViewTextBoxColumn.DataPropertyName = "PerSalary";
            this.perSalaryDataGridViewTextBoxColumn.HeaderText = "PerSalary";
            this.perSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSalaryDataGridViewTextBoxColumn.Name = "perSalaryDataGridViewTextBoxColumn";
            this.perSalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // perStatusDataGridViewCheckBoxColumn
            // 
            this.perStatusDataGridViewCheckBoxColumn.DataPropertyName = "PerStatus";
            this.perStatusDataGridViewCheckBoxColumn.HeaderText = "PerStatus";
            this.perStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perStatusDataGridViewCheckBoxColumn.Name = "perStatusDataGridViewCheckBoxColumn";
            this.perStatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perJobDataGridViewTextBoxColumn
            // 
            this.perJobDataGridViewTextBoxColumn.DataPropertyName = "PerJob";
            this.perJobDataGridViewTextBoxColumn.HeaderText = "PerJob";
            this.perJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perJobDataGridViewTextBoxColumn.Name = "perJobDataGridViewTextBoxColumn";
            this.perJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // personalDatabaseBindingSource
            // 
            this.personalDatabaseBindingSource.DataMember = "PersonalDatabase";
            this.personalDatabaseBindingSource.DataSource = this.personalDatabaseDataSet1;
            // 
            // personalDatabaseDataSet1
            // 
            this.personalDatabaseDataSet1.DataSetName = "PersonalDatabaseDataSet1";
            this.personalDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(166, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // personalDatabaseTableAdapter
            // 
            this.personalDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonalSystem.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(875, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1288, 601);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbLogs);
            this.Controls.Add(this.gbManage);
            this.Controls.Add(this.gbPersonRegistry);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPersonRegistry.ResumeLayout(false);
            this.gbPersonRegistry.PerformLayout();
            this.gbManage.ResumeLayout(false);
            this.gbLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonRegistry;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbManage;
        private System.Windows.Forms.Button btnGraphs;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private PersonalDatabaseDataSet1 personalDatabaseDataSet1;
        private System.Windows.Forms.BindingSource personalDatabaseBindingSource;
        private PersonalDatabaseDataSet1TableAdapters.PersonalDatabaseTableAdapter personalDatabaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personalDatabaseDataSetBindingSource;
        private System.Windows.Forms.Button button1;
    }
}

