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
    public partial class Avtonaremont : Form
    {
        public Avtonaremont()
        {
            InitializeComponent();
        }

        private void Avtonaremont_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Название_авто". При необходимости она может быть перемещена или удалена.
            this.название_автоTableAdapter.Fill(this.день_91DataSet.Название_авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Авто_на_ремонт". При необходимости она может быть перемещена или удалена.
            this.авто_на_ремонтTableAdapter.Fill(this.день_91DataSet.Авто_на_ремонт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AvtnaRem avt = new AvtnaRem();
            avt.Owner = this;
            avt.ShowDialog();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            авто_на_ремонтTableAdapter.Update(день_91DataSet);
        }
    }
}
