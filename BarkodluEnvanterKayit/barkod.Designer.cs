
namespace BarkodluEnvanterKayit
{
    partial class barkod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barkod));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_Olustur = new System.Windows.Forms.TextBox();
            this.btn_Olustur = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(389, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_Olustur
            // 
            this.txt_Olustur.Location = new System.Drawing.Point(209, 192);
            this.txt_Olustur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Olustur.Name = "txt_Olustur";
            this.txt_Olustur.Size = new System.Drawing.Size(149, 27);
            this.txt_Olustur.TabIndex = 2;
            // 
            // btn_Olustur
            // 
            this.btn_Olustur.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Olustur.Appearance.Options.UseFont = true;
            this.btn_Olustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Olustur.ImageOptions.Image")));
            this.btn_Olustur.Location = new System.Drawing.Point(29, 179);
            this.btn_Olustur.Name = "btn_Olustur";
            this.btn_Olustur.Size = new System.Drawing.Size(158, 50);
            this.btn_Olustur.TabIndex = 3;
            this.btn_Olustur.Text = "OLUŞTUR";
            this.btn_Olustur.Click += new System.EventHandler(this.btn_Olustur_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Appearance.Options.UseFont = true;
            this.btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.ImageOptions.Image")));
            this.btn_Kaydet.Location = new System.Drawing.Point(235, 409);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(235, 93);
            this.btn_Kaydet.TabIndex = 5;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // barkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 534);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Olustur);
            this.Controls.Add(this.txt_Olustur);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "barkod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BARKOD OLUŞTUR";
            this.Load += new System.EventHandler(this.barkod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_Olustur;
        private DevExpress.XtraEditors.SimpleButton btn_Olustur;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
    }
}