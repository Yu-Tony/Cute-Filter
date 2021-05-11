
namespace ProjProcesamiento
{
    partial class Effects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Effects));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDiscardChngs = new System.Windows.Forms.Button();
            this.btnSaveChngs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(38, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(260, 28);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(103, 17);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Text = "Escala de grises";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(260, 51);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(76, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Suavizado";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(55, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Media";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Luminancia en grises";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Binario";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnDiscardChngs
            // 
            this.btnDiscardChngs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiscardChngs.BackgroundImage")));
            this.btnDiscardChngs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiscardChngs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscardChngs.FlatAppearance.BorderSize = 0;
            this.btnDiscardChngs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscardChngs.Location = new System.Drawing.Point(34, 591);
            this.btnDiscardChngs.Name = "btnDiscardChngs";
            this.btnDiscardChngs.Size = new System.Drawing.Size(173, 48);
            this.btnDiscardChngs.TabIndex = 2;
            this.btnDiscardChngs.UseVisualStyleBackColor = true;
            // 
            // btnSaveChngs
            // 
            this.btnSaveChngs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveChngs.BackgroundImage")));
            this.btnSaveChngs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveChngs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChngs.FlatAppearance.BorderSize = 0;
            this.btnSaveChngs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChngs.Location = new System.Drawing.Point(262, 591);
            this.btnSaveChngs.Name = "btnSaveChngs";
            this.btnSaveChngs.Size = new System.Drawing.Size(173, 48);
            this.btnSaveChngs.TabIndex = 3;
            this.btnSaveChngs.UseVisualStyleBackColor = true;
            this.btnSaveChngs.Click += new System.EventHandler(this.btnSaveChngs_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(440, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(34, 46);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(426, 311);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Effects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveChngs);
            this.Controls.Add(this.btnDiscardChngs);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Effects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick Your Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Effects_FormClosing);
            this.Load += new System.EventHandler(this.Effects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDiscardChngs;
        private System.Windows.Forms.Button btnSaveChngs;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}