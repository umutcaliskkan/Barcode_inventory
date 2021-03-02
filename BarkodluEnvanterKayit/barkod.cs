using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;


namespace BarkodluEnvanterKayit
{
    public partial class barkod : Form
    {
        public barkod()
        {
            InitializeComponent();
        }

        private void barkod_Load(object sender, EventArgs e)
        {

        }

       

        private void btn_Olustur_Click(object sender, EventArgs e)
        {
            string bilgi = txt_Olustur.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(bilgi); // bilgi degiskenini karekod olarak al
            pictureBox1.Image = qrcode as Image; //qrcode degiskeninini picturebox ta göster
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); // kaydetme diyalogu oluşturuyoruz
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp"; // jpg veya bmp olarak kayıt imkanı sağlıyoruz
            sfd.Title = "Kayıt"; //Diyalog Basligi
            sfd.FileName = "Karekod";

            DialogResult sonuc = sfd.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName); // kaydetme işlemi
            }
        }
    }
}
