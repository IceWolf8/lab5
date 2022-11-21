using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic
{
    public partial class nazvaniedob : Form
    {
        public nazvaniedob()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nazvanieavto main = this.Owner as Nazvanieavto;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.день_91DataSet.Tables[8].Rows.Add(nRow);
                main.название_автоTableAdapter.Update(main.день_91DataSet.Название_авто);
                main.день_91DataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }
    }
}
