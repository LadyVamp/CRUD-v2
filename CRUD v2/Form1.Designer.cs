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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cbRtf = new System.Windows.Forms.CheckBox();
            this.cbTxt = new System.Windows.Forms.CheckBox();
            this.cbDocx = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDoc = new System.Windows.Forms.CheckBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompareBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSize);
            this.groupBox3.Controls.Add(this.cbRtf);
            this.groupBox3.Controls.Add(this.cbTxt);
            this.groupBox3.Controls.Add(this.cbDocx);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbDoc);
            this.groupBox3.Controls.Add(this.txtKeywords);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(394, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 366);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование запроса поиска";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "До";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "От";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Kb";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Kb";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Размер файла";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(124, 106);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(52, 20);
            this.txtSize.TabIndex = 9;
            // 
            // cbRtf
            // 
            this.cbRtf.AutoSize = true;
            this.cbRtf.Location = new System.Drawing.Point(205, 77);
            this.cbRtf.Name = "cbRtf";
            this.cbRtf.Size = new System.Drawing.Size(38, 17);
            this.cbRtf.TabIndex = 8;
            this.cbRtf.Text = ".rtf";
            this.cbRtf.UseVisualStyleBackColor = true;
            // 
            // cbTxt
            // 
            this.cbTxt.AutoSize = true;
            this.cbTxt.Location = new System.Drawing.Point(205, 52);
            this.cbTxt.Name = "cbTxt";
            this.cbTxt.Size = new System.Drawing.Size(40, 17);
            this.cbTxt.TabIndex = 6;
            this.cbTxt.Text = ".txt";
            this.cbTxt.UseVisualStyleBackColor = true;
            // 
            // cbDocx
            // 
            this.cbDocx.AutoSize = true;
            this.cbDocx.Location = new System.Drawing.Point(124, 79);
            this.cbDocx.Name = "cbDocx";
            this.cbDocx.Size = new System.Drawing.Size(52, 17);
            this.cbDocx.TabIndex = 4;
            this.cbDocx.Text = ".docx";
            this.cbDocx.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Формат файла";
            // 
            // cbDoc
            // 
            this.cbDoc.AutoSize = true;
            this.cbDoc.Location = new System.Drawing.Point(124, 53);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(47, 17);
            this.cbDoc.TabIndex = 2;
            this.cbDoc.Text = ".doc";
            this.cbDoc.UseVisualStyleBackColor = true;
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(124, 23);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(100, 20);
            this.txtKeywords.TabIndex = 17;
            //this.txtKeywords.TextChanged += new System.EventHandler(this.txtKeywords_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 403);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.CheckBox cbDoc;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbRtf;
        private System.Windows.Forms.CheckBox cbTxt;
        private System.Windows.Forms.CheckBox cbDocx;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}

