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
    public partial class remont_dob : Form
    {
        public remont_dob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remont main = this.Owner as Remont;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[11].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                main.день_91DataSet.Tables[11].Rows.Add(nRow);
                main.ремонтTableAdapter.Update(main.день_91DataSet.Ремонт);
                main.день_91DataSet.Tables[11].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
