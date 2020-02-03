namespace Lab3
{
    partial class labThreeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labThreeForm));
            this.calculateBtn = new System.Windows.Forms.Button();
            this.sphereRadiusLbl = new System.Windows.Forms.Label();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.surfaceAreaLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.sphereRadiusTxt = new System.Windows.Forms.TextBox();
            this.sphereDiameterLbl = new System.Windows.Forms.Label();
            this.sphereSurfaceAreaLbl = new System.Windows.Forms.Label();
            this.sphereVolumeLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(508, 169);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(168, 58);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // sphereRadiusLbl
            // 
            this.sphereRadiusLbl.AutoSize = true;
            this.sphereRadiusLbl.Location = new System.Drawing.Point(390, 129);
            this.sphereRadiusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sphereRadiusLbl.Name = "sphereRadiusLbl";
            this.sphereRadiusLbl.Size = new System.Drawing.Size(175, 25);
            this.sphereRadiusLbl.TabIndex = 1;
            this.sphereRadiusLbl.Text = "Radius of sphere";
            this.sphereRadiusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diameterLbl
            // 
            this.diameterLbl.Location = new System.Drawing.Point(22, 404);
            this.diameterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(98, 25);
            this.diameterLbl.TabIndex = 2;
            this.diameterLbl.Text = "Diameter";
            this.diameterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surfaceAreaLbl
            // 
            this.surfaceAreaLbl.AutoSize = true;
            this.surfaceAreaLbl.Location = new System.Drawing.Point(16, 512);
            this.surfaceAreaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surfaceAreaLbl.Name = "surfaceAreaLbl";
            this.surfaceAreaLbl.Size = new System.Drawing.Size(137, 25);
            this.surfaceAreaLbl.TabIndex = 3;
            this.surfaceAreaLbl.Text = "Surface Area";
            this.surfaceAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(22, 602);
            this.volumeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(84, 25);
            this.volumeLbl.TabIndex = 4;
            this.volumeLbl.Text = "Volume";
            this.volumeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sphereRadiusTxt
            // 
            this.sphereRadiusTxt.Location = new System.Drawing.Point(572, 123);
            this.sphereRadiusTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sphereRadiusTxt.Name = "sphereRadiusTxt";
            this.sphereRadiusTxt.Size = new System.Drawing.Size(100, 31);
            this.sphereRadiusTxt.TabIndex = 5;
            // 
            // sphereDiameterLbl
            // 
            this.sphereDiameterLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sphereDiameterLbl.Location = new System.Drawing.Point(196, 404);
            this.sphereDiameterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sphereDiameterLbl.Name = "sphereDiameterLbl";
            this.sphereDiameterLbl.Size = new System.Drawing.Size(140, 25);
            this.sphereDiameterLbl.TabIndex = 6;
            this.sphereDiameterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sphereSurfaceAreaLbl
            // 
            this.sphereSurfaceAreaLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sphereSurfaceAreaLbl.Location = new System.Drawing.Point(196, 512);
            this.sphereSurfaceAreaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sphereSurfaceAreaLbl.Name = "sphereSurfaceAreaLbl";
            this.sphereSurfaceAreaLbl.Size = new System.Drawing.Size(140, 25);
            this.sphereSurfaceAreaLbl.TabIndex = 7;
            this.sphereSurfaceAreaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sphereVolumeLbl
            // 
            this.sphereVolumeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sphereVolumeLbl.Location = new System.Drawing.Point(196, 602);
            this.sphereVolumeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sphereVolumeLbl.Name = "sphereVolumeLbl";
            this.sphereVolumeLbl.Size = new System.Drawing.Size(140, 25);
            this.sphereVolumeLbl.TabIndex = 8;
            this.sphereVolumeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(446, 385);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 288);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // labThreeForm
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(768, 694);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sphereVolumeLbl);
            this.Controls.Add(this.sphereSurfaceAreaLbl);
            this.Controls.Add(this.sphereDiameterLbl);
            this.Controls.Add(this.sphereRadiusTxt);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.surfaceAreaLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.sphereRadiusLbl);
            this.Controls.Add(this.calculateBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "labThreeForm";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label sphereRadiusLbl;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label surfaceAreaLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.TextBox sphereRadiusTxt;
        private System.Windows.Forms.Label sphereDiameterLbl;
        private System.Windows.Forms.Label sphereSurfaceAreaLbl;
        private System.Windows.Forms.Label sphereVolumeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

