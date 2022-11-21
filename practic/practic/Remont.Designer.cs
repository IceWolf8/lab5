namespace practic
{
    partial class Remont
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
            this.iDРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоЗапчастейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сотрудники = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.день_91DataSet = new practic.День_91DataSet();
            this.датаРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клиенты = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Запчсти = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.запчастиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Авто_на_ремонт = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.названиеАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автоНаРемонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонтTableAdapter = new practic.День_91DataSetTableAdapters.РемонтTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.сотрудникиTableAdapter = new practic.День_91DataSetTableAdapters.СотрудникиTableAdapter();
            this.клиентыTableAdapter = new practic.День_91DataSetTableAdapters.КлиентыTableAdapter();
            this.запчастиTableAdapter = new practic.День_91DataSetTableAdapters.ЗапчастиTableAdapter();
            this.авто_на_ремонтTableAdapter = new practic.День_91DataSetTableAdapters.Авто_на_ремонтTableAdapter();
            this.название_автоTableAdapter = new practic.День_91DataSetTableAdapters.Название_автоTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDРемонтаDataGridViewTextBoxColumn,
            this.количествоЗапчастейDataGridViewTextBoxColumn,
            this.Сотрудники,
            this.датаРемонтаDataGridViewTextBoxColumn,
            this.Клиенты,
            this.стоимостьDataGridViewTextBoxColumn,
            this.Запчсти,
            this.Авто_на_ремонт});
            this.dataGridView1.DataSource = this.ремонтBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1281, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDРемонтаDataGridViewTextBoxColumn
            // 
            this.iDРемонтаDataGridViewTextBoxColumn.DataPropertyName = "ID Ремонта";
            this.iDРемонтаDataGridViewTextBoxColumn.HeaderText = "ID Ремонта";
            this.iDРемонтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDРемонтаDataGridViewTextBoxColumn.Name = "iDРемонтаDataGridViewTextBoxColumn";
            this.iDРемонтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоЗапчастейDataGridViewTextBoxColumn
            // 
            this.количествоЗапчастейDataGridViewTextBoxColumn.DataPropertyName = "Количество запчастей";
            this.количествоЗапчастейDataGridViewTextBoxColumn.HeaderText = "Количество запчастей";
            this.количествоЗапчастейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоЗапчастейDataGridViewTextBoxColumn.Name = "количествоЗапчастейDataGridViewTextBoxColumn";
            this.количествоЗапчастейDataGridViewTextBoxColumn.Width = 125;
            // 
            // Сотрудники
            // 
            this.Сотрудники.DataPropertyName = "ID Сотрудники";
            this.Сотрудники.DataSource = this.сотрудникиBindingSource;
            this.Сотрудники.DisplayMember = "Фамилия";
            this.Сотрудники.HeaderText = "Сотрудники";
            this.Сотрудники.MinimumWidth = 6;
            this.Сотрудники.Name = "Сотрудники";
            this.Сотрудники.ValueMember = "ID Сотрудника";
            this.Сотрудники.Width = 125;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.день_91DataSet;
            // 
            // день_91DataSet
            // 
            this.день_91DataSet.DataSetName = "День_91DataSet";
            this.день_91DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // датаРемонтаDataGridViewTextBoxColumn
            // 
            this.датаРемонтаDataGridViewTextBoxColumn.DataPropertyName = "Дата ремонта";
            this.датаРемонтаDataGridViewTextBoxColumn.HeaderText = "Дата ремонта";
            this.датаРемонтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРемонтаDataGridViewTextBoxColumn.Name = "датаРемонтаDataGridViewTextBoxColumn";
            this.датаРемонтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Клиенты
            // 
            this.Клиенты.DataPropertyName = "ID Клиенты";
            this.Клиенты.DataSource = this.клиентыBindingSource;
            this.Клиенты.DisplayMember = "Фамилия";
            this.Клиенты.HeaderText = "Клиенты";
            this.Клиенты.MinimumWidth = 6;
            this.Клиенты.Name = "Клиенты";
            this.Клиенты.ValueMember = "ID Клиента";
            this.Клиенты.Width = 125;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.день_91DataSet;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // Запчсти
            // 
            this.Запчсти.DataPropertyName = "ID Запчсти";
            this.Запчсти.DataSource = this.запчастиBindingSource;
            this.Запчсти.DisplayMember = "№ Запчасти";
            this.Запчсти.HeaderText = "Запчсти";
            this.Запчсти.MinimumWidth = 6;
            this.Запчсти.Name = "Запчсти";
            this.Запчсти.ValueMember = "ID Запчасти";
            this.Запчсти.Width = 125;
            // 
            // запчастиBindingSource
            // 
            this.запчастиBindingSource.DataMember = "Запчасти";
            this.запчастиBindingSource.DataSource = this.день_91DataSet;
            // 
            // Авто_на_ремонт
            // 
            this.Авто_на_ремонт.DataPropertyName = "ID Авто на ремонт";
            this.Авто_на_ремонт.DataSource = this.названиеАвтоBindingSource;
            this.Авто_на_ремонт.DisplayMember = "Наименование";
            this.Авто_на_ремонт.HeaderText = "Авто_на_ремонт";
            this.Авто_на_ремонт.MinimumWidth = 6;
            this.Авто_на_ремонт.Name = "Авто_на_ремонт";
            this.Авто_на_ремонт.ValueMember = "ID";
            this.Авто_на_ремонт.Width = 125;
            // 
            // названиеАвтоBindingSource
            // 
            this.названиеАвтоBindingSource.DataMember = "Название авто";
            this.названиеАвтоBindingSource.DataSource = this.день_91DataSet;
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataMember = "Ремонт";
            this.ремонтBindingSource.DataSource = this.день_91DataSet;
            // 
            // автоНаРемонтBindingSource
            // 
            this.автоНаРемонтBindingSource.DataMember = "Авто на ремонт";
            this.автоНаРемонтBindingSource.DataSource = this.день_91DataSet;
            // 
            // ремонтTableAdapter
            // 
            this.ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1104, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(765, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // запчастиTableAdapter
            // 
            this.запчастиTableAdapter.ClearBeforeFill = true;
            // 
            // авто_на_ремонтTableAdapter
            // 
            this.авто_на_ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // название_автоTableAdapter
            // 
            this.название_автоTableAdapter.ClearBeforeFill = true;
            // 
            // Remont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 499);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Remont";
            this.Text = "Remont";
            this.Load += new System.EventHandler(this.Remont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public День_91DataSet день_91DataSet;
        public System.Windows.Forms.BindingSource ремонтBindingSource;
        public День_91DataSetTableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private День_91DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private День_91DataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource запчастиBindingSource;
        private День_91DataSetTableAdapters.ЗапчастиTableAdapter запчастиTableAdapter;
        private System.Windows.Forms.BindingSource автоНаРемонтBindingSource;
        private День_91DataSetTableAdapters.Авто_на_ремонтTableAdapter авто_на_ремонтTableAdapter;
        private System.Windows.Forms.BindingSource названиеАвтоBindingSource;
        private День_91DataSetTableAdapters.Название_автоTableAdapter название_автоTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЗапчастейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Сотрудники;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Клиенты;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Запчсти;
        private System.Windows.Forms.DataGridViewComboBoxColumn Авто_на_ремонт;
    }
}