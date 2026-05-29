

namespace PatiDostu_Otomasyon
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_form.SuspendLayout();
            this.pnl_topbar.SuspendLayout();
            this.SuspendLayout();

            
            this.pnl_topbar.BackColor = System.Drawing.Color.White;
            this.pnl_topbar.Controls.Add(this.lbl_header);
            this.pnl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topbar.Name = "pnl_topbar";
            this.pnl_topbar.Size = new System.Drawing.Size(1100, 60);
            this.pnl_topbar.TabIndex = 0;

            
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_header.Location = new System.Drawing.Point(20, 15);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Kategoriler";

            
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 158, 117);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.Location = new System.Drawing.Point(20, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(600, 400);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            
            this.pnl_form.BackColor = System.Drawing.Color.FromArgb(240, 248, 240);
            this.pnl_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_form.Controls.Add(this.lbl_title);
            this.pnl_form.Controls.Add(this.lbl_kategori);
            this.pnl_form.Controls.Add(this.txt_kategori);
            this.pnl_form.Controls.Add(this.btn_ekle);
            this.pnl_form.Controls.Add(this.btn_guncelle);
            this.pnl_form.Controls.Add(this.btn_sil);
            this.pnl_form.Controls.Add(this.btn_listele);
            this.pnl_form.Location = new System.Drawing.Point(640, 80);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(300, 280);
            this.pnl_form.TabIndex = 2;

            
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_title.Location = new System.Drawing.Point(10, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Kategori Bilgileri";

            
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Location = new System.Drawing.Point(10, 50);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.TabIndex = 1;
            this.lbl_kategori.Text = "Kategori Adı";

            
            this.txt_kategori.Location = new System.Drawing.Point(10, 70);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(260, 27);
            this.txt_kategori.TabIndex = 2;

            
            this.btn_ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(10, 120);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(120, 40);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);

            
            this.btn_guncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(140, 120);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(120, 40);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);

            
            this.btn_sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(10, 170);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(120, 40);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);

            
            this.btn_listele.BackColor = System.Drawing.Color.Gray;
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.Location = new System.Drawing.Point(140, 170);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(120, 40);
            this.btn_listele.TabIndex = 6;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnl_topbar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_form);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pati Dostu - Kategoriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.pnl_topbar.ResumeLayout(false);
            this.pnl_topbar.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Panel pnl_topbar;
        private System.Windows.Forms.Label lbl_header;
    }
}