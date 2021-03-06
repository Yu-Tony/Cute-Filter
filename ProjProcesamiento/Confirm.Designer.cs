
namespace ProjProcesamiento
{
    partial class Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNoUse = new System.Windows.Forms.Button();
            this.btnYesUse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnNoUse
            // 
            this.btnNoUse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoUse.BackgroundImage")));
            this.btnNoUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoUse.FlatAppearance.BorderSize = 0;
            this.btnNoUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoUse.Location = new System.Drawing.Point(171, 558);
            this.btnNoUse.Name = "btnNoUse";
            this.btnNoUse.Size = new System.Drawing.Size(106, 51);
            this.btnNoUse.TabIndex = 2;
            this.btnNoUse.UseVisualStyleBackColor = true;
            this.btnNoUse.Click += new System.EventHandler(this.btnNoUse_Click);
            // 
            // btnYesUse
            // 
            this.btnYesUse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYesUse.BackgroundImage")));
            this.btnYesUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYesUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYesUse.FlatAppearance.BorderSize = 0;
            this.btnYesUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesUse.Location = new System.Drawing.Point(171, 501);
            this.btnYesUse.Name = "btnYesUse";
            this.btnYesUse.Size = new System.Drawing.Size(106, 51);
            this.btnYesUse.TabIndex = 3;
            this.btnYesUse.UseVisualStyleBackColor = true;
            this.btnYesUse.Click += new System.EventHandler(this.btnYesUse_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(439, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(31, 46);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(426, 311);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYesUse);
            this.Controls.Add(this.btnNoUse);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick Your Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Confirm_FormClosing);
            this.Load += new System.EventHandler(this.Confirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNoUse;
        private System.Windows.Forms.Button btnYesUse;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}