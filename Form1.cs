using System;
using System.Windows.Forms;
//Agregar las librearias de Video
using AForge.Video;
using AForge.Video.DirectShow;

namespace TAPU2_Ejemplo2
{
    public partial class Form1 : Form
    {
        //Variables globales
        FilterInfoCollection filterInfo;
        //clase para usar la camara
        VideoCaptureDevice videoCapture;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Conocer los dispositivos de vide disponibles
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo infoCamaras in filterInfo)
            {
                cbVideoCamara.Items.Add(infoCamaras.Name);
            }
           
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            //Acceder a la camara
            videoCapture = new VideoCaptureDevice(filterInfo[cbVideoCamara.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = videoCapture;
            videoSourcePlayer1.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
