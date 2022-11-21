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
    public partial class Remont : Form
    {
        public Remont()
        {
            InitializeComponent();
        }

        private void Remont_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Название_авто". При необходимости она может быть перемещена или удалена.
            this.название_автоTableAdapter.Fill(this.день_91DataSet.Название_авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Авто_на_ремонт". При необходимости она может быть перемещена или удалена.
            this.авто_на_ремонтTableAdapter.Fill(this.день_91DataSet.Авто_на_ремонт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Запчасти". При необходимости она может быть перемещена или удалена.
            this.запчастиTableAdapter.Fill(this.день_91DataSet.Запчасти);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.день_91DataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.день_91DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.день_91DataSet.Ремонт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remont_dob avt = new remont_dob();
            avt.Owner = this;
            avt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            remont_poisk boobs = new remont_poisk();
            boobs.Owner = this;
            boobs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           ремонтTableAdapter.Update(день_91DataSet);
        }
    }
}
