using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Summary>
/// Info pictures <see href=" https://epochabuse.com/csharp-grayscale/">HERE</see>
///</Summary>


namespace ProjProcesamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            TakePic openForm = new TakePic();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           string filename = @"Manual.pdf";

           System.Diagnostics.Process.Start(filename);


        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
           

            openFileDialog1.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                Image<Bgr, Byte> image = new Image<Bgr, byte>(openFileDialog1.FileName);

                Effects openForm = new Effects(image);
                openForm.Show();
                Visible = false;
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
