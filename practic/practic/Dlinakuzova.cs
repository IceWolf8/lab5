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
    public partial class Dlinakuzova : Form
    {
        public Dlinakuzova()
        {
            InitializeComponent();
        }

        private void Dlinakuzova_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Длина_кузова". При необходимости она может быть перемещена или удалена.
            this.длина_кузоваTableAdapter.Fill(this.день_91DataSet.Длина_кузова);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dlinadob avt = new Dlinadob();
            avt.Owner = this;
            avt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            длина_кузоваTableAdapter.Update(день_91DataSet);
        }
    }
}
