namespace practic
{
    partial class Avtonaremont
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_авто = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.названиеАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.день_91DataSet = new practic.День_91DataSet();
            this.автоНаРемонтBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.автоНаРемонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авто_на_ремонтTableAdapter = new practic.День_91DataSetTableAdapters.Авто_на_ремонтTableAdapter();
            this.день91DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.название_автоTableAdapter = new practic.День_91DataSetTableAdapters.Название_автоTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день91DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.договораDataGridViewTextBoxColumn,
            this.Название_авто});
            this.dataGridView1.DataSource = this.автоНаРемонтBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // договораDataGridViewTextBoxColumn
            // 
            this.договораDataGridViewTextBoxColumn.DataPropertyName = "№ Договора";
            this.договораDataGridViewTextBoxColumn.HeaderText = "№ Договора";
            this.договораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.договораDataGridViewTextBoxColumn.Name = "договораDataGridViewTextBoxColumn";
            this.договораDataGridViewTextBoxColumn.Width = 125;
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
            // автоНаРемонтBindingSource1
            // 
            this.автоНаРемонтBindingSource1.DataMember = "Авто на ремонт";
            this.автоНаРемонтBindingSource1.DataSource = this.день_91DataSet;
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
            // день91DataSetBindingSource
            // 
            this.день91DataSetBindingSource.DataSource = this.день_91DataSet;
            this.день91DataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // название_автоTableAdapter
            // 
            this.название_автоTableAdapter.ClearBeforeFill = true;
            // 
            // Avtonaremont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Avtonaremont";
            this.Text = "Avtonaremont";
            this.Load += new System.EventHandler(this.Avtonaremont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.названиеАвтоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоНаРемонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день91DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public День_91DataSet день_91DataSet;
        public System.Windows.Forms.BindingSource автоНаРемонтBindingSource;
        public День_91DataSetTableAdapters.Авто_на_ремонтTableAdapter авто_на_ремонтTableAdapter;
        private System.Windows.Forms.BindingSource автоНаРемонтBindingSource1;
        private System.Windows.Forms.BindingSource день91DataSetBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource названиеАвтоBindingSource;
        private День_91DataSetTableAdapters.Название_автоTableAdapter название_автоTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn договораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Название_авто;
    }
}