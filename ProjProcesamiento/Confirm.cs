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

namespace ProjProcesamiento
{
    public partial class Confirm : Form
    {
        Image<Bgr, Byte> image;
        public Confirm(Image<Bgr, Byte> imagePar)
        {
            InitializeComponent();
            image = imagePar;
            imageBox1.Image = image;
        }

        private void btnYesUse_Click(object sender, EventArgs e)
        {
            
            Effects openForm = new Effects(image);
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"Manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnNoUse_Click(object sender, EventArgs e)
        {
            TakePic openForm = new TakePic();
            openForm.Show();
            Visible = false;
        }

        private void Confirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {

        }
    }
}
