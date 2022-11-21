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
    public partial class AvtnaRem : Form
    {
        public AvtnaRem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Avtonaremont main = this.Owner as Avtonaremont;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[1].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.день_91DataSet.Tables[1].Rows.Add(nRow);
                main.авто_на_ремонтTableAdapter.Update(main.день_91DataSet.Авто_на_ремонт);
                main.день_91DataSet.Tables[1].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                
            }
        }
    }
}
