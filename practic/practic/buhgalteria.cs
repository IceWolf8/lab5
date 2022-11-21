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
    public partial class buhgalteria : Form
    {
        public buhgalteria()
        {
            InitializeComponent();
        }

        private void buhgalteria_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.день_91DataSet.Ремонт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.день_91DataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Бухгалтерия". При необходимости она может быть перемещена или удалена.
            this.бухгалтерияTableAdapter.Fill(this.день_91DataSet.Бухгалтерия);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buh_dob avt = new buh_dob();
            avt.Owner = this;
            avt.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            бухгалтерияTableAdapter.Update(день_91DataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Poisk_buh boobs = new Poisk_buh ();
            boobs.Owner = this;
            boobs.ShowDialog();
        }
    }
}
