namespace practic
{
    partial class Dlinakuzova
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
            this.iDДлиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаКузоваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.день_91DataSet = new practic.День_91DataSet();
            this.длина_кузоваTableAdapter = new practic.День_91DataSetTableAdapters.Длина_кузоваTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.длинаКузоваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDДлиныDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.длинаКузоваBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDДлиныDataGridViewTextBoxColumn
            // 
            this.iDДлиныDataGridViewTextBoxColumn.DataPropertyName = "ID Длины";
            this.iDДлиныDataGridViewTextBoxColumn.HeaderText = "ID Длины";
            this.iDДлиныDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDДлиныDataGridViewTextBoxColumn.Name = "iDДлиныDataGridViewTextBoxColumn";
            this.iDДлиныDataGridViewTextBoxColumn.Width = 125;
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            this.длинаDataGridViewTextBoxColumn.Width = 125;
            // 
            // длинаКузоваBindingSource
            // 
            this.длинаКузоваBindingSource.DataMember = "Длина кузова";
            this.длинаКузоваBindingSource.DataSource = this.день_91DataSet;
            // 
            // день_91DataSet
            // 
            this.день_91DataSet.DataSetName = "День_91DataSet";
            this.день_91DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // длина_кузоваTableAdapter
            // 
            this.длина_кузоваTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dlinakuzova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dlinakuzova";
            this.Text = "Dlinakuzova";
            this.Load += new System.EventHandler(this.Dlinakuzova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.длинаКузоваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.день_91DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public День_91DataSet день_91DataSet;
        public System.Windows.Forms.BindingSource длинаКузоваBindingSource;
        public День_91DataSetTableAdapters.Длина_кузоваTableAdapter длина_кузоваTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДлиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}