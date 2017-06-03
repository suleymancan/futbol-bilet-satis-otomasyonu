namespace bilet
{
    partial class macsil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(macsil));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pkid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çIKIŞToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAÇEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAÇSİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "pkID:";
            // 
            // txt_pkid
            // 
            this.txt_pkid.Location = new System.Drawing.Point(229, 44);
            this.txt_pkid.Name = "txt_pkid";
            this.txt_pkid.Size = new System.Drawing.Size(100, 20);
            this.txt_pkid.TabIndex = 1;
            this.txt_pkid.TextChanged += new System.EventHandler(this.txt_pkid_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(408, 234);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(335, 41);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 25);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // çIKIŞToolStripMenuItem2
            // 
            this.çIKIŞToolStripMenuItem2.Image = global::bilet.Properties.Resources.icons_exit2_128;
            this.çIKIŞToolStripMenuItem2.Name = "çIKIŞToolStripMenuItem2";
            this.çIKIŞToolStripMenuItem2.Size = new System.Drawing.Size(101, 22);
            this.çIKIŞToolStripMenuItem2.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem2.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem,
            this.mAÇEKLEToolStripMenuItem,
            this.mAÇSİLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 6;
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
            // mAÇEKLEToolStripMenuItem
            // 
            this.mAÇEKLEToolStripMenuItem.Image = global::bilet.Properties.Resources.add2;
            this.mAÇEKLEToolStripMenuItem.Name = "mAÇEKLEToolStripMenuItem";
            this.mAÇEKLEToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.mAÇEKLEToolStripMenuItem.Text = "MAÇ EKLE";
            this.mAÇEKLEToolStripMenuItem.Click += new System.EventHandler(this.mAÇEKLEToolStripMenuItem_Click);
            // 
            // mAÇSİLToolStripMenuItem
            // 
            this.mAÇSİLToolStripMenuItem.Image = global::bilet.Properties.Resources.Update_128;
            this.mAÇSİLToolStripMenuItem.Name = "mAÇSİLToolStripMenuItem";
            this.mAÇSİLToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mAÇSİLToolStripMenuItem.Text = "MAÇ GÜNCELLE";
            this.mAÇSİLToolStripMenuItem.Click += new System.EventHandler(this.mAÇSİLToolStripMenuItem_Click);
            // 
            // macsil
            // 
            this.AcceptButton = this.btn_sil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::bilet.Properties.Resources.sil2_fw;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_pkid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "macsil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAÇ SİL";
            this.Load += new System.EventHandler(this.macsil_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.macsil_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pkid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAÇEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAÇSİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem2;
    }
}