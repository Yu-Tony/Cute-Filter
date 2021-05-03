using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;

namespace ProjProcesamiento
{
    public partial class TakePic : Form
    {
        public TakePic()
        {
            InitializeComponent();
        }

        //AGREGAR LOS DISPOSITIVOS DE NETRADA DE VIDEO
        FilterInfoCollection filterInfoCollection;
        //VARIABLE PARA LA FUENTE DE VIDEO
        VideoCaptureDevice videoCaptureDevice;
        //VARIABLES PARA LA DETECCION
        MotionDetector Detector;
        bool pic = false;

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <description>CARGA LA PANTALLA</description>
        /// </item>
        /// <item>
        /// <description>CARGA TODAS LAS CAMARAS DISPONIBLES Y LAS MUESTRA EN UN COMBOBOX</description>
        /// </item>
        /// <item>
        /// <description>INICIALIZA EL MOTION DETECTOR http://www.aforgenet.com/framework/features/motion_detection_2.0.html
        ///</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TakePic_Load(object sender, EventArgs e)
        {
            //INICIALIZAR VARIABLE DETECTOR
            Detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());

            //LISTAR DISPOSITIVOS DE ENTRADA
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
            {
                cmboCameras.Items.Add(filterInfo.Name);
            }
            cmboCameras.SelectedIndex = 0;
           
        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            //ESTABLECER CAMARA QUE SE SELECCIONO
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmboCameras.SelectedIndex].MonikerString);
            //INICIALIZAR CONTROL
            videoSourcePlayer1.VideoSource = videoCaptureDevice;
            //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //INICIAR RECEPCION DE IMAGENES
            videoSourcePlayer1.Start();
                
        }


        private void TakePic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoSourcePlayer1.IsRunning==true)
            {
                videoSourcePlayer1.SignalToStop();
            }

            System.Windows.Forms.Application.Exit();

        }

        private void btnStopCam_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.IsRunning == true)
            {
                videoSourcePlayer1.SignalToStop();
            }
        }

        private void btnTakePic_Click(object sender, EventArgs e)
        {
            pic = true;
            TakePicture();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"Manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            if (pic == false)
                Detector.ProcessFrame(image);
            else
                Detector.Reset();
        }

        private async void TakePicture() 
        {
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            //VARIABLE PARA LA IMAGE
            Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();

            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }

            Confirm openForm = new Confirm(img);
            openForm.Show();
            Visible = false;
        }
    }
}
