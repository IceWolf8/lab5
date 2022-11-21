namespace practic
{
    partial class Avtonaprodazy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.цветBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.день_91DataSet = new practic.День_91DataSet();
            this.длинаКузоваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ширинаКузоваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.размерКолесBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автоНаПродажуBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.автоНаПродажуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автоНаРемонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авто_на_ремонтTableAdapter = new practic.День_91DataSetTableAdapters.Авто_на_ремонтTableAdapter();
            this.авто_на_продажуTableAdapter = new practic.День_91DataSetTableAdapters.Авто_на_продажуTableAdapter();
            this.продажиTableAdapter = new practic.День_91DataSetTableAdapters.ПродажиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.автоНаПродажуПродажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цветTableAdapter = new practic.День_91DataSetTableAdapters.ЦветTableAdapter();
            this.размер_колесTableAdapter = new practic.День_91DataSetTableAdapters.Размер_колесTableAdapter();
            this.длина_кузоваTableAdapter = new practic.День_91DataSetTableAdapters.Длина_кузоваTableAdapter();
            this.ширина_кузоваTableAdapter = new practic.День_91DataSetTableAdapters.Ширина_кузоваTableAdapter();
            this.кузовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кузовTableAdapter = new practic.День_91DataSetTableAdapters.КузовTableAdapter();
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDНазваниеАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цвет = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Кузов = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.мощностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Длина_кузова = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ширина_кузова = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Размер_колес = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.длинаКузоваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ширинаКузоваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерКолесBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуПродажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кузовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn,
            this.iDНазваниеАвтоDataGridViewTextBoxColumn,
            this.Цвет,
            this.Кузов,
            this.мощностьDataGridViewTextBoxColumn,
            this.Длина_кузова,
            this.Ширина_кузова,
            this.Размер_колес,
            this.годВыпускаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автоНаПродажуBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1244, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // цветBindingSource
            // 
            this.цветBindingSource.DataMember = "Цвет";
            this.цветBindingSource.DataSource = this.день_91DataSet;
            // 
            // день_91DataSet
            // 
            this.день_91DataSet.DataSetName = "День_91DataSet";
            this.день_91DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // длинаКузоваBindingSource
            // 
            this.длинаКузоваBindingSource.DataMember = "Длина кузова";
            this.длинаКузоваBindingSource.DataSource = this.день_91DataSet;
            // 
            // ширинаКузоваBindingSource
            // 
            this.ширинаКузоваBindingSource.DataMember = "Ширина кузова";
            this.ширинаКузоваBindingSource.DataSource = this.день_91DataSet;
            // 
            // размерКолесBindingSource
            // 
            this.размерКолесBindingSource.DataMember = "Размер колес";
            this.размерКолесBindingSource.DataSource = this.день_91DataSet;
            // 
            // автоНаПродажуBindingSource1
            // 
            this.автоНаПродажуBindingSource1.DataMember = "Авто на продажу";
            this.автоНаПродажуBindingSource1.DataSource = this.день_91DataSet;
            // 
            // автоНаПродажуBindingSource
            // 
            this.автоНаПродажуBindingSource.DataMember = "Авто на продажу";
            this.автоНаПродажуBindingSource.DataSource = this.день_91DataSet;
            // 
            // автоНаРемонтBindingSource
            // 
            this.автоНаРемонтBindingSource.DataMember = "Авто на ремонт";
            this.автоНаРемонтBindingSource.DataSource = this.день_91DataSet;
            // 
            // авто_на_ремонтTableAdapter
            // 
            this.авто_на_ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // авто_на_продажуTableAdapter
            // 
            this.авто_на_продажуTableAdapter.ClearBeforeFill = true;
            // 
            // продажиTableAdapter
            // 
            this.продажиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1155, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // автоНаПродажуПродажиBindingSource
            // 
            this.автоНаПродажуПродажиBindingSource.DataMember = "Авто на продажуПродажи";
            this.автоНаПродажуПродажиBindingSource.DataSource = this.автоНаПродажуBindingSource;
            // 
            // цветTableAdapter
            // 
            this.цветTableAdapter.ClearBeforeFill = true;
            // 
            // размер_колесTableAdapter
            // 
            this.размер_колесTableAdapter.ClearBeforeFill = true;
            // 
            // длина_кузоваTableAdapter
            // 
            this.длина_кузоваTableAdapter.ClearBeforeFill = true;
            // 
            // ширина_кузоваTableAdapter
            // 
            this.ширина_кузоваTableAdapter.ClearBeforeFill = true;
            // 
            // кузовBindingSource
            // 
            this.кузовBindingSource.DataMember = "Кузов";
            this.кузовBindingSource.DataSource = this.день_91DataSet;
            // 
            // кузовTableAdapter
            // 
            this.кузовTableAdapter.ClearBeforeFill = true;
            // 
            // iDАвтоНаПродажуDataGridViewTextBoxColumn
            // 
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn.DataPropertyName = "ID Авто на продажу";
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn.HeaderText = "ID Авто на продажу";
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn.Name = "iDАвтоНаПродажуDataGridViewTextBoxColumn";
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn.Visible = false;
            this.iDАвтоНаПродажуDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDНазваниеАвтоDataGridViewTextBoxColumn
            // 
            this.iDНазваниеАвтоDataGridViewTextBoxColumn.DataPropertyName = "ID Название авто";
            this.iDНазваниеАвтоDataGridViewTextBoxColumn.HeaderText = "ID Название авто";
            this.iDНазваниеАвтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDНазваниеАвтоDataGridViewTextBoxColumn.Name = "iDНазваниеАвтоDataGridViewTextBoxColumn";
            this.iDНазваниеАвтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // Цвет
            // 
            this.Цвет.DataPropertyName = "ID Цвет";
            this.Цвет.DataSource = this.цветBindingSource;
            this.Цвет.DisplayMember = "Наименование";
            this.Цвет.HeaderText = "Цвет";
            this.Цвет.MinimumWidth = 6;
            this.Цвет.Name = "Цвет";
            this.Цвет.ValueMember = "ID Цвета";
            this.Цвет.Width = 125;
            // 
            // Кузов
            // 
            this.Кузов.DataPropertyName = "ID Кузов";
            this.Кузов.DataSource = this.кузовBindingSource;
            this.Кузов.DisplayMember = "Наименование";
            this.Кузов.HeaderText = "Кузов";
            this.Кузов.MinimumWidth = 6;
            this.Кузов.Name = "Кузов";
            this.Кузов.ValueMember = "ID Кузова";
            this.Кузов.Width = 125;
            // 
            // мощностьDataGridViewTextBoxColumn
            // 
            this.мощностьDataGridViewTextBoxColumn.DataPropertyName = "Мощность";
            this.мощностьDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.мощностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.мощностьDataGridViewTextBoxColumn.Name = "мощностьDataGridViewTextBoxColumn";
            this.мощностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // Длина_кузова
            // 
            this.Длина_кузова.DataPropertyName = "ID Длина кузова";
            this.Длина_кузова.DataSource = this.длинаКузоваBindingSource;
            this.Длина_кузова.DisplayMember = "Длина";
            this.Длина_кузова.HeaderText = "Длина_кузова";
            this.Длина_кузова.MinimumWidth = 6;
            this.Длина_кузова.Name = "Длина_кузова";
            this.Длина_кузова.ValueMember = "ID Длины";
            this.Длина_кузова.Width = 125;
            // 
            // Ширина_кузова
            // 
            this.Ширина_кузова.DataPropertyName = "ID Ширина кузова";
            this.Ширина_кузова.DataSource = this.ширинаКузоваBindingSource;
            this.Ширина_кузова.DisplayMember = "Ширина";
            this.Ширина_кузова.HeaderText = "Ширина_кузова";
            this.Ширина_кузова.MinimumWidth = 6;
            this.Ширина_кузова.Name = "Ширина_кузова";
            this.Ширина_кузова.ValueMember = "ID";
            this.Ширина_кузова.Width = 125;
            // 
            // Размер_колес
            // 
            this.Размер_колес.DataPropertyName = "ID Размер колес";
            this.Размер_колес.DataSource = this.размерКолесBindingSource;
            this.Размер_колес.DisplayMember = "Размер";
            this.Размер_колес.HeaderText = "Размер_колес";
            this.Размер_колес.MinimumWidth = 6;
            this.Размер_колес.Name = "Размер_колес";
            this.Размер_колес.ValueMember = "ID";
            this.Размер_колес.Width = 125;
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            this.годВыпускаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Avtonaprodazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Avtonaprodazy";
            this.Text = "Avtonaprodazy";
            this.Load += new System.EventHandler(this.Avtonaprodazy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.длинаКузоваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ширинаКузоваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерКолесBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуПродажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кузовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public День_91DataSet день_91DataSet;
        public System.Windows.Forms.BindingSource автоНаРемонтBindingSource;
        public День_91DataSetTableAdapters.Авто_на_ремонтTableAdapter авто_на_ремонтTableAdapter;
        public System.Windows.Forms.BindingSource автоНаПродажуBindingSource;
        public День_91DataSetTableAdapters.Авто_на_продажуTableAdapter авто_на_продажуTableAdapter;
        public System.Windows.Forms.BindingSource автоНаПродажуПродажиBindingSource;
        public День_91DataSetTableAdapters.ПродажиTableAdapter продажиTableAdapter;
        public System.Windows.Forms.BindingSource автоНаПродажуBindingSource1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource цветBindingSource;
        private День_91DataSetTableAdapters.ЦветTableAdapter цветTableAdapter;
        private System.Windows.Forms.BindingSource размерКолесBindingSource;
        private День_91DataSetTableAdapters.Размер_колесTableAdapter размер_колесTableAdapter;
        private System.Windows.Forms.BindingSource длинаКузоваBindingSource;
        private День_91DataSetTableAdapters.Длина_кузоваTableAdapter длина_кузоваTableAdapter;
        private System.Windows.Forms.BindingSource ширинаКузоваBindingSource;
        private День_91DataSetTableAdapters.Ширина_кузоваTableAdapter ширина_кузоваTableAdapter;
        private System.Windows.Forms.BindingSource кузовBindingSource;
        private День_91DataSetTableAdapters.КузовTableAdapter кузовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтоНаПродажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDНазваниеАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Цвет;
        private System.Windows.Forms.DataGridViewComboBoxColumn Кузов;
        private System.Windows.Forms.DataGridViewTextBoxColumn мощностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Длина_кузова;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ширина_кузова;
        private System.Windows.Forms.DataGridViewComboBoxColumn Размер_колес;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
    }
}