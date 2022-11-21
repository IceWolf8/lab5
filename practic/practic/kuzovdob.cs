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
    public partial class kuzovdob : Form
    {
        public kuzovdob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kuzov main = this.Owner as Kuzov;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.день_91DataSet.Tables[7].Rows.Add(nRow);
                main.кузовTableAdapter.Update(main.день_91DataSet.Кузов);
                main.день_91DataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
               
            }
        }
    }
}
