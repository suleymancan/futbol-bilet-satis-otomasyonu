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
    public partial class yeniüye : Form
    {
       //  SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");

               SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public yeniüye()
        {
            InitializeComponent();
        }

       
        public void liggetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("select lig_adı from lig", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_lig.Items.Add(dt.Rows[i]["lig_adı"]);
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        public void takimgetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
                cb_takim.Items.Clear();
                SqlDataAdapter da=new SqlDataAdapter("select takim_adi from lig Lig left outer join takim Takim on(Lig.pkID=Takim.ligID)where lig_adı='"+cb_lig.Text+"'",baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_takim.Items.Add(dt.Rows[i]["takim_adi"]);
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
       

        private void yeniüye_Load(object sender, EventArgs e)
        {
            txt_kullanici.Focus();
            liggetir();
            
            
            
        }

       
           

            
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_kullanici.Text!="" & txt_sifre.Text!="" & txt_tekrarsifre.Text!=""&cb_lig.SelectedItem!=null&cb_takim.SelectedItem!=null)
            {
 
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand sorgula = new SqlCommand("select * from sporsever where kullanici_adi='" + txt_kullanici.Text + "'", baglanti);
                SqlDataReader dr = sorgula.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Aynı isimde kullanıcı var!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_kullanici.Clear();
                    dr.Close();
                }
                else if (txt_sifre.Text == txt_tekrarsifre.Text)
                {
                    dr.Close();
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] photo = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo, 0, photo.Length);
                    SqlCommand komut = new SqlCommand("Insert into sporsever(kullanici_adi,kullanici_sifre,kullanici_futboltakim,kullanici_foto) values ('" + txt_kullanici.Text + "','" + txt_sifre.Text + "','" + cb_takim.SelectedItem.ToString() + "','"+photo+"')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı başarıyla eklendi!", "HOŞGELDİNİZ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    
                    futbolsevergiris yeni = new futbolsevergiris();
                    yeni.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Kullanıcı adı, şifre ve takım belirlediğinizden emin olunuz!", "BOŞ BIRAKILAMAZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void cb_lig_SelectedIndexChanged(object sender, EventArgs e)
        {
            takimgetir();
        }

        private void cb_takim_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void gERİDÖNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            futbolsevergiris yeni = new futbolsevergiris();
            yeni.Show();
            this.Hide();
        }

        private void gERİDÖNToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            futbolsevergiris yeni = new futbolsevergiris();
            yeni.Show();
            this.Hide();
        }



       


        
    }
}
