using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PatiDostu_Otomasyon
{
    public partial class Form4 : Form
    {
        PatiDostuDbContext db = new PatiDostuDbContext();

        public Form4()
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
                var volunteers = db.Volunteers.ToList();
                dataGridView1.DataSource = volunteers.Select(v => new
                {
                    ID = v.Volunteer_Id,
                    Ad_Soyad = v.Volunteer_Name,
                    Telefon = v.Volunteer_Phone,
                    Email = v.Volunteer_Email
                }).ToList();
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_isim.Text))
                {
                    MessageBox.Show("Ad Soyad boş olamaz!");
                    return;
                }
                var volunteer = new Volunteer
                {
                    Volunteer_Name = txt_isim.Text,
                    Volunteer_Phone = txt_telefon.Text,
                    Volunteer_Email = txt_email.Text
                };
                db.Volunteers.Add(volunteer);
                db.SaveChanges();
                MessageBox.Show("Gönüllü eklendi! 🐾");
                txt_isim.Clear();
                txt_telefon.Clear();
                txt_email.Clear();
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
                    var volunteer = db.Volunteers.Find(id);
                    if (volunteer != null)
                    {
                        db.Volunteers.Remove(volunteer);
                        db.SaveChanges();
                        MessageBox.Show("Gönüllü silindi!");
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
                var volunteer = db.Volunteers.Find(id);
                if (volunteer != null)
                {
                    volunteer.Volunteer_Name = txt_isim.Text;
                    volunteer.Volunteer_Phone = txt_telefon.Text;
                    volunteer.Volunteer_Email = txt_email.Text;
                    db.SaveChanges();
                    MessageBox.Show("Gönüllü güncellendi!");
                    btn_listele_Click(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells["Ad_Soyad"].Value.ToString();
                txt_telefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
                txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }
    }
}