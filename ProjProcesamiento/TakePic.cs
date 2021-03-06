using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using AForge.Imaging;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;

//Added haarcascades https://github.com/opencv/opencv/blob/master/data/haarcascades/haarcascade_frontalface_alt_tree.xml

namespace ProjProcesamiento
{
    public partial class TakePic : Form
    {
        /*-----------------------------------------VARIABLES----------------------------------*/
        /// <summary>
        /// IMAGEN DE COLOR
        /// </summary>
        Image<Bgr, Byte> currentFrame;
        /// <summary>
        /// VARIABLE QUE CAPTURA IMAGENES DE UNA CAMARA O ARCHIVO DE VIDEO
        /// </summary>
        Capture grabber;
        /// <summary>
        /// ALGORITMO DE DETECCION DE OBJETOS USADO PARA IDENTIFICAR ROSOTROS EN UNA IMAGEN O VIDEO
        /// </summary>
        HaarCascade face;
        /// <summary>
        /// IMAGEN GRIS
        /// </summary>
        Image<Gray, byte> gray = null;
        /// <summary>
        /// LISTA DE IMAGENES GRIS DE LAS PERSONAS
        /// </summary>
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        /// <summary>
        /// LISTA DE NOMBRES DE LAS PERSONAS GUARDADOS
        /// </summary>
        List<string> labels = new List<string>();
        /// <summary>
        /// LISTA DE NOMBRES A MOSTRAR EN EL LABEL4 "PERSONAS:"
        /// </summary>
        List<string> NamePersons = new List<string>();
        /// <summary>
        /// INT PARA CONTAR LOS ROSTROS QUE SE HAN GUARDADO
        /// </summary>
        int ContTrain, NumLabels, t;
        string name, names = null;
        Image<Gray, byte> result, TrainedFace = null;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);

        FilterInfoCollection filterInfoCollection;
        /*-----------------------------------------FUNCIONES----------------------------------*/
        public TakePic()
        {
            InitializeComponent();

            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
 
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TakePic_Load(object sender, EventArgs e)
        {
            btnStopCam.Enabled = false;

            //LISTAR DISPOSITIVOS DE ENTRADA
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cmboCameras.Items.Add(filterInfo.Name);
            }
            cmboCameras.SelectedIndex = 0;

        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {


            //Initialize the capture device
            grabber = new Capture(cmboCameras.SelectedIndex);
            //Initialize the capture device
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            btnStartCam.Enabled = false;
            btnStopCam.Enabled = true;

        }

        private void btnStopCam_Click(object sender, EventArgs e)
        {

            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
            grabber = null;
            imageBox1.Image = null;
            label3.Text = "0";
            label4.Text = "";
            btnStartCam.Enabled = true;
            btnStopCam.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox1.Text);

                /*//Show face added in gray scale
                imageBox1.Image = TrainedFace;*/

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                MessageBox.Show(textBox1.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTakePic_Click(object sender, EventArgs e)
        {
            currentFrame = grabber.QueryFrame().Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
            grabber = null;
            imageBox1.Image = null;
            label3.Text = "0";
            label4.Text = "";
            NamePersons.Add("");

            Confirm openForm = new Confirm(currentFrame);
            openForm.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"Manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }


        private void TakePic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            if (grabber != null)
            {
                grabber.Dispose();
                grabber = null;

            }
            imageBox1.Image = null;
            label3.Text = "0";
            label4.Text = "";

            System.Windows.Forms.Application.Exit();

        }

        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");


            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);

                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");


                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();


            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            //Show the faces procesed and recognized
            imageBox1.Image = currentFrame;
            label4.Text = names;
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }


    }
}
