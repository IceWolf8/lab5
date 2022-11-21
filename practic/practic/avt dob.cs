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
    public partial class avt_dob : Form
    {
        public avt_dob()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avtonaprodazy main = this.Owner as Avtonaprodazy;
                if (main != null)
                {
                    DataRow nRow = main.день_91DataSet.Tables[0].NewRow();
                    int rc = main.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow[4] = textBox1.Text;
                    nRow[8] = textBox2.Text;
                    main.день_91DataSet.Tables[0].Rows.Add(nRow);
                    main.авто_на_продажуTableAdapter.Update(main.день_91DataSet.Авто_на_продажу);
                    main.день_91DataSet.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
