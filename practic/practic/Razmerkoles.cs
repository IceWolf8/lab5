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
    public partial class Razmerkoles : Form
    {
        public Razmerkoles()
        {
            InitializeComponent();
        }

        private void Razmerkoles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Размер_колес". При необходимости она может быть перемещена или удалена.
            this.размер_колесTableAdapter.Fill(this.день_91DataSet.Размер_колес);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            razmerkoles_dob avt = new razmerkoles_dob();
            avt.Owner = this;
            avt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            размер_колесTableAdapter.Update(день_91DataSet);
        }
    }
}
