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
    public partial class sotrudniki_dob : Form
    {
        public sotrudniki_dob()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sotrudniki main = this.Owner as Sotrudniki;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[12].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = textBox6.Text;
                nRow[7] = textBox7.Text;
                main.день_91DataSet.Tables[12].Rows.Add(nRow);
                main.сотрудникиTableAdapter.Update(main.день_91DataSet.Сотрудники);
                main.день_91DataSet.Tables[12].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
