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
    public partial class dolznostdob : Form
    {
        public dolznostdob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dolznost main = this.Owner as Dolznost;
            if (main != null)
            {
                DataRow nRow = main.день_91DataSet.Tables[4].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                main.день_91DataSet.Tables[4].Rows.Add(nRow);
                main.должность_сотрудниковTableAdapter.Update(main.день_91DataSet.Должность_сотрудников);
                main.день_91DataSet.Tables[4].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
