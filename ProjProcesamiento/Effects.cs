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

        private void checkBox1_CheckedChanged(object sender, EventArgs e, Image<Bgr, Byte> img)
        {
            //ref https://stackoverflow.com/questions/32507061/convert-gray-image-to-binary-image-0-1-image-in-c
            StringBuilder t = new StringBuilder();
            Bitmap bit = img.ToBitmap();
            for (int i = 0; i < bit.Width; i++)
            {
                for (int j = 0; j < bit.Height; j++)
                {
                    t.Append((bit.GetPixel(i, j).R > 100 && bit.GetPixel(i, j).G > 100 &&
                             bit.GetPixel(i, j).B > 100) ? 0 : 1);
                }
                t.AppendLine();
            }

            //Image<Bgr, Byte> newImage = 0;
            //imageBox1.Image = newImage;
        }
    }
}
