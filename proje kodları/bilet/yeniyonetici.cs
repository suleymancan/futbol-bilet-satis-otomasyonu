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

namespace bilet
{

    public partial class yeniyonetici : Form
    {
        //  SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");

           SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public yeniyonetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_yonetici.Text!="" & txt_sifre.Text!="" & txt_tekrarsifre.Text!="")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    SqlCommand sorgula = new SqlCommand("select * from yonetici where yonetici_adi='" + txt_yonetici.Text + "'", baglanti);
                    SqlDataReader dr = sorgula.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Aynı kullanıcı adında yönetici var!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_yonetici.Clear();
                        dr.Close();
                    }
                    else if (txt_sifre.Text == txt_tekrarsifre.Text)
                    {
                        dr.Close();
                        SqlCommand komut = new SqlCommand("insert into yonetici(yonetici_adi,yonetici_sifre) values ('" + txt_yonetici.Text + "','" + txt_sifre.Text + "')", baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Yönetici başarıyla eklendi!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglanti.Close();
                        yöneticigiris yeni = new yöneticigiris();
                        yeni.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifreler aynı değil!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_sifre.Clear();
                        txt_tekrarsifre.Clear();
                        dr.Close();
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre belirlediğinizden emin olunuz!", "BOŞ BIRAKILAMAZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void yeniyonetici_Load(object sender, EventArgs e)
        {
            txt_yonetici.Focus();
            
        }

        private void txt_tekrarsifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gERİDÖNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }

        private void gERİDÖNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }

        private void txt_yonetici_TextChanged(object sender, EventArgs e)
        {

        }
    }

}