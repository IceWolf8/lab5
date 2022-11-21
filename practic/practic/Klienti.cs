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
    public partial class Klienti : Form
    {
        public Klienti()
        {
            InitializeComponent();
        }

        private void Klienti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.день_91DataSet.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            klienti_dob avt = new klienti_dob();
            avt.Owner = this;
            avt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            клиентыTableAdapter.Update(день_91DataSet);
        }
    }
}
