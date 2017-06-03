namespace bilet
{
    partial class kullaniciprofil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciprofil));
            this.lblgelenid = new System.Windows.Forms.Label();
            this.lbl_takim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.snl_bakiye = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_bkye = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çIKIŞToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bİLETALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kadi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgelenid
            // 
            this.lblgelenid.AutoSize = true;
            this.lblgelenid.Location = new System.Drawing.Point(145, 400);
            this.lblgelenid.Name = "lblgelenid";
            this.lblgelenid.Size = new System.Drawing.Size(18, 13);
            this.lblgelenid.TabIndex = 0;
            this.lblgelenid.Text = "id:";
            this.lblgelenid.Visible = false;
            // 
            // lbl_takim
            // 
            this.lbl_takim.AutoSize = true;
            this.lbl_takim.BackColor = System.Drawing.Color.Transparent;
            this.lbl_takim.Location = new System.Drawing.Point(145, 35);
            this.lbl_takim.Name = "lbl_takim";
            this.lbl_takim.Size = new System.Drawing.Size(45, 13);
            this.lbl_takim.TabIndex = 2;
            this.lbl_takim.Text = "takımım:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sanal Bakiye Ekle:";
            // 
            // snl_bakiye
            // 
            this.snl_bakiye.Location = new System.Drawing.Point(100, 42);
            this.snl_bakiye.Name = "snl_bakiye";
            this.snl_bakiye.Size = new System.Drawing.Size(108, 20);
            this.snl_bakiye.TabIndex = 4;
            this.snl_bakiye.TextChanged += new System.EventHandler(this.snl_bakiye_TextChanged);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_ekle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(214, 40);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 25);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bakiye.Location = new System.Drawing.Point(6, 23);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(77, 13);
            this.lbl_bakiye.TabIndex = 6;
            this.lbl_bakiye.Text = "Sanal Bakiyem";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(11, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 122);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lig";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Maç Tarihi";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Saat";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Maç";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Stadyum";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tribün";
            this.columnHeader6.Width = 77;
            // 
            // lbl_bkye
            // 
            this.lbl_bkye.AutoSize = true;
            this.lbl_bkye.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bkye.Location = new System.Drawing.Point(223, 340);
            this.lbl_bkye.Name = "lbl_bkye";
            this.lbl_bkye.Size = new System.Drawing.Size(35, 13);
            this.lbl_bkye.TabIndex = 7;
            this.lbl_bkye.Text = "label2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // çIKIŞToolStripMenuItem1
            // 
            this.çIKIŞToolStripMenuItem1.Image = global::bilet.Properties.Resources.icons_exit2_128;
            this.çIKIŞToolStripMenuItem1.Name = "çIKIŞToolStripMenuItem1";
            this.çIKIŞToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.çIKIŞToolStripMenuItem1.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem1.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem,
            this.bİLETALToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Image = global::bilet.Properties.Resources.icons_exit2_128;
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // bİLETALToolStripMenuItem
            // 
            this.bİLETALToolStripMenuItem.Image = global::bilet.Properties.Resources._1;
            this.bİLETALToolStripMenuItem.Name = "bİLETALToolStripMenuItem";
            this.bİLETALToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.bİLETALToolStripMenuItem.Text = "BİLET AL";
            this.bİLETALToolStripMenuItem.Click += new System.EventHandler(this.bİLETALToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::bilet.Properties.Resources.pro;
            this.pictureBox1.Location = new System.Drawing.Point(322, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_kadi
            // 
            this.lbl_kadi.AutoSize = true;
            this.lbl_kadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kadi.Location = new System.Drawing.Point(12, 35);
            this.lbl_kadi.Name = "lbl_kadi";
            this.lbl_kadi.Size = new System.Drawing.Size(73, 13);
            this.lbl_kadi.TabIndex = 1;
            this.lbl_kadi.Text = "kullanıcı adım:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.snl_bakiye);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_bakiye);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 79);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAKİYE";
            // 
            // kullaniciprofil
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::bilet.Properties.Resources.PROFİL23_fw;
            this.ClientSize = new System.Drawing.Size(440, 302);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_bkye);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_takim);
            this.Controls.Add(this.lbl_kadi);
            this.Controls.Add(this.lblgelenid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "kullaniciprofil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFİL";
            this.Load += new System.EventHandler(this.kullaniciprofil_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblgelenid;
        private System.Windows.Forms.Label lbl_takim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox snl_bakiye;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbl_bkye;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bİLETALToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kadi;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}