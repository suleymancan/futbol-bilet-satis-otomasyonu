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
    public partial class macsil : Form
    {
       
            //   SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");
   SqlConnection baglanti = new SqlConnection("Data Source=CAN-VAYOREBL;Initial Catalog=biletsatis;Integrated Security=True");

        public macsil()
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
        private void macsil_Load(object sender, EventArgs e)
        {
            txt_pkid.Focus();
            goster("select pkID,lig_adi,ev_sahibi,deplasman from mac");
            
                btn_sil.Enabled = false;
         
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from mac where pkID=@pkid",baglanti);
                komut.Parameters.AddWithValue("@pkid",Convert.ToInt32(txt_pkid.Text));
                komut.ExecuteNonQuery();
                goster("select pkID,lig_adi,ev_sahibi,deplasman from mac");
                txt_pkid.Text = "";
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

  

        private void txt_pkid_TextChanged(object sender, EventArgs e)
        {
            btn_sil.Enabled = true;
        }

        private void macsil_MouseClick(object sender, MouseEventArgs e)
        {
            txt_pkid.Text = "";
            btn_sil.Enabled = false;
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
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
            guncelle yeni = new guncelle();
            yeni.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }
    }
}
