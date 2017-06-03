namespace bilet
{
    partial class futbolsevergiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(futbolsevergiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_yeni = new System.Windows.Forms.LinkLabel();
            this.btn_giris = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gERİDÖNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gERİDÖNToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(77, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(113, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifreniz:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_sifre.ForeColor = System.Drawing.Color.Black;
            this.txt_sifre.Location = new System.Drawing.Point(164, 119);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(118, 20);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_kullaniciadi.ForeColor = System.Drawing.Color.Black;
            this.txt_kullaniciadi.Location = new System.Drawing.Point(164, 89);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(118, 20);
            this.txt_kullaniciadi.TabIndex = 2;
            // 
            // lbl_yeni
            // 
            this.lbl_yeni.AutoSize = true;
            this.lbl_yeni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yeni.LinkColor = System.Drawing.Color.DarkGreen;
            this.lbl_yeni.Location = new System.Drawing.Point(71, 156);
            this.lbl_yeni.Name = "lbl_yeni";
            this.lbl_yeni.Size = new System.Drawing.Size(86, 13);
            this.lbl_yeni.TabIndex = 5;
            this.lbl_yeni.TabStop = true;
            this.lbl_yeni.Text = "Yeni Futbolsever";
            this.lbl_yeni.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_yeni_LinkClicked);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_giris.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(164, 147);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(120, 30);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERİDÖNToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // gERİDÖNToolStripMenuItem
            // 
            this.gERİDÖNToolStripMenuItem.Image = global::bilet.Properties.Resources.back;
            this.gERİDÖNToolStripMenuItem.Name = "gERİDÖNToolStripMenuItem";
            this.gERİDÖNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gERİDÖNToolStripMenuItem.Text = "GERİ DÖN";
            this.gERİDÖNToolStripMenuItem.Click += new System.EventHandler(this.gERİDÖNToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERİDÖNToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gERİDÖNToolStripMenuItem1
            // 
            this.gERİDÖNToolStripMenuItem1.Image = global::bilet.Properties.Resources.back;
            this.gERİDÖNToolStripMenuItem1.Name = "gERİDÖNToolStripMenuItem1";
            this.gERİDÖNToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.gERİDÖNToolStripMenuItem1.Text = "GERİ DÖN";
            this.gERİDÖNToolStripMenuItem1.Click += new System.EventHandler(this.gERİDÖNToolStripMenuItem1_Click);
            // 
            // futbolsevergiris
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::bilet.Properties.Resources.fsgiris_fw;
            this.ClientSize = new System.Drawing.Size(334, 272);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_yeni);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "futbolsevergiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUTBOLSEVER GİRİŞ";
            this.Load += new System.EventHandler(this.futbolsevergiris_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.LinkLabel lbl_yeni;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERİDÖNToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERİDÖNToolStripMenuItem1;
    }
}