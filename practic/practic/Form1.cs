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
    public partial class Form1 : Form
    {
        public object День_91DataSet { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avtonaprodazy avt = new Avtonaprodazy();
            avt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Avtonaremont avtna = new Avtonaremont();
            avtna.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buhgalteria buh = new buhgalteria();
            buh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dlinakuzova dlin = new Dlinakuzova();
            dlin.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dolznost dol = new Dolznost();
            dol.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Zapchasti zap = new Zapchasti();
            zap.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Klienti kli = new Klienti();
            kli.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kuzov kuz = new Kuzov();
            kuz.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Nazvanieavto naz = new Nazvanieavto();
            naz.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Prodazi prod = new Prodazi();
            prod.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Shirina shi = new Shirina();
            shi.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cvet cve = new Cvet();
            cve.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Sotrudniki sotr = new Sotrudniki();
            sotr.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Remont rem = new Remont();
            rem.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Razmerkoles kol = new Razmerkoles();
            kol.ShowDialog();
        }
        //}
    }
}
