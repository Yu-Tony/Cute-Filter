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
                imageBox1.Image.Save(sf.FileName);
               

            }
        }

        private void Effects_FormClosing(object sender, FormClosingEventArgs e)
        {
            image.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// BINARY FILTER
        /// 
        /// Los pixeles que tengan un promedio de rgb arriba 127 se hacen negro
        /// Si no, se hacen blanco 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                //ref https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-grayscale-image-in-csharp-using-visual-studio
              
                Bitmap bit = image.ToBitmap();

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
                        if (avg > 127)
                            avg = 255;
                        else
                            avg = 0;

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

        /// <summary>
        /// GRAY LUMINANCE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Bitmap bit = image.ToBitmap();

                //get image dimension
                int width = bit.Width;
                int height = bit.Height;

                //color of pixel
                Color p;


                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        p = bit.GetPixel(x, y);

                        //extract pixel component ARGB
                        int a = p.A;
                        int r = (int)(p.R * 0.3);
                        int g = (int)(p.G * 0.59);
                        int b = (int)(p.B * 0.11);


                        int avg = (r + g + b);

                        //set new pixel value
                        bit.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                    }
                }


                Image<Bgr, Byte> newImage = new Image<Bgr, Byte>(bit);
                imageBox1.Image = newImage;

            }
            else if(checkBox2.Checked==false)
            {
                imageBox1.Image = image;
            }
        }

        /// <summary>
        /// FILTRO DE LA MEDIA
        /// Se visita cada píxel de la imagen y se reemplaza por la media de los píxeles vecinos.
        /// Se puede operar mediante convolución con una máscara determinada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Info https://stackoverflow.com/questions/42696560/why-is-an-image-needed-to-be-converted-into-greyscale-before-passed-to-median-fi
            if (checkBox3.Checked)
            {

                Bitmap bit = image.ToBitmap();
                Bitmap temp = new Bitmap(bit.Width, bit.Height);

                Color c;
                float sum = 0;
        
                //Median
                for (int i = 0; i <= bit.Width - 3; i++)
                {
                    for (int j = 0; j <= bit.Height - 3; j++)
                    {
    
                        for (int x = i; x <= i + 2; x++)
                        {  
                            for (int y = j; y <= j + 2; y++)
                            {
                                c = bit.GetPixel(x, y);
                                sum = sum + c.R;
                            }
                        }
                          
                        int color = (int)Math.Round(sum / 9, 10);
                        temp.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                        sum = 0;
                    }
                }
                  
          
                Image<Bgr, Byte> newImage = new Image<Bgr, Byte>(temp);
                imageBox1.Image = newImage;

            }
            else if(checkBox3.Checked==false)
            {
                imageBox1.Image = image;
            }

        }

        /// <summary>
        /// Filtro sepia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            //https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-sepia-image-in-csharp-using-visual-studio
            if (checkBox9.Checked)
            {
                Bitmap bmp = image.ToBitmap();


                //get image dimension
                int width = bmp.Width;
                int height = bmp.Height;

                //color of pixel
                Color p;

                //sepia
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        p = bmp.GetPixel(x, y);

                        //extract pixel component ARGB
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        //calculate temp value
                        int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                        //set new RGB value
                        if (tr > 255)
                        {
                            r = 255;
                        }
                        else
                        {
                            r = tr;
                        }

                        if (tg > 255)
                        {
                            g = 255;
                        }
                        else
                        {
                            g = tg;
                        }

                        if (tb > 255)
                        {
                            b = 255;
                        }
                        else
                        {
                            b = tb;
                        }

                        //set the new RGB value in image pixel
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

                Image<Bgr, Byte> newImage = new Image<Bgr, Byte>(bmp);
                imageBox1.Image = newImage;

            }
            else if (checkBox9.Checked == false)
            {
                imageBox1.Image = image;
            }
        }

        /// <summary>
        /// FILTRO NEGATIVO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-a-negative-image-in-csharp-using-visual-studio
            if (checkBox4.Checked)
            {
                Bitmap bmp = image.ToBitmap();


                //get image dimension
                int width = bmp.Width;
                int height = bmp.Height;

                //negative
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        Color p = bmp.GetPixel(x, y);

                        //extract ARGB value from p
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        //find negative value
                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        //set new ARGB value in pixel
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

                Image<Bgr, Byte> newImage = new Image<Bgr, Byte>(bmp);
                imageBox1.Image = newImage;

            }
            else if (checkBox4.Checked == false)
            {
                imageBox1.Image = image;
            }
        }
    }
}
