using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;
namespace bilet
{
    public partial class yöneticigiris : Form
    {
        //   SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");
            SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public yöneticigiris()
        {

            InitializeComponent();
        }

        private void lbl_giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            futbolsevergiris yeni = new futbolsevergiris();
            yeni.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand sorgula = new SqlCommand("select * from yonetici where yonetici_adi='" + txt_yonetici.Text + "'and yonetici_sifre='" + txt_sifre.Text + "'", baglanti);
                SqlDataReader dr = sorgula.ExecuteReader();
                if (dr.Read())
                {
                    yoneticimacekle yeni = new yoneticimacekle();
                    yeni.Show();
                    this.Hide();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_yonetici.Clear();
                    txt_sifre.Clear();
                    dr.Close();
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void lbl_yeniyonetici_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yeniyonetici yeni = new yeniyonetici();
            yeni.Show();
            this.Hide();
            
        }

        private void yöneticigiris_Load(object sender, EventArgs e)
        {
           
            btn_giris.Enabled = false;
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            btn_giris.Enabled = true;
        }

        private void gERİDÖNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilk yeni = new ilk();
            yeni.Show();
            this.Hide();
        }

        private void gERİDÖNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ilk yeni = new ilk();
            yeni.Show();
            this.Hide();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yöneticigiris_Shown(object sender, EventArgs e)
        {
           txt_yonetici.Focus();
        }

        private void yöneticigiris_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bilgi = "Bu ekrandan yeni yönetici link labelina tıklayarak yeni yönetici formuna gidilebilir. \n Menü strip veya context menu strip sayesinde alılış ekranina geri dönebilirsiniz. \n Kullanici adı ve şifre textboxuna yanlış bilgi verildiğinde program uyari mesaji vermekte ve textboxun içeriği temizlenmektedir. Kullanici adi ve sifre sql veritabaninda dbo.yonetici tablosunda depolanmaktadir. \n Yönetici kisminda deneme yapmanız için kullanıcı adı: admin, şifre: 123 olan bir yönetici hesabı oluşturulmuştur.";
            MessageBox.Show(bilgi);
        }



        
    }
}
