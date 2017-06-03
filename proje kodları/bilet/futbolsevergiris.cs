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
    public partial class futbolsevergiris : Form
    {
         //   SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");

         SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");
        public futbolsevergiris()
        {
            InitializeComponent();
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

        private void futbolsevergiris_Load(object sender, EventArgs e)
        {
            txt_kullaniciadi.Focus();
            btn_giris.Enabled = false;
        }

        private void lbl_yeni_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             yeniüye yeni = new yeniüye();
            yeni.Show();
            this.Hide();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            btn_giris.Enabled = true;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
             try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand sorgula = new SqlCommand("select pkID from sporsever where kullanici_adi='" + txt_kullaniciadi.Text + "'and kullanici_sifre='" + txt_sifre.Text + "'", baglanti);
                int gelenKullaniciID = Convert.ToInt32(sorgula.ExecuteScalar());
                SqlDataReader dr = sorgula.ExecuteReader();
                if (dr.Read())
                {
                    biletal yeni1 = new biletal();
                    yeni1.lbl_pkid.Text = gelenKullaniciID.ToString();
                    yeni1.Show();
                    this.Hide();
                    
                    dr.Close();
                }
                    
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!","Hatalı Giriş",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_kullaniciadi.Clear();
                    txt_sifre.Clear();
                    dr.Close();
                }

                baglanti.Close();
            }
            
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." +hata.Message);
            }
        

        }
        }
    }

