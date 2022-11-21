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
    public partial class Dolznost : Form
    {
        public Dolznost()
        {
            InitializeComponent();
        }

        private void Dolznost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Должность_сотрудников". При необходимости она может быть перемещена или удалена.
            this.должность_сотрудниковTableAdapter.Fill(this.день_91DataSet.Должность_сотрудников);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dolznostdob avg = new dolznostdob();
            avg.Owner = this;
            avg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            должность_сотрудниковTableAdapter.Update(день_91DataSet);
        }
    }
}
