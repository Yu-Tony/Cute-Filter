using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjProcesamiento
{
    public partial class Effects : Form
    {
        Bitmap image;
        public Effects(Bitmap imagePar)
        {
            InitializeComponent();
            image = imagePar;
            pictureBox3.Image = image;
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
            if (sf.FileName != null)
            {
                //VARIABLE PARA LA IMAGE
                image.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                image.Dispose();

            }
        }

        private void Effects_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
