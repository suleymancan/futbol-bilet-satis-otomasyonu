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
    public partial class biletal : Form
    {
        
           //   SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");
  SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public biletal()
        {
            InitializeComponent();
        }
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;


        public void macgetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                cb_maclar.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from mac", baglanti);
                SqlCommand komut = new SqlCommand("update mac set maclar=ev_sahibi+' - '+deplasman", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                da.Fill(dt);

                cb_maclar.DisplayMember = "maclar";
                cb_maclar.ValueMember = "pkID";
                cb_maclar.DataSource = dt;

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        public enum tribunIndex
        {
            GuneyKaleArka = 0,
            KuzeyKaleArka = 1,
            Maraton = 2,
            VIP = 3,
            Misafir = 4
        }

        public tribunIndex secilenTribun { get; set; }

        public void tribungetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                
                cb_tribun.Items.Clear();

                int secilenMacID = Convert.ToInt32(cb_maclar.SelectedValue.ToString());

                SqlCommand komut = new SqlCommand("Select *from mac where pkID = " + secilenMacID.ToString(), baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                   
                    cb_tribun.Items.Add("GÜNEY KALE ARKASI - boş koltuk sayısı:"+oku["gka_kapasite"].ToString());
                    cb_tribun.Items.Add("KUZEY KALE ARKASI -  boş koltuk sayısı:" + oku["kka_kapasite"].ToString());
                    cb_tribun.Items.Add("MARATON TRİBÜNÜ -  boş koltuk sayısı:" + oku["maraton_kapasite"].ToString());
                    cb_tribun.Items.Add("VİP TRİBÜNÜ - boş koltuk sayısı:" + oku["vip_kapasite"].ToString());
                    cb_tribun.Items.Add("MİSAFİR TRİBÜNÜ - boş koltuk sayısı:" + oku["misafir_kapasite"].ToString());
                }

                oku.Close();

                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
        public void tribungetir2()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                cb_tribun2.Items.Clear();

                int secilenMacID = Convert.ToInt32(cb_maclar.SelectedValue.ToString());

                SqlCommand komut = new SqlCommand("Select *from mac where pkID = " + secilenMacID.ToString(), baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    cb_tribun2.Items.Add(oku["gka_kapasite"].ToString());
                    cb_tribun2.Items.Add(oku["kka_kapasite"].ToString());
                    cb_tribun2.Items.Add(oku["maraton_kapasite"].ToString());
                    cb_tribun2.Items.Add(oku["vip_kapasite"].ToString());
                    cb_tribun2.Items.Add(oku["misafir_kapasite"].ToString());
                }

                oku.Close();

                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }


        public void biletgetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                cb_bilet.Items.Clear();

                int secilenMacID = Convert.ToInt32(cb_maclar.SelectedValue.ToString());

                SqlCommand komut = new SqlCommand("Select *from mac where pkID = " + secilenMacID.ToString(), baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    cb_bilet.Items.Add(oku["gka"].ToString());
                    cb_bilet.Items.Add(oku["kka"].ToString());
                    cb_bilet.Items.Add(oku["maraton"].ToString());
                    cb_bilet.Items.Add(oku["vip"].ToString());
                    cb_bilet.Items.Add(oku["misafir"].ToString());
                }

                oku.Close();

                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
       public void koltukdus()
        {
            
            try
            {
                
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                int secilenMacID = Convert.ToInt32(cb_maclar.SelectedValue.ToString());

                string updateSql = "";

                switch (secilenTribun)
                {
                    case tribunIndex.GuneyKaleArka:
                        updateSql = "update mac set gka_kapasite -= 1 where pkID = " + secilenMacID.ToString();
                        
                        break;
                    case tribunIndex.KuzeyKaleArka:
                        updateSql = "update mac set kka_kapasite -= 1 where pkID = " + secilenMacID.ToString();
                        break;
                    case tribunIndex.Maraton:
                        updateSql = "update mac set maraton_kapasite -= 1 where pkID = " + secilenMacID.ToString();
                        break;
                    case tribunIndex.VIP:
                        updateSql = "update mac set vip_kapasite -= 1 where pkID = " + secilenMacID.ToString();
                        break;
                    case tribunIndex.Misafir:
                        updateSql = "update mac set misafir_kapasite -= 1 where pkID = " + secilenMacID.ToString();
                        break;
                }

                SqlCommand kom = new SqlCommand(updateSql, baglanti);
                kom.ExecuteNonQuery();

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        public void bilgigetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                int secilenMacID = Convert.ToInt32(cb_maclar.SelectedValue.ToString());

                SqlCommand komut = new SqlCommand("Select *from mac where pkID = " + secilenMacID.ToString(), baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    labellig.Text = (oku["lig_adi"].ToString());
                    labeltarih.Text = (oku["tarih"].ToString());
                    labelsaat.Text = (oku["saat"].ToString());
                    labelstadyum.Text = (oku["stadyum_adi"].ToString());
                    labelgka.Text = ("Güney Kale Arkası: " + oku["gka"].ToString() + " TL");
                    labelkka.Text = ("Kuzey Kale Arkası: " + oku["kka"].ToString() + " TL");
                    labelmaraton.Text = ("Maraton: " + oku["maraton"].ToString() + " TL");
                    labelvip.Text = ("VİP: " + oku["vip"].ToString() + " TL");
                    labelmisafir.Text = ("Misafir: " + oku["misafir"].ToString() + " TL");
                    
                }
                oku.Close();
                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

      
        private void biletal_Load(object sender, EventArgs e)
        {
            
            btn_cek.Enabled = false;
            
            button1.Enabled = false;
            grb_foto.Enabled = false;
            bakiyegetir();
            macgetir();

            //kamera
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videocapturedevice in webcam)
            {
                camera_cb.Items.Add(videocapturedevice.Name);
            }
            camera_cb.SelectedIndex = 0;
            
            
        
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
                }
        private void cb_tribun_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenIndex = cb_tribun.SelectedIndex;
            secilenTribun = (tribunIndex)secilenIndex;
            grb_foto.Enabled = true;
            
            cb_bilet.SelectedIndex = cb_tribun.SelectedIndex;
            cb_tribun2.SelectedIndex = cb_tribun.SelectedIndex;
            cb_tribunadi.SelectedIndex = cb_tribun.SelectedIndex;
            if(Convert.ToInt32(cb_tribun2.SelectedItem)<=0)
            {
                MessageBox.Show("Tribün dolu! Lütfen başka bir tribün seçiniz.","DOLU",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }



        private void btn_ac_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
           
            
            cam = new VideoCaptureDevice(webcam[camera_cb.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame); //dikkat
            if (cam.IsRunning)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                cam.Start();
                pictureBox1.Visible = true;
            }
            btn_cek.Enabled = true;
        }


        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }

        private void btn_cek_Click(object sender, EventArgs e)
        {
           
            if(cam.IsRunning)
            {
                cam.Stop();
                pictureBox1.Visible = false;
            }
            menuStrip1.Visible = true;
            pictureBox2.Image = pictureBox1.Image;
            button1.Enabled = true;
        }
        

        
 

        private void bakiyegetir()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from sporsever where pkID=" + lbl_pkid.Text, baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label_bakiye.Text = (dr["kullanici_sanalbakiye"].ToString());
                    labelbakiye.Text = ("Mevcut sanal bakiyeniz: " + dr["kullanici_sanalbakiye"].ToString() + " TL");
                }
                dr.Close();
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
           

        private void button1_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            try
            {
              
                if(Convert.ToInt32(cb_bilet.SelectedItem)>Convert.ToInt32(label_bakiye.Text))
                {
                    MessageBox.Show("Bakiyeniz yetersiz! Profilinizden bakiye yükseltin!","BAKİYE YÜKSELT",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(Convert.ToInt32(cb_tribun2.SelectedItem)<=0)
                {
                    MessageBox.Show("BU TRİBÜN DOLU! Lütfen başka bir tribün seçiniz.","TRİBÜN DOLU",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if(cb_tribun.SelectedItem==null)
                {
                    MessageBox.Show("Lütfen tribün seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(pictureBox2==null)
                {
                    MessageBox.Show("Lütfen foto çekiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    çIKIŞToolStripMenuItem.Visible = true;
                    pROFİLToolStripMenuItem.Visible = true;
                    if (cam.IsRunning)
                    {
                        cam.Stop();
                    }
                    pictureBox1.Visible = false;
                    
                    
                    if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update sporsever set kullanici_bilet=@kbilet, kullanici_tribun=@ktribun, mac_tarih=@mtarih, mac_saat=@msaat, mac_lig=@mlig, mac_stadyum=@mstadyum, kullanici_sanalbakiye=@kbakiye, kullanici_foto=@image where pkID=" + lbl_pkid.Text, baglanti);
                    string a = cb_maclar.Text;
                    string b = cb_tribunadi.Text;
                    komut.Parameters.AddWithValue("@kbilet", a);
                    komut.Parameters.AddWithValue("@ktribun", b);
                    komut.Parameters.AddWithValue("@mtarih", labeltarih.Text);
                    komut.Parameters.AddWithValue("@msaat", labelsaat.Text);
                    komut.Parameters.AddWithValue("@mlig", labellig.Text);
                    komut.Parameters.AddWithValue("@mstadyum", labelstadyum.Text);
                    int biletfiyat = Convert.ToInt32(cb_bilet.SelectedItem);
                    int bakiye = Convert.ToInt32(label_bakiye.Text);
                    bakiye -= biletfiyat;
                    labelbakiye.Text = ("Mevcut Sanal Bakiyeniz: " + bakiye.ToString() + " TL");
                    label_bakiye.Text = bakiye.ToString();
                    komut.Parameters.AddWithValue("@kbakiye", label_bakiye.Text);
                    
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] byteData = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(byteData, 0, Convert.ToInt32(ms.Length));
                    SqlParameter parametre = new SqlParameter("@image", SqlDbType.Image, byteData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, byteData);
                    komut.Parameters.Add(parametre);
                    komut.ExecuteNonQuery();
                    SqlCommand kom = new SqlCommand("insert into kullanici_bilet(kullanici_id,kullanici_bilet,kullanici_foto,kullanici_tribun,kullanici_adi,mac_tarih,mac_saat,mac_lig,mac_stadyum)  select pkID, kullanici_bilet, kullanici_foto, kullanici_tribun, kullanici_adi, mac_tarih,mac_saat,mac_lig,mac_stadyum from sporsever where pkID="+lbl_pkid.Text,  baglanti);
                    kom.ExecuteNonQuery();
                    MessageBox.Show("Satın alma başarılı! Maç günü seçtiğiniz tribünden giriş yapabilirsiniz.","TEBRİKLER!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    baglanti.Close();
                    koltukdus();
                    tribungetir();
                    
                }
                    
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bilgigetir();

            tribungetir();
            
        }

        private void cb_maclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            grb_foto.Enabled = false;
            bilgigetir();

            tribungetir();
            tribungetir2();
            biletgetir();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {

                    futbolsevergiris yeni = new futbolsevergiris();
                    yeni.Show();
                    this.Hide();
                    
                }
            
                
            
            
        

        private void pROFİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
                    kullaniciprofil yeni = new kullaniciprofil();
                    yeni.lblgelenid.Text = lbl_pkid.Text;
                    yeni.Show();
                    this.Hide();
                
                
            
            
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            futbolsevergiris yeni = new futbolsevergiris();
            yeni.Show();
            this.Hide();
        }

        private void camera_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

     

       

   





       



    }
}
