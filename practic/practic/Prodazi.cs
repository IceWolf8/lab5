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
    public partial class Prodazi : Form
    {
        public Prodazi()
        {
            InitializeComponent();
        }

        private void Prodazi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Название_авто". При необходимости она может быть перемещена или удалена.
            this.название_автоTableAdapter.Fill(this.день_91DataSet.Название_авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.день_91DataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.день_91DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Авто_на_продажу". При необходимости она может быть перемещена или удалена.
            this.авто_на_продажуTableAdapter.Fill(this.день_91DataSet.Авто_на_продажу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.день_91DataSet.Продажи);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prod_dob avm = new prod_dob();
            avm.Owner = this;
            avm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodazipoisk boobs = new prodazipoisk();
            boobs.Owner = this;
            boobs.ShowDialog();
        }
    }
}
