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
    public partial class guncelle : Form
    { //  SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");


       SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public guncelle()
        {
            InitializeComponent();
        }

        public void goster(string veriler)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        private void guncelle_Load(object sender, EventArgs e)
        {
            goster("select *from mac");
            bilgi.Enabled = false;
            button1.Enabled = false;
            bilet.Enabled = false;
            kapasite.Enabled = false;
            kapasite.Enabled = false;
            tarihvesaat.Enabled = false;
            
            dataGridView1.ClearSelection();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bilgi.Enabled = true;
                button1.Enabled = true;
                
                bilet.Enabled = true;
                kapasite.Enabled = true;
                tarihvesaat.Enabled = true;

                
                int secilialan = dataGridView1.SelectedCells[0].RowIndex;

                string ligi = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
                string evi = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
                string depi = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
                string stadi = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
                string maclari = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
                string tarihi = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
                string saati = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
                object gkai = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
                string kkai = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();
                string maratoni = dataGridView1.Rows[secilialan].Cells[10].Value.ToString();
                string vipi = dataGridView1.Rows[secilialan].Cells[11].Value.ToString();
                string misafiri = dataGridView1.Rows[secilialan].Cells[12].Value.ToString();
                string k_gka = dataGridView1.Rows[secilialan].Cells[13].Value.ToString();
                string k_kka = dataGridView1.Rows[secilialan].Cells[14].Value.ToString();
                string k_maraton = dataGridView1.Rows[secilialan].Cells[15].Value.ToString();
                string k_vip = dataGridView1.Rows[secilialan].Cells[16].Value.ToString();
                string k_misafir = dataGridView1.Rows[secilialan].Cells[17].Value.ToString();

                label1.Text = ligi;
                label2.Text = evi;
                label3.Text = depi;
                label4.Text = stadi;
                //tarih.Value = Convert.ToDateTime(tarihi);
                //saat.Value = Convert.ToDateTime(saati);
                gka.Value = Convert.ToInt32(gkai);
                kka.Value = Convert.ToInt32(kkai);
                maraton.Value = Convert.ToInt32(maratoni);
                vip.Value = Convert.ToInt32(vipi);
                misafir.Value = Convert.ToInt32(misafiri);
                kgka.Value = Convert.ToInt32(k_gka);
                kkka.Value = Convert.ToInt32(k_kka);
                kmaraton.Value = Convert.ToInt32(k_maraton);
                kvip.Value = Convert.ToInt32(k_vip);
                kmisafir.Value = Convert.ToInt32(k_misafir);
            }
            catch (Exception)
            {
                
            }
            


        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut = new SqlCommand("update mac set tarih='" + tarih.Text + "', saat='" + saat.Text + "', gka='" + gka.Value.ToString() + "', kka='" + kka.Value.ToString() + "', maraton='" + maraton.Value.ToString() + "', vip='" + vip.Value.ToString() + "', misafir='" + misafir.Value.ToString() + "', gka_kapasite='" + kgka.Value.ToString() + "', kka_kapasite='" + kkka.Value.ToString() + "', maraton_kapasite='" + kmaraton.Value.ToString() + "', vip_kapasite='" + kvip.Value.ToString() + "', misafir_kapasite='" + kmisafir.Value.ToString() + "' where pkID=" + dataGridView1.CurrentRow.Cells[0].Value + "", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goster("select*from mac");
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }

        private void mAÇEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yoneticimacekle yeni = new yoneticimacekle();
            yeni.Show();
            this.Hide();
        }

        private void mAÇSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            macsil yeni = new macsil();
            yeni.Show();
            this.Hide();
        }

        
    }
}
