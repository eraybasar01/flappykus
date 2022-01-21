namespace flappykus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.Zaman = new System.Windows.Forms.Timer(this.components);
            this.Kus = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.Yer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yer)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(-2, 368);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(60, 22);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Skor: 0";
            // 
            // Zaman
            // 
            this.Zaman.Enabled = true;
            this.Zaman.Interval = 20;
            this.Zaman.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Kus
            // 
            this.Kus.Image = ((System.Drawing.Image)(resources.GetObject("Kus.Image")));
            this.Kus.Location = new System.Drawing.Point(15, 86);
            this.Kus.Name = "Kus";
            this.Kus.Size = new System.Drawing.Size(43, 50);
            this.Kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kus.TabIndex = 6;
            this.Kus.TabStop = false;
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(279, 2);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(75, 116);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 7;
            this.BoruUst.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(233, 272);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(69, 93);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 8;
            this.BoruAlt.TabStop = false;
            // 
            // Yer
            // 
            this.Yer.Image = ((System.Drawing.Image)(resources.GetObject("Yer.Image")));
            this.Yer.Location = new System.Drawing.Point(-2, 338);
            this.Yer.Name = "Yer";
            this.Yer.Size = new System.Drawing.Size(372, 27);
            this.Yer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Yer.TabIndex = 9;
            this.Yer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 386);
            this.Controls.Add(this.Yer);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.BoruUst);
            this.Controls.Add(this.Kus);
            this.Controls.Add(this.scoreText);
            this.Name = "Form1";
            this.Text = "oyun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label scoreText;
        private System.Windows.Forms.Timer Zaman;
        private PictureBox Kus;
        private PictureBox BoruUst;
        private PictureBox BoruAlt;
        private PictureBox Yer;
    }
}