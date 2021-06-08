using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Windows;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.CodeDom;
using System.Dynamic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Diagnostics;


using System.ComponentModel;

using System.Text;
using System.Threading.Tasks;




namespace mago_da_informatica
{
    public partial class Form5 : Form
    {
        public object Imagem { get; private set; }

        public Form5()

        {

            InitializeComponent();

        }





        class Program
        {






           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SalvarIMG = new SaveFileDialog();
            {
                var bmp1 = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                                      Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                Bitmap icaro = new Bitmap(@"arquivos/icaro.jpg");


                using (var grafico = Graphics.FromImage(bmp1))
                {
                    grafico.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    grafico.SmoothingMode = SmoothingMode.HighQuality;
                    grafico.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    grafico.CompositingQuality = CompositingQuality.HighQuality;
                    grafico.DrawImage(icaro, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                }




                SalvarIMG.InitialDirectory = ("C:\\");

                SalvarIMG.FileName = "Imagem";

                SalvarIMG.Title = "Salvand Imagem";

                SalvarIMG.Filter = ("*jpg|*.jpg");

                SalvarIMG.ShowDialog();

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID  
                // for the Quality parameter category.  
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object.  
                // An EncoderParameters object has an array of EncoderParameter  
                // objects. In this case, there is only one  
                // EncoderParameter object in the array.  
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp1.Save(SalvarIMG.FileName, jpgEncoder, myEncoderParameters);

            }

        }







        private ImageCodecInfo GetEncoder(ImageFormat jpeg)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == jpeg.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 abrir2 = new Form2();
            this.Hide();
            abrir2.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = 515;
            this.Height = 537;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 abrir5 = new Form9();
            this.Hide();
            abrir5.ShowDialog();
        }
    }
}


        
    

