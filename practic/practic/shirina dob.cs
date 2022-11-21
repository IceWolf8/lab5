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
    public partial class shirina_dob : Form
    {
        public shirina_dob()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shirina main = this.Owner as Shirina;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[14].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.день_91DataSet.Tables[14].Rows.Add(nRow);
                main.ширина_кузоваTableAdapter.Update(main.день_91DataSet.Ширина_кузова);
                main.день_91DataSet.Tables[14].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
