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
    public partial class Form4 : Form
    {
      
        public Form4()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
                picImagem.Load("arquivos/icaro.jpg");
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Form4_Load(object sender, EventArgs e)
        {



            this.Top = 0;
            this.Left = 0;
            this.Width = 515;
            this.Height = 537;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 abrir4 = new Form5();
            this.Hide();
            abrir4.ShowDialog();
        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 abrir2 = new Form2();
            this.Hide();
            abrir2.ShowDialog();
        }
    }
    }

