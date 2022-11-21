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
    public partial class razmerkoles_dob : Form
    {
        public razmerkoles_dob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Razmerkoles main = this.Owner as Razmerkoles;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[10].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.день_91DataSet.Tables[10].Rows.Add(nRow);
                main.размер_колесTableAdapter.Update(main.день_91DataSet.Размер_колес);
                main.день_91DataSet.Tables[10].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }
    }
}
