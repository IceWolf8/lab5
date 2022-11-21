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
    public partial class buh_dob : Form
    {
        public buh_dob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buhgalteria main = this.Owner as buhgalteria;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[2] = textBox1.Text;
                main.день_91DataSet.Tables[2].Rows.Add(nRow);
                main.бухгалтерияTableAdapter.Update(main.день_91DataSet.Бухгалтерия);
                main.день_91DataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }
    }
}
