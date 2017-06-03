namespace bilet
{
    partial class yeniüye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeniüye));
            this.cb_takim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_lig = new System.Windows.Forms.ComboBox();
            this.txt_tekrarsifre = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gERİDÖNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gERİDÖNToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_takim
            // 
            this.cb_takim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_takim.FormattingEnabled = true;
            this.cb_takim.Location = new System.Drawing.Point(138, 189);
            this.cb_takim.Name = "cb_takim";
            this.cb_takim.Size = new System.Drawing.Size(132, 21);
            this.cb_takim.TabIndex = 12;
            this.cb_takim.SelectedIndexChanged += new System.EventHandler(this.cb_takim_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(78, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Takımınız:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(138, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "ÜYE OL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_lig
            // 
            this.cb_lig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lig.FormattingEnabled = true;
            this.cb_lig.Location = new System.Drawing.Point(138, 162);
            this.cb_lig.Name = "cb_lig";
            this.cb_lig.Size = new System.Drawing.Size(132, 21);
            this.cb_lig.TabIndex = 8;
            this.cb_lig.SelectedIndexChanged += new System.EventHandler(this.cb_lig_SelectedIndexChanged);
            // 
            // txt_tekrarsifre
            // 
            this.txt_tekrarsifre.Location = new System.Drawing.Point(138, 134);
            this.txt_tekrarsifre.Name = "txt_tekrarsifre";
            this.txt_tekrarsifre.PasswordChar = '*';
            this.txt_tekrarsifre.Size = new System.Drawing.Size(135, 20);
            this.txt_tekrarsifre.TabIndex = 7;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(138, 109);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(135, 20);
            this.txt_sifre.TabIndex = 6;
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Location = new System.Drawing.Point(138, 83);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(135, 20);
            this.txt_kullanici.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(71, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lig Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(67, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(101, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(65, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERİDÖNToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // gERİDÖNToolStripMenuItem
            // 
            this.gERİDÖNToolStripMenuItem.Image = global::bilet.Properties.Resources.back;
            this.gERİDÖNToolStripMenuItem.Name = "gERİDÖNToolStripMenuItem";
            this.gERİDÖNToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
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
            this.menuStrip1.TabIndex = 14;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bilet.Properties.Resources.favicon_2_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // yeniüye
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::bilet.Properties.Resources.üye_fw;
            this.ClientSize = new System.Drawing.Size(334, 272);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cb_takim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_lig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tekrarsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "yeniüye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ ÜYE";
            this.Load += new System.EventHandler(this.yeniüye_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_lig;
        private System.Windows.Forms.TextBox txt_tekrarsifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.ComboBox cb_takim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERİDÖNToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERİDÖNToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}