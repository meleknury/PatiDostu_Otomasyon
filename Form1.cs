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
                MessageBox.Show("Hayvan kaydedildi! 🐾");
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