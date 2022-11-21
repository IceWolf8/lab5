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
    public partial class Zapchasti : Form
    {
        public Zapchasti()
        {
            InitializeComponent();
        }

        private void Zapchasti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Название_авто". При необходимости она может быть перемещена или удалена.
            this.название_автоTableAdapter.Fill(this.день_91DataSet.Название_авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Запчасти". При необходимости она может быть перемещена или удалена.
            this.запчастиTableAdapter.Fill(this.день_91DataSet.Запчасти);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zapchasti_dob avt = new zapchasti_dob();
            avt.Owner = this;
            avt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            запчастиTableAdapter.Update(день_91DataSet);
        }
    }
}
