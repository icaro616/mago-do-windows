using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mago_da_informatica
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("arquivos/icaro2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form7 abrir4 = new Form7();
            this.Hide();
            abrir4.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = 515;
            this.Height = 537;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 abrir2 = new Form2();
            this.Hide();
            abrir2.ShowDialog();
        }
    }
}
