namespace bilet
{
    partial class ilk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ilk));
            this.btn_fgiris = new System.Windows.Forms.Button();
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fgiris
            // 
            this.btn_fgiris.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_fgiris.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fgiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_fgiris.Location = new System.Drawing.Point(289, 346);
            this.btn_fgiris.Name = "btn_fgiris";
            this.btn_fgiris.Size = new System.Drawing.Size(200, 40);
            this.btn_fgiris.TabIndex = 3;
            this.btn_fgiris.Text = "FUTBOLSEVER";
            this.btn_fgiris.UseVisualStyleBackColor = false;
            this.btn_fgiris.Click += new System.EventHandler(this.btn_fgiris_Click);
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_yonetici.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btn_yonetici.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_yonetici.Location = new System.Drawing.Point(49, 346);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(202, 40);
            this.btn_yonetici.TabIndex = 4;
            this.btn_yonetici.Text = "YÖNETİCİ GİRİŞ";
            this.btn_yonetici.UseVisualStyleBackColor = false;
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Image = global::bilet.Properties.Resources.icons_exit2_128;
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // ilk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::bilet.Properties.Resources.ilkgiriss1;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_fgiris);
            this.Controls.Add(this.btn_yonetici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ilk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFF BİLET SATIŞ OTOMASYONU";
            this.Load += new System.EventHandler(this.ilk_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fgiris;
        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;

    }
}