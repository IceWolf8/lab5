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
    public partial class zapchasti_dob : Form
    {
        public zapchasti_dob()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zapchasti main = this.Owner as Zapchasti;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                main.день_91DataSet.Tables[5].Rows.Add(nRow);
                main.запчастиTableAdapter.Update(main.день_91DataSet.Запчасти);
                main.день_91DataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
