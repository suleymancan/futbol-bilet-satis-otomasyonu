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
    public partial class ilk : Form
    {
       //  SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\biletsatis.mdf'");

        public ilk()
        {
            InitializeComponent();
        }

        private void btn_fgiris_Click(object sender, EventArgs e)
        {
            futbolsevergiris yeni = new futbolsevergiris();
            yeni.Show();
            this.Hide();
        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            yöneticigiris yeni = new yöneticigiris();
            yeni.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ilk_Load(object sender, EventArgs e)
        {

        }

 
    }
}
