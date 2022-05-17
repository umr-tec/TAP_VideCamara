using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
//Agregar las librearias de Video
using AForge.Video;
using AForge.Video.DirectShow;
using BarcodeLib.BarcodeReader;

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
            //Guardar una foto tomada con la WebCam
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Imagen JPG |*.jpg";

            //mostrar el fileDialog
            fileDialog.ShowDialog();

            //Guarfdar la imagen
            if (fileDialog.FileName != null)
            {
                Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();
                img.Save(fileDialog.FileName, ImageFormat.Jpeg);
                img.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Por medio de la camara, leeer u QR o un BarCode
            if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
                Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
                string[] resultadoLEctura = BarcodeReader.read(img, BarcodeReader.QRCODE);
                img.Dispose();
                if (resultadoLEctura != null)
                {
                    textBox1.Text = resultadoLEctura[0];
                }
            }
        }

        private void btnLeerQR_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
