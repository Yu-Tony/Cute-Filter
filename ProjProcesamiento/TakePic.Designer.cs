
namespace ProjProcesamiento
{
    partial class TakePic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakePic));
            this.label1 = new System.Windows.Forms.Label();
            this.cmboCameras = new System.Windows.Forms.ComboBox();
            this.btnStopCam = new System.Windows.Forms.Button();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.btnTakePic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camara:";
            // 
            // cmboCameras
            // 
            this.cmboCameras.FormattingEnabled = true;
            this.cmboCameras.Location = new System.Drawing.Point(74, 396);
            this.cmboCameras.Name = "cmboCameras";
            this.cmboCameras.Size = new System.Drawing.Size(121, 21);
            this.cmboCameras.TabIndex = 2;
            // 
            // btnStopCam
            // 
            this.btnStopCam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopCam.BackgroundImage")));
            this.btnStopCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopCam.FlatAppearance.BorderSize = 0;
            this.btnStopCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopCam.Location = new System.Drawing.Point(25, 486);
            this.btnStopCam.Name = "btnStopCam";
            this.btnStopCam.Size = new System.Drawing.Size(133, 63);
            this.btnStopCam.TabIndex = 3;
            this.btnStopCam.UseVisualStyleBackColor = true;
            this.btnStopCam.Click += new System.EventHandler(this.btnStopCam_Click);
            // 
            // btnStartCam
            // 
            this.btnStartCam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartCam.BackgroundImage")));
            this.btnStartCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCam.FlatAppearance.BorderSize = 0;
            this.btnStartCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCam.Location = new System.Drawing.Point(318, 486);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(133, 63);
            this.btnStartCam.TabIndex = 4;
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // btnTakePic
            // 
            this.btnTakePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTakePic.BackgroundImage")));
            this.btnTakePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakePic.FlatAppearance.BorderSize = 0;
            this.btnTakePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePic.Location = new System.Drawing.Point(199, 468);
            this.btnTakePic.Name = "btnTakePic";
            this.btnTakePic.Size = new System.Drawing.Size(77, 76);
            this.btnTakePic.TabIndex = 5;
            this.btnTakePic.UseVisualStyleBackColor = true;
            this.btnTakePic.Click += new System.EventHandler(this.btnTakePic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(287, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Detección de personas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(277, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detección de movimiento";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(410, 382);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(410, 423);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(439, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(25, 47);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(426, 311);
            this.videoSourcePlayer1.TabIndex = 13;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // TakePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTakePic);
            this.Controls.Add(this.btnStartCam);
            this.Controls.Add(this.btnStopCam);
            this.Controls.Add(this.cmboCameras);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TakePic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick Your Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TakePic_FormClosing);
            this.Load += new System.EventHandler(this.TakePic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboCameras;
        private System.Windows.Forms.Button btnStopCam;
        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.Button btnTakePic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
    }
}