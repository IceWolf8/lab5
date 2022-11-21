namespace practic
{
    partial class Zapchasti
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
            this.iDЗапчастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запчастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_авто = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.названиеАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.день_91DataSet = new practic.День_91DataSet();
            this.колВоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запчастиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запчастиTableAdapter = new practic.День_91DataSetTableAdapters.ЗапчастиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.название_автоTableAdapter = new practic.День_91DataSetTableAdapters.Название_автоTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗапчастиDataGridViewTextBoxColumn,
            this.запчастиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.Название_авто,
            this.колВоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.запчастиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDЗапчастиDataGridViewTextBoxColumn
            // 
            this.iDЗапчастиDataGridViewTextBoxColumn.DataPropertyName = "ID Запчасти";
            this.iDЗапчастиDataGridViewTextBoxColumn.HeaderText = "ID Запчасти";
            this.iDЗапчастиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЗапчастиDataGridViewTextBoxColumn.Name = "iDЗапчастиDataGridViewTextBoxColumn";
            this.iDЗапчастиDataGridViewTextBoxColumn.Width = 125;
            // 
            // запчастиDataGridViewTextBoxColumn
            // 
            this.запчастиDataGridViewTextBoxColumn.DataPropertyName = "№ Запчасти";
            this.запчастиDataGridViewTextBoxColumn.HeaderText = "№ Запчасти";
            this.запчастиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.запчастиDataGridViewTextBoxColumn.Name = "запчастиDataGridViewTextBoxColumn";
            this.запчастиDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // Название_авто
            // 
            this.Название_авто.DataPropertyName = "ID Название авто";
            this.Название_авто.DataSource = this.названиеАвтоBindingSource;
            this.Название_авто.DisplayMember = "Наименование";
            this.Название_авто.HeaderText = "Название_авто";
            this.Название_авто.MinimumWidth = 6;
            this.Название_авто.Name = "Название_авто";
            this.Название_авто.ValueMember = "ID";
            this.Название_авто.Width = 125;
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
            // колВоDataGridViewTextBoxColumn
            // 
            this.колВоDataGridViewTextBoxColumn.DataPropertyName = "Кол во";
            this.колВоDataGridViewTextBoxColumn.HeaderText = "Кол во";
            this.колВоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колВоDataGridViewTextBoxColumn.Name = "колВоDataGridViewTextBoxColumn";
            this.колВоDataGridViewTextBoxColumn.Width = 125;
            // 
            // запчастиBindingSource
            // 
            this.запчастиBindingSource.DataMember = "Запчасти";
            this.запчастиBindingSource.DataSource = this.день_91DataSet;
            // 
            // запчастиTableAdapter
            // 
            this.запчастиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // название_автоTableAdapter
            // 
            this.название_автоTableAdapter.ClearBeforeFill = true;
            // 
            // Zapchasti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zapchasti";
            this.Text = "Zapchasti";
            this.Load += new System.EventHandler(this.Zapchasti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public День_91DataSet день_91DataSet;
        public System.Windows.Forms.BindingSource запчастиBindingSource;
        public День_91DataSetTableAdapters.ЗапчастиTableAdapter запчастиTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource названиеАвтоBindingSource;
        private День_91DataSetTableAdapters.Название_автоTableAdapter название_автоTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗапчастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn запчастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Название_авто;
        private System.Windows.Forms.DataGridViewTextBoxColumn колВоDataGridViewTextBoxColumn;
    }
}