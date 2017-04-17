namespace CRUD_v2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertXYZ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.tActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSet = new CRUD_v2.SearchBaseDataSet();
            this.cmbCompare = new System.Windows.Forms.ComboBox();
            this.tCompareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtRegExp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNewAction = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNewCompare = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFillCombobox = new System.Windows.Forms.Button();
            this.cmbPatterns = new System.Windows.Forms.ComboBox();
            this.txtNewRegExp = new System.Windows.Forms.TextBox();
            this.tCompareTableAdapter = new CRUD_v2.SearchBaseDataSetTableAdapters.TCompareTableAdapter();
            this.tActionTableAdapter = new CRUD_v2.SearchBaseDataSetTableAdapters.TActionTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSetFileWithoutID = new CRUD_v2.SearchBaseDataSetFileWithoutID();
            this.btnSearchKeywords = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchBaseDataSetFile = new CRUD_v2.SearchBaseDataSetFile();
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFileTableAdapter = new CRUD_v2.SearchBaseDataSetFileTableAdapters.TFileTableAdapter();
            this.tFileTableAdapter1 = new CRUD_v2.SearchBaseDataSetFileWithoutIDTableAdapters.TFileTableAdapter();
            this.btnEnterLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompareBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetFileWithoutID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertXYZ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbAction);
            this.groupBox1.Controls.Add(this.cmbCompare);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtRegExp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // btnInsertXYZ
            // 
            this.btnInsertXYZ.Location = new System.Drawing.Point(266, 123);
            this.btnInsertXYZ.Name = "btnInsertXYZ";
            this.btnInsertXYZ.Size = new System.Drawing.Size(102, 23);
            this.btnInsertXYZ.TabIndex = 11;
            this.btnInsertXYZ.Text = "Добавить XYZ";
            this.btnInsertXYZ.UseVisualStyleBackColor = true;
            this.btnInsertXYZ.Click += new System.EventHandler(this.btnInsertXYZ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Действие";
            // 
            // cmbAction
            // 
            this.cmbAction.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tActionBindingSource, "actionName", true));
            this.cmbAction.DataSource = this.tActionBindingSource;
            this.cmbAction.DisplayMember = "actionName";
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Location = new System.Drawing.Point(190, 83);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(121, 21);
            this.cmbAction.TabIndex = 9;
            this.cmbAction.ValueMember = "actionName";
            // 
            // tActionBindingSource
            // 
            this.tActionBindingSource.DataMember = "TAction";
            this.tActionBindingSource.DataSource = this.searchBaseDataSetBindingSource;
            // 
            // searchBaseDataSetBindingSource
            // 
            this.searchBaseDataSetBindingSource.DataSource = this.searchBaseDataSet;
            this.searchBaseDataSetBindingSource.Position = 0;
            // 
            // searchBaseDataSet
            // 
            this.searchBaseDataSet.DataSetName = "SearchBaseDataSet";
            this.searchBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCompare
            // 
            this.cmbCompare.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tCompareBindingSource, "compareName", true));
            this.cmbCompare.DataSource = this.tCompareBindingSource;
            this.cmbCompare.DisplayMember = "compareName";
            this.cmbCompare.FormattingEnabled = true;
            this.cmbCompare.Location = new System.Drawing.Point(190, 51);
            this.cmbCompare.Name = "cmbCompare";
            this.cmbCompare.Size = new System.Drawing.Size(121, 21);
            this.cmbCompare.TabIndex = 8;
            this.cmbCompare.ValueMember = "compareName";
            // 
            // tCompareBindingSource
            // 
            this.tCompareBindingSource.DataMember = "TCompare";
            this.tCompareBindingSource.DataSource = this.searchBaseDataSetBindingSource;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(13, 123);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtRegExp
            // 
            this.txtRegExp.Location = new System.Drawing.Point(190, 20);
            this.txtRegExp.Name = "txtRegExp";
            this.txtRegExp.Size = new System.Drawing.Size(121, 20);
            this.txtRegExp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сравнивать с";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шаблон (регулярное выражение)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbNewAction);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbNewCompare);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnFillCombobox);
            this.groupBox2.Controls.Add(this.cmbPatterns);
            this.groupBox2.Controls.Add(this.txtNewRegExp);
            this.groupBox2.Location = new System.Drawing.Point(13, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select, update, delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Изменить Действие";
            // 
            // cmbNewAction
            // 
            this.cmbNewAction.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tActionBindingSource, "actionName", true));
            this.cmbNewAction.DataSource = this.tActionBindingSource;
            this.cmbNewAction.DisplayMember = "actionName";
            this.cmbNewAction.FormattingEnabled = true;
            this.cmbNewAction.Location = new System.Drawing.Point(227, 141);
            this.cmbNewAction.Name = "cmbNewAction";
            this.cmbNewAction.Size = new System.Drawing.Size(121, 21);
            this.cmbNewAction.TabIndex = 13;
            this.cmbNewAction.ValueMember = "actionName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Новый Шаблон (регулярное выражение)";
            // 
            // cmbNewCompare
            // 
            this.cmbNewCompare.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tCompareBindingSource, "compareName", true));
            this.cmbNewCompare.DataSource = this.tCompareBindingSource;
            this.cmbNewCompare.DisplayMember = "compareName";
            this.cmbNewCompare.FormattingEnabled = true;
            this.cmbNewCompare.Location = new System.Drawing.Point(227, 109);
            this.cmbNewCompare.Name = "cmbNewCompare";
            this.cmbNewCompare.Size = new System.Drawing.Size(121, 21);
            this.cmbNewCompare.TabIndex = 12;
            this.cmbNewCompare.ValueMember = "compareName";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Изменить Сравнивать с";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFillCombobox
            // 
            this.btnFillCombobox.Location = new System.Drawing.Point(273, 46);
            this.btnFillCombobox.Name = "btnFillCombobox";
            this.btnFillCombobox.Size = new System.Drawing.Size(75, 23);
            this.btnFillCombobox.TabIndex = 6;
            this.btnFillCombobox.Text = "Заполнить";
            this.btnFillCombobox.UseVisualStyleBackColor = true;
            this.btnFillCombobox.Click += new System.EventHandler(this.btnFillCombobox_Click);
            // 
            // cmbPatterns
            // 
            this.cmbPatterns.FormattingEnabled = true;
            this.cmbPatterns.Location = new System.Drawing.Point(13, 19);
            this.cmbPatterns.Name = "cmbPatterns";
            this.cmbPatterns.Size = new System.Drawing.Size(335, 21);
            this.cmbPatterns.TabIndex = 5;
            // 
            // txtNewRegExp
            // 
            this.txtNewRegExp.Location = new System.Drawing.Point(227, 78);
            this.txtNewRegExp.Name = "txtNewRegExp";
            this.txtNewRegExp.Size = new System.Drawing.Size(121, 20);
            this.txtNewRegExp.TabIndex = 2;
            // 
            // tCompareTableAdapter
            // 
            this.tCompareTableAdapter.ClearBeforeFill = true;
            // 
            // tActionTableAdapter
            // 
            this.tActionTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.btnSearchKeywords);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.txtKeywords);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(394, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 366);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование запроса поиска";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tFileBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(19, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 209);
            this.dataGridView1.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // keywordsDataGridViewTextBoxColumn
            // 
            this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.HeaderText = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // tFileBindingSource1
            // 
            this.tFileBindingSource1.DataMember = "TFile";
            this.tFileBindingSource1.DataSource = this.searchBaseDataSetFileWithoutID;
            // 
            // searchBaseDataSetFileWithoutID
            // 
            this.searchBaseDataSetFileWithoutID.DataSetName = "SearchBaseDataSetFileWithoutID";
            this.searchBaseDataSetFileWithoutID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearchKeywords
            // 
            this.btnSearchKeywords.Location = new System.Drawing.Point(265, 19);
            this.btnSearchKeywords.Name = "btnSearchKeywords";
            this.btnSearchKeywords.Size = new System.Drawing.Size(198, 24);
            this.btnSearchKeywords.TabIndex = 18;
            this.btnSearchKeywords.Text = "Поиск по ключевым словам";
            this.btnSearchKeywords.UseVisualStyleBackColor = true;
            this.btnSearchKeywords.Click += new System.EventHandler(this.btnSearchKeywords_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(205, 77);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(38, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Tag = "rtf";
            this.checkBox4.Text = ".rtf";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(205, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Tag = "txt";
            this.checkBox3.Text = ".txt";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(124, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Tag = "docx";
            this.checkBox2.Text = ".docx";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Формат файла";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Tag = "doc";
            this.checkBox1.Text = ".doc";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(124, 23);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(100, 20);
            this.txtKeywords.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ключевые слова";
            // 
            // searchBaseDataSetFile
            // 
            this.searchBaseDataSetFile.DataSetName = "SearchBaseDataSetFile";
            this.searchBaseDataSetFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFileBindingSource
            // 
            this.tFileBindingSource.DataMember = "TFile";
            this.tFileBindingSource.DataSource = this.searchBaseDataSetFile;
            // 
            // tFileTableAdapter
            // 
            this.tFileTableAdapter.ClearBeforeFill = true;
            // 
            // tFileTableAdapter1
            // 
            this.tFileTableAdapter1.ClearBeforeFill = true;
            // 
            // btnEnterLogin
            // 
            this.btnEnterLogin.Location = new System.Drawing.Point(813, 388);
            this.btnEnterLogin.Name = "btnEnterLogin";
            this.btnEnterLogin.Size = new System.Drawing.Size(158, 23);
            this.btnEnterLogin.TabIndex = 3;
            this.btnEnterLogin.Text = "Вход для администратора";
            this.btnEnterLogin.UseVisualStyleBackColor = true;
            this.btnEnterLogin.Click += new System.EventHandler(this.btnEnterLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 423);
            this.Controls.Add(this.btnEnterLogin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompareBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetFileWithoutID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.ComboBox cmbCompare;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtRegExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFillCombobox;
        private System.Windows.Forms.ComboBox cmbPatterns;
        private System.Windows.Forms.TextBox txtNewRegExp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNewAction;
        private System.Windows.Forms.ComboBox cmbNewCompare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource searchBaseDataSetBindingSource;
        private SearchBaseDataSet searchBaseDataSet;
        private System.Windows.Forms.BindingSource tCompareBindingSource;
        private SearchBaseDataSetTableAdapters.TCompareTableAdapter tCompareTableAdapter;
        private System.Windows.Forms.BindingSource tActionBindingSource;
        private SearchBaseDataSetTableAdapters.TActionTableAdapter tActionTableAdapter;
        private System.Windows.Forms.Button btnInsertXYZ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchKeywords;
        private SearchBaseDataSetFile searchBaseDataSetFile;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        private SearchBaseDataSetFileTableAdapters.TFileTableAdapter tFileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private SearchBaseDataSetFileWithoutID searchBaseDataSetFileWithoutID;
        private System.Windows.Forms.BindingSource tFileBindingSource1;
        private SearchBaseDataSetFileWithoutIDTableAdapters.TFileTableAdapter tFileTableAdapter1;
        private System.Windows.Forms.Button btnEnterLogin;
    }
}