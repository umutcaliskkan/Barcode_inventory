using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluEnvanterKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for(int i = 0; i < panelControl1.Controls.Count; i++)
            {
                ((Form)panelControl1.Controls[0]).Close();
            }
            kasa ks = new kasa();
            ks.TopLevel = false;
            panelControl1.Controls.Add(ks);
            ks.BringToFront();
            ks.Show();



        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < panelControl1.Controls.Count; i++)
            {
                ((Form)panelControl1.Controls[0]).Close();
            }
            ekran ekran = new ekran();         // ekran formundan nesne oluşturuluyor
            ekran.TopLevel = false;           //
            panelControl1.Controls.Add(ekran); //panel kontrol ile ekran formunu ekle
            ekran.BringToFront();             //ekran formunu öne getir
            ekran.Show();                     //ekran formunu göster
        }

        private void btn_yaziciKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < panelControl1.Controls.Count; i++)
            {
                ((Form)panelControl1.Controls[0]).Close();
            }
            yazici yazici = new yazici();         // ekran formundan nesne oluşturuluyor
            yazici.TopLevel = false;           //
            panelControl1.Controls.Add(yazici); //panel kontrol ile ekran formunu ekle
            yazici.BringToFront();             //ekran formunu öne getir
            yazici.Show();                     //ekran formunu göster
        }

        private void btn_notebookKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < panelControl1.Controls.Count; i++)
            {
                ((Form)panelControl1.Controls[0]).Close();
            }
            notebook nb = new notebook();         // ekran formundan nesne oluşturuluyor
            nb.TopLevel = false;           //
            panelControl1.Controls.Add(nb); //panel kontrol ile ekran formunu ekle
            nb.BringToFront();             //ekran formunu öne getir
            nb.Show();                     //ekran formunu göster
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barkod brk = new barkod();
            brk.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            yardim yrd = new yardim();
            yrd.Show();
        }
    }
}
