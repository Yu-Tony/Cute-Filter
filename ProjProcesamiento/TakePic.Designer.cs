
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakePic));
            this.label1 = new System.Windows.Forms.Label();
            this.cmboCameras = new System.Windows.Forms.ComboBox();
            this.btnStopCam = new System.Windows.Forms.Button();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.btnTakePic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camara:";
            // 
            // cmboCameras
            // 
            this.cmboCameras.FormattingEnabled = true;
            this.cmboCameras.Location = new System.Drawing.Point(72, 374);
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
            this.label2.Location = new System.Drawing.Point(252, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de personas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(365, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(431, 374);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(312, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(252, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Personas:";
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(25, 47);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(426, 311);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Etiquetar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(185, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TakePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}