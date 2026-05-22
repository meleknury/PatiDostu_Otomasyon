using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PatiDostu_Otomasyon
{
    public partial class Form3 : Form
    {
        PatiDostuDbContext db = new PatiDostuDbContext();

        public Form3()
        {
            InitializeComponent();
            SetupDataGridView();
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

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var categories = db.Categories.ToList();
                dataGridView1.DataSource = categories.Select(c => new
                {
                    ID = c.Category_Id,
                    Kategori = c.Category_Name
                }).ToList();
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_kategori.Text))
                {
                    MessageBox.Show("Kategori adı boş olamaz!");
                    return;
                }
                var category = new Category { Category_Name = txt_kategori.Text };
                db.Categories.Add(category);
                db.SaveChanges();
                MessageBox.Show("Kategori eklendi!");
                txt_kategori.Clear();
                btn_listele_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
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
                    var category = db.Categories.Find(id);
                    if (category != null)
                    {
                        db.Categories.Remove(category);
                        db.SaveChanges();
                        MessageBox.Show("Kategori silindi!");
                        btn_listele_Click(sender, e);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                var category = db.Categories.Find(id);
                if (category != null)
                {
                    category.Category_Name = txt_kategori.Text;
                    db.SaveChanges();
                    MessageBox.Show("Kategori güncellendi!");
                    btn_listele_Click(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_kategori.Text = dataGridView1.Rows[e.RowIndex].Cells["Kategori"].Value.ToString();
            }
        }
    }
}