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
    public partial class prod_dob : Form
    {
        public prod_dob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prodazi main = this.Owner as Prodazi;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[9].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[3] = textBox1.Text;
                nRow[4] = textBox2.Text;
                main.день_91DataSet.Tables[9].Rows.Add(nRow);
                main.продажиTableAdapter.Update(main.день_91DataSet.Продажи);
                main.день_91DataSet.Tables[9].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
