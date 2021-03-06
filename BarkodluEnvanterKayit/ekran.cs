﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BarkodluEnvanterKayit
{
    public partial class ekran : Form
    {
        public ekran()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource3.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource4.FillAsync();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BCV2AJ1;Initial Catalog=BarkodEnvanterDB;Integrated Security=True");
        private void Btn_EkranKaydet_Click(object sender, EventArgs e)
        {
            //Sql konutlarıyla veritabanına veriler kaydediliyor
            SqlCommand komut = new SqlCommand("INSERT INTO tblekran(ekranmarka,ekranmodel,ekrandepartman,ekrankullanici,ekranbarkod) values (@p1,@p2,@p3,@p4,@p5) ", baglanti);

            //Textboxlarda yazılanlar parametrelere atanıp veritabanına kaydediliyor
            komut.Parameters.AddWithValue("@p1", Convert.ToString(txt_EkranMarka.Text));
            komut.Parameters.AddWithValue("@p2", Convert.ToString(txt_EkranModel.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToString(txt_EkranDepartman.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToString(txt_EkranKullanici.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToString(txt_EkranBarkod.Text));
          

            try//komutları çalıştırmayı dene
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgiler Veritabanına Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)//Eger hata varsa hata mesajını göster 
            {
                MessageBox.Show(ex.Message.ToString());
            }
            baglanti.Close();
        }

        private void Btn_EkranVeriCek_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("SELECT * FROM tblekran where ekranid=@ekranid", baglanti);//ekranid paramatresindeki degere göre verileri getir
            baglanti.Open();
            komut2.Parameters.AddWithValue("@ekranid", txt_Ekranid.Text);//txt ekranid de yazan veri alınıyor
            komut2.ExecuteNonQuery();
            SqlDataReader dr = komut2.ExecuteReader();//veri okuma işlemini başlat
            if (dr.Read())//okuma işlemini yap ve tablolardaki verileri sırayla textboxlara aktar
            {
                txt_EkranMarka.Text = dr["ekranmarka"].ToString();
                txt_EkranModel.Text = dr["ekranmodel"].ToString();
                txt_EkranDepartman.Text = dr["ekrandepartman"].ToString();
                txt_EkranKullanici.Text = dr["ekrankullanici"].ToString();
                txt_EkranBarkod.Text = dr["ekranbarkod"].ToString();
                
            }
            else // okuma işleminde hata olursa textboxlara bunları yazdır
            {
                txt_EkranMarka.Text = "Veri Çekilemedi";
                txt_EkranModel.Text = "Veri Çekilemedi";
                txt_EkranDepartman.Text = "Veri Çekilemedi";
                txt_EkranKullanici.Text = "Veri Çekilemedi";
                txt_EkranBarkod.Text = "Veri Çekilemedi";
                
            }
            baglanti.Close();
        }

        private void btn_EkranVeriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("UPDATE tblekran SET ekrandepartman=@ekrandepartman,ekrankullanici=@ekrankullanici,ekranbarkod=@ekranbarkod WHERE ekranid=@ekranid", baglanti);

            komut5.Parameters.AddWithValue("@ekranid", txt_Ekranid.Text);
            komut5.Parameters.AddWithValue("@ekrandepartman", txt_EkranDepartman.Text);
            komut5.Parameters.AddWithValue("@ekrankullanici", txt_EkranKullanici.Text);
            komut5.Parameters.AddWithValue("@ekranbarkod", txt_EkranBarkod.Text);

            MessageBox.Show("Güncelleme Başarıyla Tamamlandı.");
            komut5.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn_EkranVeriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("DELETE FROM tblekran WHERE ekranid=@ekranid", baglanti); // sql sorgu yazıldı
            komut4.Parameters.AddWithValue("ekranid", txt_Ekranid.Text); // kasa id textboxtan çekildi
            komut4.ExecuteNonQuery(); // komut çalıştırıldı
            SqlDataReader dr = komut4.ExecuteReader();
            MessageBox.Show("Veri Silme İşlemi Başarılı !!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
            txt_Ekranid.Text = "";
        }

        private void btn_TabloYenile_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM tblekran", baglanti);//sorgu yazıldı
            SqlDataAdapter da = new SqlDataAdapter(komut3);
            DataTable dt = new DataTable();
            da.Fill(dt);//veriler degiskenlere çekilip doldurma işlemi yapıldı
            gridC_Ekran.DataSource = dt; //datagrid e veriler dolduruldu
            baglanti.Close();
        }

        private void btn_FormYenile_Click(object sender, EventArgs e)
        {
            txt_EkranMarka.Text = " ";
            txt_EkranModel.Text = " ";
            txt_EkranDepartman.Text = " ";
            txt_EkranKullanici.Text = " ";
            txt_EkranBarkod.Text = " ";
            txt_Ekranid.Text = " ";
        }

        private void btn_EkranExcell_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls"; //xls dosyası oluştur
            sfd.FileName = "EkranVeriler.xls"; //dosya adı belirlendi
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridC_Ekran.ExportToXls(sfd.FileName);//tablodaki veriler komple export et
            }
        }
    }
}
