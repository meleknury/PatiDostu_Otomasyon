namespace PatiDostu_Otomasyon
{
    partial class Form2
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
            this.lbl_animal = new System.Windows.Forms.Label();
            this.cmb_animal = new System.Windows.Forms.ComboBox();
            this.lbl_volunteer = new System.Windows.Forms.Label();
            this.cmb_volunteer = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_note = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.grp_linq = new System.Windows.Forms.GroupBox();
            this.rd_enCokBakilan = new System.Windows.Forms.RadioButton();
            this.rd_enAktifGonullu = new System.Windows.Forms.RadioButton();
            this.lbl_linq1 = new System.Windows.Forms.Label();
            this.lbl_linq2 = new System.Windows.Forms.Label();
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_form.SuspendLayout();
            this.grp_linq.SuspendLayout();
            this.pnl_topbar.SuspendLayout();
            this.SuspendLayout();

            // pnl_topbar
            this.pnl_topbar.BackColor = System.Drawing.Color.White;
            this.pnl_topbar.Controls.Add(this.lbl_header);
            this.pnl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topbar.Name = "pnl_topbar";
            this.pnl_topbar.Size = new System.Drawing.Size(1100, 60);
            this.pnl_topbar.TabIndex = 0;

            // lbl_header
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_header.Location = new System.Drawing.Point(20, 15);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(220, 31);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Bakım Kayıtları";

            // dataGridView1
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

            // pnl_form
            this.pnl_form.BackColor = System.Drawing.Color.FromArgb(240, 248, 240);
            this.pnl_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_form.Controls.Add(this.lbl_title);
            this.pnl_form.Controls.Add(this.lbl_animal);
            this.pnl_form.Controls.Add(this.cmb_animal);
            this.pnl_form.Controls.Add(this.lbl_volunteer);
            this.pnl_form.Controls.Add(this.cmb_volunteer);
            this.pnl_form.Controls.Add(this.lbl_date);
            this.pnl_form.Controls.Add(this.dateTimePicker1);
            this.pnl_form.Controls.Add(this.lbl_note);
            this.pnl_form.Controls.Add(this.txt_note);
            this.pnl_form.Controls.Add(this.btn_ekle);
            this.pnl_form.Controls.Add(this.btn_sil);
            this.pnl_form.Controls.Add(this.btn_listele);
            this.pnl_form.Controls.Add(this.grp_linq);
            this.pnl_form.Location = new System.Drawing.Point(640, 80);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(440, 580);
            this.pnl_form.TabIndex = 2;

            // lbl_title
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_title.Location = new System.Drawing.Point(10, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Bakım Kaydı Ekle";

            // lbl_animal
            this.lbl_animal.AutoSize = true;
            this.lbl_animal.Location = new System.Drawing.Point(10, 45);
            this.lbl_animal.Name = "lbl_animal";
            this.lbl_animal.TabIndex = 1;
            this.lbl_animal.Text = "Hayvan";

            // cmb_animal
            this.cmb_animal.FormattingEnabled = true;
            this.cmb_animal.Location = new System.Drawing.Point(10, 65);
            this.cmb_animal.Name = "cmb_animal";
            this.cmb_animal.Size = new System.Drawing.Size(400, 28);
            this.cmb_animal.TabIndex = 2;

            // lbl_volunteer
            this.lbl_volunteer.AutoSize = true;
            this.lbl_volunteer.Location = new System.Drawing.Point(10, 105);
            this.lbl_volunteer.Name = "lbl_volunteer";
            this.lbl_volunteer.TabIndex = 3;
            this.lbl_volunteer.Text = "Gönüllü";

            // cmb_volunteer
            this.cmb_volunteer.FormattingEnabled = true;
            this.cmb_volunteer.Location = new System.Drawing.Point(10, 125);
            this.cmb_volunteer.Name = "cmb_volunteer";
            this.cmb_volunteer.Size = new System.Drawing.Size(400, 28);
            this.cmb_volunteer.TabIndex = 4;

            // lbl_date
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(10, 165);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Bakım Tarihi";

            // dateTimePicker1
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 27);
            this.dateTimePicker1.TabIndex = 6;

            // lbl_note
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(10, 225);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.TabIndex = 7;
            this.lbl_note.Text = "Not";

            // txt_note
            this.txt_note.Location = new System.Drawing.Point(10, 245);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(400, 27);
            this.txt_note.TabIndex = 8;

            // btn_ekle
            this.btn_ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(10, 290);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(120, 40);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);

            // btn_sil
            this.btn_sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(140, 290);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(120, 40);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);

            // btn_listele
            this.btn_listele.BackColor = System.Drawing.Color.Gray;
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.Location = new System.Drawing.Point(270, 290);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(120, 40);
            this.btn_listele.TabIndex = 11;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);

            // grp_linq
            this.grp_linq.Controls.Add(this.rd_enCokBakilan);
            this.grp_linq.Controls.Add(this.rd_enAktifGonullu);
            this.grp_linq.Controls.Add(this.lbl_linq1);
            this.grp_linq.Controls.Add(this.lbl_linq2);
            this.grp_linq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grp_linq.ForeColor = System.Drawing.Color.SeaGreen;
            this.grp_linq.Location = new System.Drawing.Point(10, 345);
            this.grp_linq.Name = "grp_linq";
            this.grp_linq.Size = new System.Drawing.Size(410, 200);
            this.grp_linq.TabIndex = 12;
            this.grp_linq.TabStop = false;
            this.grp_linq.Text = "LINQ Sorguları";

            // rd_enCokBakilan
            this.rd_enCokBakilan.AutoSize = true;
            this.rd_enCokBakilan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rd_enCokBakilan.ForeColor = System.Drawing.Color.Black;
            this.rd_enCokBakilan.Location = new System.Drawing.Point(10, 30);
            this.rd_enCokBakilan.Name = "rd_enCokBakilan";
            this.rd_enCokBakilan.Size = new System.Drawing.Size(180, 24);
            this.rd_enCokBakilan.TabIndex = 0;
            this.rd_enCokBakilan.Text = "En çok bakılan hayvan";
            this.rd_enCokBakilan.CheckedChanged += new System.EventHandler(this.rd_enCokBakilan_CheckedChanged);

            // lbl_linq1
            this.lbl_linq1.AutoSize = true;
            this.lbl_linq1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_linq1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_linq1.Location = new System.Drawing.Point(10, 60);
            this.lbl_linq1.Name = "lbl_linq1";
            this.lbl_linq1.Size = new System.Drawing.Size(80, 20);
            this.lbl_linq1.TabIndex = 1;
            this.lbl_linq1.Text = "Sonuç: -";

            // rd_enAktifGonullu
            this.rd_enAktifGonullu.AutoSize = true;
            this.rd_enAktifGonullu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rd_enAktifGonullu.ForeColor = System.Drawing.Color.Black;
            this.rd_enAktifGonullu.Location = new System.Drawing.Point(10, 100);
            this.rd_enAktifGonullu.Name = "rd_enAktifGonullu";
            this.rd_enAktifGonullu.Size = new System.Drawing.Size(180, 24);
            this.rd_enAktifGonullu.TabIndex = 2;
            this.rd_enAktifGonullu.Text = "En aktif gönüllü";
            this.rd_enAktifGonullu.CheckedChanged += new System.EventHandler(this.rd_enAktifGonullu_CheckedChanged);

            // lbl_linq2
            this.lbl_linq2.AutoSize = true;
            this.lbl_linq2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_linq2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_linq2.Location = new System.Drawing.Point(10, 130);
            this.lbl_linq2.Name = "lbl_linq2";
            this.lbl_linq2.Size = new System.Drawing.Size(80, 20);
            this.lbl_linq2.TabIndex = 3;
            this.lbl_linq2.Text = "Sonuç: -";

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnl_topbar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_form);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pati Dostu - Bakım Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.grp_linq.ResumeLayout(false);
            this.grp_linq.PerformLayout();
            this.pnl_topbar.ResumeLayout(false);
            this.pnl_topbar.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_animal;
        private System.Windows.Forms.ComboBox cmb_animal;
        private System.Windows.Forms.Label lbl_volunteer;
        private System.Windows.Forms.ComboBox cmb_volunteer;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox grp_linq;
        private System.Windows.Forms.RadioButton rd_enCokBakilan;
        private System.Windows.Forms.RadioButton rd_enAktifGonullu;
        private System.Windows.Forms.Label lbl_linq1;
        private System.Windows.Forms.Label lbl_linq2;
        private System.Windows.Forms.Panel pnl_topbar;
        private System.Windows.Forms.Label lbl_header;
    }
}