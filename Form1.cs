using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PatiDostu_Otomasyon
{
    public partial class Form1 : Form
    {
        PatiDostuDbContext db = new PatiDostuDbContext();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadCategories();
            SetupIcons();
            LoadDashboard();
        }

        private void SetupDataGridView()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 158, 117);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 240);
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.GridColor = Color.FromArgb(220, 240, 220);
        }

        private void LoadDashboard()
        {
            try
            {
                int hayvanSayisi = db.Animals.Count();
                int gonulluSayisi = db.Volunteers.Count();
                int bakimSayisi = db.CareRecords.Count();
                int kategoriSayisi = db.Categories.Count();

                Panel pnl_dashboard = new Panel();
                pnl_dashboard.Size = new Size(820, 80);
                pnl_dashboard.Location = new Point(20, 0);
                pnl_dashboard.BackColor = Color.Transparent;

                pnl_dashboard.Controls.Add(CreateStatCard("Hayvan", hayvanSayisi.ToString(), Color.FromArgb(45, 158, 117), 0));
                pnl_dashboard.Controls.Add(CreateStatCard("Gonullu", gonulluSayisi.ToString(), Color.FromArgb(70, 130, 180), 210));
                pnl_dashboard.Controls.Add(CreateStatCard("Bakim", bakimSayisi.ToString(), Color.FromArgb(205, 133, 63), 420));
                pnl_dashboard.Controls.Add(CreateStatCard("Kategori", kategoriSayisi.ToString(), Color.FromArgb(147, 112, 219), 630));

                pnl_content.Controls.Add(pnl_dashboard);
                pnl_dashboard.BringToFront();

                dataGridView1.Location = new Point(20, 90);
                dataGridView1.Size = new Size(540, 360);
                pnl_form.Location = new Point(570, 90);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dashboard hatası: {ex.Message}");
            }
        }

        private Panel CreateStatCard(string title, string value, Color color, int x)
        {
            Panel card = new Panel();
            card.Size = new Size(190, 70);
            card.Location = new Point(x, 0);
            card.BackColor = Color.White;

            Panel leftBar = new Panel();
            leftBar.Size = new Size(6, 70);
            leftBar.Location = new Point(0, 0);
            leftBar.BackColor = color;
            card.Controls.Add(leftBar);

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 9f);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(15, 10);
            lblTitle.AutoSize = true;
            card.Controls.Add(lblTitle);

            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 20f, FontStyle.Bold);
            lblValue.ForeColor = color;
            lblValue.Location = new Point(15, 30);
            lblValue.AutoSize = true;
            card.Controls.Add(lblValue);

            return card;
        }

        private void SetupIcons()
        {
            try
            {
                string iconPath = Application.StartupPath + @"\Resources\Icons\";

                SetButtonIcon(btn_nav_hayvanlar, iconPath + "icons8-dog-64.png", 20);
                SetButtonIcon(btn_nav_gonulluler, iconPath + "icons8-volunteer-64.png", 20);
                SetButtonIcon(button1, iconPath + "icons8-clipboard-64.png", 20);
                SetButtonIcon(btn_nav_kategoriler, iconPath + "icons8-list-50.png", 20);

                SetButtonIcon(btn_ekle, iconPath + "icons8-add-user-64.png", 18);
                SetButtonIcon(btn_sil, iconPath + "icons8-delete-100.png", 18);
                SetButtonIcon(btn_guncelle, iconPath + "icons8-edit-64.png", 18);
                SetButtonIcon(btn_listele, iconPath + "icons8-list-50.png", 18);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İkon yüklenemedi: {ex.Message}");
            }
        }

        private void SetButtonIcon(Button btn, string path, int size)
        {
            Image original = Image.FromFile(path);
            Image resized = new Bitmap(original, new Size(size, size));
            btn.Image = resized;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(5, 0, 0, 0);
        }

        private void LoadCategories()
        {
            try
            {
                cmb_kategori.DataSource = db.Categories.ToList();
                cmb_kategori.DisplayMember = "Category_Name";
                cmb_kategori.ValueMember = "Category_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var animals = db.Animals.Include("Category").ToList();
                dataGridView1.DataSource = animals.Select(a => new
                {
                    ID = a.Animal_Id,
                    Ad = a.Animal_Name,
                    Yaş = a.Animal_Age,
                    Bölge = a.Animal_Region,
                    Kategori = a.Category.Category_Name
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                var animal = new Animal
                {
                    Animal_Name = txt_isim.Text,
                    Animal_Age = Convert.ToInt32(txt_yas.Text),
                    Animal_Region = txt_bolge.Text,
                    Category_Id = (int)cmb_kategori.SelectedValue
                };
                db.Animals.Add(animal);
                db.SaveChanges();
                MessageBox.Show("Hayvan kaydedildi!");
                btn_listele_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                var onay = MessageBox.Show("Silmek istiyor musunuz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                    var animal = db.Animals.Find(id);
                    if (animal != null)
                    {
                        db.Animals.Remove(animal);
                        db.SaveChanges();
                        MessageBox.Show("Hayvan silindi!");
                        btn_listele_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                var animal = db.Animals.Find(id);
                if (animal != null)
                {
                    animal.Animal_Name = txt_isim.Text;
                    animal.Animal_Age = Convert.ToInt32(txt_yas.Text);
                    animal.Animal_Region = txt_bolge.Text;
                    animal.Category_Id = (int)cmb_kategori.SelectedValue;
                    db.SaveChanges();
                    MessageBox.Show("Hayvan güncellendi!");
                    btn_listele_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                txt_yas.Text = dataGridView1.Rows[e.RowIndex].Cells["Yaş"].Value.ToString();
                txt_bolge.Text = dataGridView1.Rows[e.RowIndex].Cells["Bölge"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btn_nav_kategoriler_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btn_nav_gonulluler_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
