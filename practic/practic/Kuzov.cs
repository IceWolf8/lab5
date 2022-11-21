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
    public partial class Kuzov : Form
    {
        public Kuzov()
        {
            InitializeComponent();
        }

        private void Kuzov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Кузов". При необходимости она может быть перемещена или удалена.
            this.кузовTableAdapter.Fill(this.день_91DataSet.Кузов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            кузовTableAdapter.Update(день_91DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kuzovdob avg = new kuzovdob();
            avg.Owner = this;
            avg.ShowDialog();
        }
    }
}
