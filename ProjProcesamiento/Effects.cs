using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;
using System.Drawing;

namespace ProjProcesamiento
{
    public partial class Effects : Form
    {
        Image<Bgr, Byte> image;
        public Effects(Image<Bgr, Byte> imagePar)
        {
            InitializeComponent();
            image = imagePar;
            imageBox1.Image = image;
        }

        private void Effects_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"Manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnSaveChngs_Click(object sender, EventArgs e)
        {
            //DIALOGO PARA SELECCIONAR LA RUTA PARA GUARDAR
            SaveFileDialog sf = new SaveFileDialog();
            //FILTRO DE IMAGENES JPG
            sf.Filter = "Imagenes JPG | *.jpg";
            //MOSTRAR DIALOG
            sf.ShowDialog();
            //ASEGURAR QUE SEA UNA RUTA VALIDA
            if (sf.FileName != null || sf.FileName != "")
            {
                //VARIABLE PARA LA IMAGE
                image.Save(sf.FileName);
                image.Dispose();

            }
        }

        private void Effects_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                //ref https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-grayscale-image-in-csharp-using-visual-studio
                StringBuilder t = new StringBuilder();
                Bitmap bit = image.ToBitmap();
                //Bitmap newBit = new Bitmap(bit.Width,bit.Height);

                //get image dimension
                int width = bit.Width;
                int height = bit.Height;

                //color of pixel
                Color p;

                //grayscale
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        p = bit.GetPixel(x, y);

                        //extract pixel component ARGB
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        //find average
                        int avg = (r + g + b) / 3;

                        //set new pixel value
                        bit.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                    }
                }


                Image<Bgr, Byte> newImage = new Image<Bgr, Byte>(bit);
                imageBox1.Image = newImage;

            }
            else if (checkBox1.Checked == false)
            {
                imageBox1.Image = image;

            }

            

        }
    }
}
