namespace practic
{
    partial class buhgalteria
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
            this.день_91DataSet = new practic.День_91DataSet();
            this.день91DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бухгалтерияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бухгалтерияTableAdapter = new practic.День_91DataSetTableAdapters.БухгалтерияTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Продажи = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.продажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ремонта = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бухгалтерияBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.бухгалтерияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бухгалтерияBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.продажиTableAdapter = new practic.День_91DataSetTableAdapters.ПродажиTableAdapter();
            this.ремонтTableAdapter = new practic.День_91DataSetTableAdapters.РемонтTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день91DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // день_91DataSet
            // 
            this.день_91DataSet.DataSetName = "День_91DataSet";
            this.день_91DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // день91DataSetBindingSource
            // 
            this.день91DataSetBindingSource.DataSource = this.день_91DataSet;
            this.день91DataSetBindingSource.Position = 0;
            // 
            // бухгалтерияBindingSource
            // 
            this.бухгалтерияBindingSource.DataMember = "Бухгалтерия";
            this.бухгалтерияBindingSource.DataSource = this.день_91DataSet;
            // 
            // бухгалтерияTableAdapter
            // 
            this.бухгалтерияTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.отчетаDataGridViewTextBoxColumn,
            this.Продажи,
            this.Ремонта});
            this.dataGridView1.DataSource = this.бухгалтерияBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчетаDataGridViewTextBoxColumn
            // 
            this.отчетаDataGridViewTextBoxColumn.DataPropertyName = "№ Отчета";
            this.отчетаDataGridViewTextBoxColumn.HeaderText = "№ Отчета";
            this.отчетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчетаDataGridViewTextBoxColumn.Name = "отчетаDataGridViewTextBoxColumn";
            this.отчетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Продажи
            // 
            this.Продажи.DataPropertyName = "ID Продажи";
            this.Продажи.DataSource = this.продажиBindingSource;
            this.Продажи.DisplayMember = "Дата продажи";
            this.Продажи.HeaderText = "Продажи";
            this.Продажи.MinimumWidth = 6;
            this.Продажи.Name = "Продажи";
            this.Продажи.ValueMember = "ID Продажи";
            this.Продажи.Width = 125;
            // 
            // продажиBindingSource
            // 
            this.продажиBindingSource.DataMember = "Продажи";
            this.продажиBindingSource.DataSource = this.день_91DataSet;
            // 
            // Ремонта
            // 
            this.Ремонта.DataPropertyName = "ID Ремонта";
            this.Ремонта.DataSource = this.ремонтBindingSource;
            this.Ремонта.DisplayMember = "Дата ремонта";
            this.Ремонта.HeaderText = "Ремонта";
            this.Ремонта.MinimumWidth = 6;
            this.Ремонта.Name = "Ремонта";
            this.Ремонта.ValueMember = "ID Ремонта";
            this.Ремонта.Width = 125;
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataMember = "Ремонт";
            this.ремонтBindingSource.DataSource = this.день_91DataSet;
            // 
            // бухгалтерияBindingSource3
            // 
            this.бухгалтерияBindingSource3.DataMember = "Бухгалтерия";
            this.бухгалтерияBindingSource3.DataSource = this.день_91DataSet;
            // 
            // бухгалтерияBindingSource1
            // 
            this.бухгалтерияBindingSource1.DataMember = "Бухгалтерия";
            this.бухгалтерияBindingSource1.DataSource = this.день91DataSetBindingSource;
            // 
            // бухгалтерияBindingSource2
            // 
            this.бухгалтерияBindingSource2.DataMember = "Бухгалтерия";
            this.бухгалтерияBindingSource2.DataSource = this.день91DataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // продажиTableAdapter
            // 
            this.продажиTableAdapter.ClearBeforeFill = true;
            // 
            // ремонтTableAdapter
            // 
            this.ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // buhgalteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "buhgalteria";
            this.Text = "buhgalteria";
            this.Load += new System.EventHandler(this.buhgalteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день91DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерияBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource день91DataSetBindingSource;
        public День_91DataSet день_91DataSet;
        public System.Windows.Forms.BindingSource бухгалтерияBindingSource;
        public День_91DataSetTableAdapters.БухгалтерияTableAdapter бухгалтерияTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource бухгалтерияBindingSource1;
        private System.Windows.Forms.BindingSource бухгалтерияBindingSource2;
        private System.Windows.Forms.BindingSource бухгалтерияBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource продажиBindingSource;
        private День_91DataSetTableAdapters.ПродажиTableAdapter продажиTableAdapter;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private День_91DataSetTableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Продажи;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ремонта;
    }
}