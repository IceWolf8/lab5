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
    public partial class Avtonaprodazy : Form
    {
        public Avtonaprodazy()
        {
            InitializeComponent();
        }

        private void Avtonaprodazy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Кузов". При необходимости она может быть перемещена или удалена.
            this.кузовTableAdapter.Fill(this.день_91DataSet.Кузов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Ширина_кузова". При необходимости она может быть перемещена или удалена.
            this.ширина_кузоваTableAdapter.Fill(this.день_91DataSet.Ширина_кузова);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Длина_кузова". При необходимости она может быть перемещена или удалена.
            this.длина_кузоваTableAdapter.Fill(this.день_91DataSet.Длина_кузова);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Размер_колес". При необходимости она может быть перемещена или удалена.
            this.размер_колесTableAdapter.Fill(this.день_91DataSet.Размер_колес);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Название_авто". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Цвет". При необходимости она может быть перемещена или удалена.
            this.цветTableAdapter.Fill(this.день_91DataSet.Цвет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.день_91DataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Авто_на_продажу". При необходимости она может быть перемещена или удалена.
            this.авто_на_продажуTableAdapter.Fill(this.день_91DataSet.Авто_на_продажу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "день_91DataSet.Авто_на_ремонт". При необходимости она может быть перемещена или удалена.
            this.авто_на_ремонтTableAdapter.Fill(this.день_91DataSet.Авто_на_ремонт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            авто_на_продажуTableAdapter.Update(день_91DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            avt_dob avt = new avt_dob();
            avt.Owner = this;
            avt.ShowDialog();
        }
    }
}
