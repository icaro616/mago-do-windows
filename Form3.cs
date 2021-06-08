using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mago_da_informatica
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 abrir3 = new Form4();
            this.Hide();
            abrir3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 abrir7 = new Form6();
            this.Hide();
            abrir7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 abrir2 = new Form2();
            this.Hide();
            abrir2.ShowDialog();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = 515;
            this.Height = 537;
        }
    }
}
