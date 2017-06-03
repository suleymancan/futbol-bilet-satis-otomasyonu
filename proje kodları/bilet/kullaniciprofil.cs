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
using System.IO;
using System.Drawing.Imaging;

namespace bilet
{
    public partial class kullaniciprofil : Form
    {

        //   SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");
           SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public kullaniciprofil()
        {
            InitializeComponent();
        }

        public void fotogetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from sporsever where pkID=" + lblgelenid.Text, baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    byte[] data = dr["kullanici_foto"] as byte[];
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ms.Write(data, 0, data.Length);
                        Image img = Image.FromStream(ms);
                        pictureBox1.Image = img;
                    }
                }
                dr.Close();
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
       
        private void kullaniciprofil_Load(object sender, EventArgs e)
        {
            btn_ekle.Enabled = false;
           
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from sporsever where pkID =" + lblgelenid.Text, baglanti);
                
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_kadi.Text = ("Kullanıcı Adım: " + dr["kullanici_adi"].ToString());
                    lbl_takim.Text = ("Takımım: "+dr["kullanici_futboltakim"].ToString());
                    lbl_bakiye.Text = ("Mevcut sanal bakiyeniz: " + dr["kullanici_sanalbakiye"].ToString() + " TL");
                    lbl_bkye.Text = dr["kullanici_sanalbakiye"].ToString();
                }
                dr.Close();
                baglanti.Close();
                if(Convert.ToInt32(lbl_bkye.Text)==0)
                {
                    
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    
                    SqlCommand komut = new SqlCommand("select * from kullanici_bilet where kullanici_id=" + lblgelenid.Text, baglanti);
                    SqlDataReader dr2 = komut.ExecuteReader();
                    while (dr2.Read())
                    {
                        ListViewItem item = new ListViewItem(dr2["mac_lig"].ToString());
                        item.SubItems.Add(dr2["mac_tarih"].ToString());
                        item.SubItems.Add(dr2["mac_saat"].ToString());
                        item.SubItems.Add(dr2["kullanici_bilet"].ToString());
                        item.SubItems.Add(dr2["mac_stadyum"].ToString());
                        item.SubItems.Add(dr2["kullanici_tribun"].ToString());

                        listView1.Items.Add(item);
                       
                    }
                    dr2.Close();
                    baglanti.Close();

                    if (listView1.Items.Count != 0)
                    {
                        fotogetir();
                    }
                        
                }
                 
                else
                {
                    
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from kullanici_bilet where kullanici_id=" + lblgelenid.Text, baglanti);
                    SqlDataReader dr2 = komut.ExecuteReader();
                    while (dr2.Read())
                    {
                        ListViewItem item = new ListViewItem(dr2["mac_lig"].ToString());
                        item.SubItems.Add(dr2["mac_tarih"].ToString());
                        item.SubItems.Add(dr2["mac_saat"].ToString());
                        item.SubItems.Add(dr2["kullanici_bilet"].ToString());
                        item.SubItems.Add(dr2["mac_stadyum"].ToString());
                        item.SubItems.Add(dr2["kullanici_tribun"].ToString());

                        listView1.Items.Add(item);
                    }
                    dr2.Close();
                    baglanti.Close();
                    if (listView1.Items.Count != 0)
                    {
                        fotogetir();
                    }
                }

                
               
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

           
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_bkye.Visible = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update sporsever set kullanici_sanalbakiye=@kbakiye  where pkID="+lblgelenid.Text, baglanti);
                int a=Convert.ToInt32(lbl_bkye.Text);
                int b = Convert.ToInt32(snl_bakiye.Text);
                int c = Convert.ToInt32(a) +Convert.ToInt32(b);
                lbl_bkye.Text = c.ToString();
                komut.Parameters.AddWithValue("@kbakiye", lbl_bkye.Text);
                MessageBox.Show("Sanal bakiye ekleme başarılı!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                snl_bakiye.Text = "";
                lbl_bakiye.Text = ("Mevcut sanal bakiyeniz: " + c.ToString() + " TL");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
         

        private void snl_bakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            futbolsevergiris yeni = new futbolsevergiris();
            yeni.Show();
            this.Hide();
        }

        private void bİLETALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            biletal yeni = new biletal();
            yeni.lbl_pkid.Text = lblgelenid.Text;
            yeni.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            futbolsevergiris yeni = new futbolsevergiris();
            yeni.Show();
            this.Hide();
        }

        private void snl_bakiye_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text))
            {
                btn_ekle.Enabled = false;
            }
            else
            {
                btn_ekle.Enabled = true;
            }
        }

       








      

      






    }
}

