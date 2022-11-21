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
    public partial class klienti_dob : Form
    {
        public klienti_dob()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klienti main = this.Owner as Klienti;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[6].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox6.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox1.Text;
                nRow[4] = textBox3.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = textBox4.Text;
                main.день_91DataSet.Tables[6].Rows.Add(nRow);
                main.клиентыTableAdapter.Update(main.день_91DataSet.Клиенты);
                main.день_91DataSet.Tables[6].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
