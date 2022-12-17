using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NkatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_LISTELE_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource= PerList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
         
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txt_ad.Text;
            ent.Soyad = txt_soyad.Text;
            ent.Sehir = txt_sehir.Text;
            ent.Gorev = txt_gorev.Text;
            ent.Maas = short.Parse(txt_maas.Text);
            LogicPersonel.LLPersonelEkle(ent);

            MessageBox.Show("Personel Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent =new EntityPersonel();   
            ent.Id=Convert.ToInt32(txt_id.Text);    
            LogicPersonel.LLpersonelSil(ent.Id);

            MessageBox.Show("Personel Silindi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel gu = new EntityPersonel();
            gu.Id= Convert.ToInt32(txt_id.Text);
            gu.Ad = txt_ad.Text;
            gu.Soyad= txt_soyad.Text;
            gu.Sehir= txt_sehir.Text;
            gu.Gorev = txt_gorev.Text;
            gu.Maas= short.Parse(txt_maas.Text);

            LogicPersonel.LLpersonelguncelle(gu);

            MessageBox.Show("Personel Güncellendi");
        }

        
    }
}
