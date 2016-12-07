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
            this.searchBaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchBaseDataSet1 = new CRUD_v2.SearchBaseDataSet1();
            this.tSearchPatternBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tSearchPatternTableAdapter = new CRUD_v2.SearchBaseDataSet1TableAdapters.TSearchPatternTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tSearchPatternBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompareBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.cmbPatterns.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tSearchPatternBindingSource, "regularExpression", true));
            this.cmbPatterns.DataSource = this.tSearchPatternBindingSource;
            this.cmbPatterns.DisplayMember = "regularExpression";
            this.cmbPatterns.FormattingEnabled = true;
            this.cmbPatterns.Location = new System.Drawing.Point(13, 19);
            this.cmbPatterns.Name = "cmbPatterns";
            this.cmbPatterns.Size = new System.Drawing.Size(335, 21);
            this.cmbPatterns.TabIndex = 5;
            this.cmbPatterns.ValueMember = "regularExpression";
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
            // searchBaseDataSetBindingSource1
            // 
            this.searchBaseDataSetBindingSource1.DataSource = this.searchBaseDataSet;
            this.searchBaseDataSetBindingSource1.Position = 0;
            // 
            // searchBaseDataSet1
            // 
            this.searchBaseDataSet1.DataSetName = "SearchBaseDataSet1";
            this.searchBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tSearchPatternBindingSource
            // 
            this.tSearchPatternBindingSource.DataMember = "TSearchPattern";
            this.tSearchPatternBindingSource.DataSource = this.searchBaseDataSet1;
            // 
            // tSearchPatternTableAdapter
            // 
            this.tSearchPatternTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 141);
            this.dataGridView1.TabIndex = 2;
            // 
            // tSearchPatternBindingSource1
            // 
            this.tSearchPatternBindingSource1.DataMember = "TSearchPattern";
            this.tSearchPatternBindingSource1.DataSource = this.searchBaseDataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 403);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSearchPatternBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource searchBaseDataSetBindingSource1;
        private SearchBaseDataSet1 searchBaseDataSet1;
        private System.Windows.Forms.BindingSource tSearchPatternBindingSource;
        private SearchBaseDataSet1TableAdapters.TSearchPatternTableAdapter tSearchPatternTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tSearchPatternBindingSource1;
    }
}

