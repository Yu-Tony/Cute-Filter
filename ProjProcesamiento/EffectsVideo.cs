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
using Emgu.CV.UI;
using Emgu.CV.Structure;


namespace ProjProcesamiento
{
    public partial class EffectsVideo : Form
    {
        string video = " ";
        Timer My_Time = new Timer();
        int FPS = 40;
        Capture _capture = null;
        Bitmap bit;
        

        public EffectsVideo( string _video)
        {
            InitializeComponent();
            video = _video;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = @"Manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void EffectsVideo_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox9.Enabled = false;
            My_Time.Interval = 1000 / FPS;
        }



        /// <summary>
        /// NORMAL VIDEO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/29058980/emgu-cv-cant-play-video


                //Frame Rate
               
           
                My_Time.Tick += new EventHandler(My_Timer_Tick);
                My_Time.Start();

            if(_capture==null)
            {
                _capture = new Capture(video);
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox9.Enabled = true;
            }
                 
          

        }

        private void My_Timer_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = _capture.QueryFrame().ToBitmap();
        }

        /// <summary>
        /// BUTTON BINARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BinaryEffect(object sender, EventArgs e) 
        {
            bit = _capture.QueryFrame().ToBitmap();

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


            pictureBox1.Image = bit;
        }

        /// <summary>
        /// BUTTON GRAYSCALE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void GrayEffect(object sender, EventArgs e)
        {
            bit = _capture.QueryFrame().ToBitmap();

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


            //Image<Bgr, Byte> newImage = new Image<Bgr, Byte>(bit);

            pictureBox1.Image = bit;
        }

        /// <summary>
        /// BUTTON MEAN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MeanEffect(object sender, EventArgs e) 
        {
            bit = _capture.QueryFrame().ToBitmap();
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

            bit = temp;
            pictureBox1.Image = temp;
        }

        /// <summary>
        /// BUTTON SEPIA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SepiaEffect(object sender, EventArgs e)
        {
            bit = _capture.QueryFrame().ToBitmap();


            //get image dimension
            int width = bit.Width;
            int height = bit.Height;

            //color of pixel
            Color p;

            //sepia
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
                    bit.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            pictureBox1.Image = bit;
        }

        /// <summary>
        /// BUTTON NEGATIVE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

       private void NegativeEffect(object sender, EventArgs e)
        {
            Bitmap bmp = _capture.QueryFrame().ToBitmap();


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

            pictureBox1.Image = bmp;
        }



        private void EffectsVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                My_Time.Tick -= new EventHandler(My_Timer_Tick);
                My_Time.Tick += new EventHandler(BinaryEffect);
                My_Time.Start();
            }
            else if (checkBox1.Checked == false)
            {
                My_Time.Tick += new EventHandler(My_Timer_Tick);
                My_Time.Tick -= new EventHandler(BinaryEffect);
                My_Time.Start();

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                My_Time.Tick -= new EventHandler(My_Timer_Tick);
                My_Time.Tick += new EventHandler(GrayEffect);
                My_Time.Start();
            }
            else if (checkBox2.Checked == false)
            {
                My_Time.Tick += new EventHandler(My_Timer_Tick);
                My_Time.Tick -= new EventHandler(GrayEffect);
                My_Time.Start();

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                My_Time.Tick -= new EventHandler(My_Timer_Tick);
                My_Time.Tick += new EventHandler(MeanEffect);
                My_Time.Start();
            }
            else if (checkBox3.Checked == false)
            {
                My_Time.Tick += new EventHandler(My_Timer_Tick);
                My_Time.Tick -= new EventHandler(MeanEffect);
                My_Time.Start();

            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                My_Time.Tick -= new EventHandler(My_Timer_Tick);
                My_Time.Tick += new EventHandler(SepiaEffect);
                My_Time.Start();
            }
            else if (checkBox9.Checked == false)
            {
                My_Time.Tick += new EventHandler(My_Timer_Tick);
                My_Time.Tick -= new EventHandler(SepiaEffect);
                My_Time.Start();

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                My_Time.Tick -= new EventHandler(My_Timer_Tick);
                My_Time.Tick += new EventHandler(NegativeEffect);
                My_Time.Start();
            }
            else if (checkBox4.Checked == false)
            {
                My_Time.Tick += new EventHandler(My_Timer_Tick);
                My_Time.Tick -= new EventHandler(NegativeEffect);
                My_Time.Start();

            }
        }
    }
}
