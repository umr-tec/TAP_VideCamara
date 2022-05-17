
namespace TAPU2_Ejemplo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.cbVideoCamara = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLeerQR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.textBox1);
            this.gbOpciones.Controls.Add(this.btnLeerQR);
            this.gbOpciones.Controls.Add(this.btnDetener);
            this.gbOpciones.Controls.Add(this.btnFoto);
            this.gbOpciones.Controls.Add(this.btnCamara);
            this.gbOpciones.Controls.Add(this.cbVideoCamara);
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(667, 130);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // btnDetener
            // 
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("IBM Plex Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Image = global::TAPU2_Ejemplo2.Properties.Resources.stop_FILL0_wght400_GRAD0_opsz48;
            this.btnDetener.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetener.Location = new System.Drawing.Point(341, 63);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(99, 54);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Text = "Detener";
            this.btnDetener.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("IBM Plex Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Image = global::TAPU2_Ejemplo2.Properties.Resources.baseline_face_black_18dp;
            this.btnFoto.Location = new System.Drawing.Point(179, 63);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(88, 54);
            this.btnFoto.TabIndex = 2;
            this.btnFoto.Text = "Foto";
            this.btnFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnCamara
            // 
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.Font = new System.Drawing.Font("IBM Plex Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamara.Image = global::TAPU2_Ejemplo2.Properties.Resources.baseline_video_call_black_18dp;
            this.btnCamara.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCamara.Location = new System.Drawing.Point(6, 63);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(103, 54);
            this.btnCamara.TabIndex = 1;
            this.btnCamara.Text = "Iniciar";
            this.btnCamara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCamara.UseVisualStyleBackColor = true;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // cbVideoCamara
            // 
            this.cbVideoCamara.FormattingEnabled = true;
            this.cbVideoCamara.Location = new System.Drawing.Point(6, 21);
            this.cbVideoCamara.Name = "cbVideoCamara";
            this.cbVideoCamara.Size = new System.Drawing.Size(448, 24);
            this.cbVideoCamara.TabIndex = 0;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 148);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(667, 460);
            this.videoSourcePlayer1.TabIndex = 1;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLeerQR
            // 
            this.btnLeerQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerQR.Font = new System.Drawing.Font("IBM Plex Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerQR.Image = global::TAPU2_Ejemplo2.Properties.Resources.baseline_face_black_18dp;
            this.btnLeerQR.Location = new System.Drawing.Point(446, 63);
            this.btnLeerQR.Name = "btnLeerQR";
            this.btnLeerQR.Size = new System.Drawing.Size(88, 54);
            this.btnLeerQR.TabIndex = 4;
            this.btnLeerQR.Text = "Leer QR";
            this.btnLeerQR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeerQR.UseVisualStyleBackColor = true;
            this.btnLeerQR.Click += new System.EventHandler(this.btnLeerQR_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 620);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.gbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.ComboBox cbVideoCamara;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnFoto;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button btnLeerQR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

