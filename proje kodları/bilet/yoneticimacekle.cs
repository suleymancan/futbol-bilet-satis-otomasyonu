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
    public partial class yoneticimacekle : Form
    {
         //  SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");

          SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public yoneticimacekle()
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
                cb_ev.Items.Clear();
                cb_dep.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select takim_adi from lig Lig left outer join takim Takim on(Lig.pkID=Takim.ligID)where lig_adı='" + cb_lig.Text + "'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_ev.Items.Add(dt.Rows[i]["takim_adi"]);
                    cb_dep.Items.Add(dt.Rows[i]["takim_adi"]);
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
        public void stadyumgetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                cb_stadyum.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select takim_stadyum from lig Lig left outer join takim Takim on(Lig.pkID=Takim.ligID)where lig_adı='" + cb_lig.Text + "'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_stadyum.Items.Add(dt.Rows[i]["takim_stadyum"]);

                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        private void yoneticianasayfa_Load(object sender, EventArgs e)
        {
            liggetir();
            bilet.Enabled = false;
            cb_ev.Enabled = false;
            cb_dep.Enabled = false;
            cb_stadyum.Enabled = false;
            tarihvesaat.Enabled = false;
            tribun.Enabled = false;
            kaydet.Enabled = false;


        }

        private void cb_lig_SelectedIndexChanged(object sender, EventArgs e)
        {

            takimgetir();
            stadyumgetir();
            cb_ev.Enabled = true;
            cb_dep.Enabled = true;
            cb_stadyum.Enabled = true;

        }
        public void temizleyelim()
        {
            cb_lig.SelectedItem = null;
            cb_ev.SelectedItem = null;
            cb_dep.SelectedItem = null;
            cb_stadyum.SelectedItem = null;
            gka.Value = 0;
            kka.Value = 0;
            maraton.Value = 0;
            vip.Value = 0;
            misafir.Value = 0;
            kgka.Value = 0;
            kkka.Value = 0;
            kmaraton.Value = 0;
            kvip.Value = 0;
            kmisafir.Value = 0;
            tarih.ResetText();
            saat.ResetText();
            cb_ev.Enabled = false;
            cb_dep.Enabled = false;
            cb_stadyum.Enabled = false;
            bilet.Enabled = false;
            tribun.Enabled = false;
            tarihvesaat.Enabled = false;
            kaydet.Enabled = false;

        }
     

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                if (cb_ev.SelectedItem != cb_dep.SelectedItem)
                {
                    SqlCommand komut = new SqlCommand("Insert into mac(lig_adi,ev_sahibi,deplasman,stadyum_adi,tarih,saat,gka,kka,maraton,vip,misafir,gka_kapasite,kka_kapasite,maraton_kapasite,vip_kapasite,misafir_kapasite) values ('" + cb_lig.SelectedItem.ToString() + "','" + cb_ev.SelectedItem.ToString() + "','" + cb_dep.SelectedItem.ToString() + "','" + cb_stadyum.SelectedItem.ToString() + "','" + tarih.Text + "','" + saat.Text + "'," + gka.Value.ToString() + "," + kka.Value.ToString() + "," + maraton.Value.ToString() + "," + vip.Value.ToString() + "," + misafir.Value.ToString() + "," + kgka.Value.ToString() + "," + kkka.Value.ToString() + "," + kmaraton.Value.ToString() + "," + kvip.Value.ToString() + "," + kmisafir.Value.ToString() + ")", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Maç başarıyla kaydedildi!", "Maç Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizleyelim();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Aynı takımlar birbiriyle maç yapamaz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            temizleyelim();
        }

        private void cb_stadyum_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarihvesaat.Enabled = true;
            tribun.Enabled = true;
        }



        private void tribun_Enter(object sender, EventArgs e)
        {
            bilet.Enabled = true;
        }

        private void bilet_Enter(object sender, EventArgs e)
        {
            kaydet.Enabled = true;
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }

        private void mAÇGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle yeni = new guncelle();
            yeni.Show();
            this.Hide();
        }

        private void mAÇSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            macsil yeni = new macsil();
            yeni.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }








    }
}
