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
    public partial class Nazvanieavto : Form
    {
        public Nazvanieavto()
        {
            InitializeComponent();
        }

        private void Nazvanieavto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Название_авто". При необходимости она может быть перемещена или удалена.
            this.название_автоTableAdapter.Fill(this.день_91DataSet.Название_авто);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            название_автоTableAdapter.Update(день_91DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            nazvaniedob avg = new nazvaniedob();
            avg.Owner = this;
            avg.ShowDialog();
        }
    }
    
}
