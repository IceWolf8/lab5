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
    public partial class Dlinadob : Form
    {
        public Dlinadob()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dlinakuzova main = this.Owner as Dlinakuzova;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[3].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.день_91DataSet.Tables[3].Rows.Add(nRow);
                main.длина_кузоваTableAdapter.Update(main.день_91DataSet.Длина_кузова);
                main.день_91DataSet.Tables[3].AcceptChanges();
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
