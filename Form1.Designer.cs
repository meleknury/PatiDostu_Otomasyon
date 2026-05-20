namespace PatiDostu_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.btn_nav_hayvanlar = new System.Windows.Forms.Button();
            this.btn_nav_gonulluler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nav_kategoriler = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.lbl_form_title = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.lbl_yas = new System.Windows.Forms.Label();
            this.lbl_bolge = new System.Windows.Forms.Label();
            this.txt_bolge = new System.Windows.Forms.TextBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.pnl_topbar.SuspendLayout();
            this.pnl_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.White;
            this.pnl_sidebar.Controls.Add(this.btn_nav_kategoriler);
            this.pnl_sidebar.Controls.Add(this.button1);
            this.pnl_sidebar.Controls.Add(this.btn_nav_gonulluler);
            this.pnl_sidebar.Controls.Add(this.btn_nav_hayvanlar);
            this.pnl_sidebar.Controls.Add(this.lbl_subtitle);
            this.pnl_sidebar.Controls.Add(this.lbl_logo);
            this.pnl_sidebar.Controls.Add(this.pic_logo);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(200, 791);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(68, 20);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(64, 64);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_logo.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_logo.Location = new System.Drawing.Point(50, 90);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(111, 28);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "Pati Dostu";
            // 
            // lbl_subtitle
            // 
            this.lbl_subtitle.AutoSize = true;
            this.lbl_subtitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subtitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_subtitle.Location = new System.Drawing.Point(35, 115);
            this.lbl_subtitle.Name = "lbl_subtitle";
            this.lbl_subtitle.Size = new System.Drawing.Size(140, 17);
            this.lbl_subtitle.TabIndex = 2;
            this.lbl_subtitle.Text = "Sokak Hayvanları Takip";
            // 
            // btn_nav_hayvanlar
            // 
            this.btn_nav_hayvanlar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_nav_hayvanlar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_nav_hayvanlar.ForeColor = System.Drawing.Color.White;
            this.btn_nav_hayvanlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_hayvanlar.Location = new System.Drawing.Point(10, 150);
            this.btn_nav_hayvanlar.Name = "btn_nav_hayvanlar";
            this.btn_nav_hayvanlar.Size = new System.Drawing.Size(180, 45);
            this.btn_nav_hayvanlar.TabIndex = 3;
            this.btn_nav_hayvanlar.Text = "Hayvanlar";
            this.btn_nav_hayvanlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nav_hayvanlar.UseVisualStyleBackColor = false;
            // 
            // btn_nav_gonulluler
            // 
            this.btn_nav_gonulluler.BackColor = System.Drawing.Color.Gray;
            this.btn_nav_gonulluler.ForeColor = System.Drawing.Color.White;
            this.btn_nav_gonulluler.Location = new System.Drawing.Point(10, 200);
            this.btn_nav_gonulluler.Name = "btn_nav_gonulluler";
            this.btn_nav_gonulluler.Size = new System.Drawing.Size(180, 45);
            this.btn_nav_gonulluler.TabIndex = 4;
            this.btn_nav_gonulluler.Text = "Gönüllüler";
            this.btn_nav_gonulluler.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bakım Kayıtları";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_nav_kategoriler
            // 
            this.btn_nav_kategoriler.BackColor = System.Drawing.Color.Gray;
            this.btn_nav_kategoriler.ForeColor = System.Drawing.Color.White;
            this.btn_nav_kategoriler.Location = new System.Drawing.Point(10, 300);
            this.btn_nav_kategoriler.Name = "btn_nav_kategoriler";
            this.btn_nav_kategoriler.Size = new System.Drawing.Size(180, 45);
            this.btn_nav_kategoriler.TabIndex = 6;
            this.btn_nav_kategoriler.Text = "Kategoriler";
            this.btn_nav_kategoriler.UseVisualStyleBackColor = false;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_content);
            this.pnl_main.Controls.Add(this.pnl_topbar);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(200, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(882, 791);
            this.pnl_main.TabIndex = 1;
            // 
            // pnl_topbar
            // 
            this.pnl_topbar.BackColor = System.Drawing.Color.White;
            this.pnl_topbar.Controls.Add(this.lbl_title);
            this.pnl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topbar.Name = "pnl_topbar";
            this.pnl_topbar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnl_topbar.Size = new System.Drawing.Size(882, 60);
            this.pnl_topbar.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_title.Location = new System.Drawing.Point(20, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 31);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Hayvan Yönetimi ";
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.pnl_form);
            this.pnl_content.Controls.Add(this.dataGridView1);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 60);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_content.Size = new System.Drawing.Size(882, 731);
            this.pnl_content.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnl_form
            // 
            this.pnl_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_form.Controls.Add(this.btn_listele);
            this.pnl_form.Controls.Add(this.btn_sil);
            this.pnl_form.Controls.Add(this.btn_guncelle);
            this.pnl_form.Controls.Add(this.btn_ekle);
            this.pnl_form.Controls.Add(this.cmb_kategori);
            this.pnl_form.Controls.Add(this.lbl_kategori);
            this.pnl_form.Controls.Add(this.txt_bolge);
            this.pnl_form.Controls.Add(this.lbl_bolge);
            this.pnl_form.Controls.Add(this.lbl_yas);
            this.pnl_form.Controls.Add(this.txt_yas);
            this.pnl_form.Controls.Add(this.txt_isim);
            this.pnl_form.Controls.Add(this.lbl_isim);
            this.pnl_form.Controls.Add(this.lbl_form_title);
            this.pnl_form.Location = new System.Drawing.Point(570, 0);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(270, 450);
            this.pnl_form.TabIndex = 2;
            // 
            // lbl_form_title
            // 
            this.lbl_form_title.AutoSize = true;
            this.lbl_form_title.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_form_title.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_form_title.Location = new System.Drawing.Point(10, 10);
            this.lbl_form_title.Name = "lbl_form_title";
            this.lbl_form_title.Size = new System.Drawing.Size(147, 25);
            this.lbl_form_title.TabIndex = 0;
            this.lbl_form_title.Text = "Hayvan Bilgileri";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(10, 45);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(85, 20);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "Hayvan Adı";
            // 
            // txt_isim
            // 
            this.txt_isim.AcceptsReturn = true;
            this.txt_isim.Location = new System.Drawing.Point(10, 65);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(230, 27);
            this.txt_isim.TabIndex = 2;
            // 
            // txt_yas
            // 
            this.txt_yas.Location = new System.Drawing.Point(10, 130);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(230, 27);
            this.txt_yas.TabIndex = 3;
            // 
            // lbl_yas
            // 
            this.lbl_yas.AutoSize = true;
            this.lbl_yas.Location = new System.Drawing.Point(10, 110);
            this.lbl_yas.Name = "lbl_yas";
            this.lbl_yas.Size = new System.Drawing.Size(30, 20);
            this.lbl_yas.TabIndex = 4;
            this.lbl_yas.Text = "Yaş";
            // 
            // lbl_bolge
            // 
            this.lbl_bolge.AutoSize = true;
            this.lbl_bolge.Location = new System.Drawing.Point(10, 175);
            this.lbl_bolge.Name = "lbl_bolge";
            this.lbl_bolge.Size = new System.Drawing.Size(48, 20);
            this.lbl_bolge.TabIndex = 5;
            this.lbl_bolge.Text = "Bölge";
            // 
            // txt_bolge
            // 
            this.txt_bolge.Location = new System.Drawing.Point(10, 195);
            this.txt_bolge.Name = "txt_bolge";
            this.txt_bolge.Size = new System.Drawing.Size(230, 27);
            this.txt_bolge.TabIndex = 6;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Location = new System.Drawing.Point(10, 240);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(66, 20);
            this.lbl_kategori.TabIndex = 7;
            this.lbl_kategori.Text = "Kategori";
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Location = new System.Drawing.Point(10, 260);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(230, 28);
            this.cmb_kategori.TabIndex = 8;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(10, 320);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(110, 40);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(130, 320);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(110, 40);
            this.btn_guncelle.TabIndex = 10;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(10, 370);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(110, 40);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Gray;
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.Location = new System.Drawing.Point(130, 370);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(110, 40);
            this.btn_listele.TabIndex = 12;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1082, 791);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_sidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pati Dostu - Hayvan Yönetimi";
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_topbar.ResumeLayout(false);
            this.pnl_topbar.PerformLayout();
            this.pnl_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Button btn_nav_hayvanlar;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Button btn_nav_kategoriler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nav_gonulluler;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_topbar;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Label lbl_form_title;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_yas;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.TextBox txt_bolge;
        private System.Windows.Forms.Label lbl_bolge;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
    }
}

