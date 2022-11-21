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
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.день_91DataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotrudniki_dob avt = new sotrudniki_dob();
            avt.Owner = this;
            avt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиTableAdapter.Update(день_91DataSet);
        }
    }
}
