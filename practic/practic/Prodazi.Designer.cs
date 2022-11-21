namespace practic
{
    partial class Prodazi
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
            this.iDПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Авто_на_продажу = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.названиеАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.день_91DataSet = new practic.День_91DataSet();
            this.Сотрудника = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клиент = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автоНаПродажуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажиTableAdapter = new practic.День_91DataSetTableAdapters.ПродажиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.авто_на_продажуTableAdapter = new practic.День_91DataSetTableAdapters.Авто_на_продажуTableAdapter();
            this.сотрудникиTableAdapter = new practic.День_91DataSetTableAdapters.СотрудникиTableAdapter();
            this.клиентыTableAdapter = new practic.День_91DataSetTableAdapters.КлиентыTableAdapter();
            this.название_автоTableAdapter = new practic.День_91DataSetTableAdapters.Название_автоTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПродажиDataGridViewTextBoxColumn,
            this.Авто_на_продажу,
            this.Сотрудника,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.Клиент});
            this.dataGridView1.DataSource = this.продажиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDПродажиDataGridViewTextBoxColumn
            // 
            this.iDПродажиDataGridViewTextBoxColumn.DataPropertyName = "ID Продажи";
            this.iDПродажиDataGridViewTextBoxColumn.HeaderText = "ID Продажи";
            this.iDПродажиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПродажиDataGridViewTextBoxColumn.Name = "iDПродажиDataGridViewTextBoxColumn";
            this.iDПродажиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Авто_на_продажу
            // 
            this.Авто_на_продажу.DataPropertyName = "ID Авто на продажу";
            this.Авто_на_продажу.DataSource = this.названиеАвтоBindingSource;
            this.Авто_на_продажу.DisplayMember = "Наименование";
            this.Авто_на_продажу.HeaderText = "Авто_на_продажу";
            this.Авто_на_продажу.MinimumWidth = 6;
            this.Авто_на_продажу.Name = "Авто_на_продажу";
            this.Авто_на_продажу.ValueMember = "ID";
            this.Авто_на_продажу.Width = 125;
            // 
            // названиеАвтоBindingSource
            // 
            this.названиеАвтоBindingSource.DataMember = "Название авто";
            this.названиеАвтоBindingSource.DataSource = this.день_91DataSet;
            // 
            // день_91DataSet
            // 
            this.день_91DataSet.DataSetName = "День_91DataSet";
            this.день_91DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Сотрудника
            // 
            this.Сотрудника.DataPropertyName = "ID Сотрудника";
            this.Сотрудника.DataSource = this.сотрудникиBindingSource;
            this.Сотрудника.DisplayMember = "Фамилия";
            this.Сотрудника.HeaderText = "Сотрудника";
            this.Сотрудника.MinimumWidth = 6;
            this.Сотрудника.Name = "Сотрудника";
            this.Сотрудника.ValueMember = "ID Сотрудника";
            this.Сотрудника.Width = 125;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.день_91DataSet;
            // 
            // датаПродажиDataGridViewTextBoxColumn
            // 
            this.датаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПродажиDataGridViewTextBoxColumn.Name = "датаПродажиDataGridViewTextBoxColumn";
            this.датаПродажиDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // Клиент
            // 
            this.Клиент.DataPropertyName = "ID Клиента";
            this.Клиент.DataSource = this.клиентыBindingSource;
            this.Клиент.DisplayMember = "Фамилия";
            this.Клиент.HeaderText = "Клиент";
            this.Клиент.MinimumWidth = 6;
            this.Клиент.Name = "Клиент";
            this.Клиент.ValueMember = "ID Клиента";
            this.Клиент.Width = 125;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.день_91DataSet;
            // 
            // продажиBindingSource
            // 
            this.продажиBindingSource.DataMember = "Продажи";
            this.продажиBindingSource.DataSource = this.день_91DataSet;
            // 
            // автоНаПродажуBindingSource
            // 
            this.автоНаПродажуBindingSource.DataMember = "Авто на продажу";
            this.автоНаПродажуBindingSource.DataSource = this.день_91DataSet;
            // 
            // продажиTableAdapter
            // 
            this.продажиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // авто_на_продажуTableAdapter
            // 
            this.авто_на_продажуTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // название_автоTableAdapter
            // 
            this.название_автоTableAdapter.ClearBeforeFill = true;
            // 
            // Prodazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prodazi";
            this.Text = "Prodazi";
            this.Load += new System.EventHandler(this.Prodazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаПродажуBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public День_91DataSet день_91DataSet;
        public System.Windows.Forms.BindingSource продажиBindingSource;
        public День_91DataSetTableAdapters.ПродажиTableAdapter продажиTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.BindingSource автоНаПродажуBindingSource;
        public День_91DataSetTableAdapters.Авто_на_продажуTableAdapter авто_на_продажуTableAdapter;
        public System.Windows.Forms.BindingSource сотрудникиBindingSource;
        public День_91DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        public System.Windows.Forms.BindingSource клиентыBindingSource;
        public День_91DataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource названиеАвтоBindingSource;
        private День_91DataSetTableAdapters.Название_автоTableAdapter название_автоTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Авто_на_продажу;
        private System.Windows.Forms.DataGridViewComboBoxColumn Сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Клиент;
    }
}