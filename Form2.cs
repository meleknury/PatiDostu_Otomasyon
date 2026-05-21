using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PatiDostu_Otomasyon
{
    public partial class Form2 : Form
    {
        PatiDostuDbContext db = new PatiDostuDbContext();

        public Form2()
        {
            InitializeComponent();
            LoadAnimals();
            LoadVolunteers();
        }

        private void LoadAnimals()
        {
            try
            {
                cmb_animal.DataSource = db.Animals.ToList();
                cmb_animal.DisplayMember = "Animal_Name";
                cmb_animal.ValueMember = "Animal_Id";
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void LoadVolunteers()
        {
            try
            {
                cmb_volunteer.DataSource = db.Volunteers.ToList();
                cmb_volunteer.DisplayMember = "Volunteer_Name";
                cmb_volunteer.ValueMember = "Volunteer_Id";
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var records = db.CareRecords.Include("Animal").Include("Volunteer").ToList();
                dataGridView1.DataSource = records.Select(r => new
                {
                    ID = r.Care_Id,
                    Hayvan = r.Animal.Animal_Name,
                    Gönüllü = r.Volunteer.Volunteer_Name,
                    Tarih = r.Care_Date.ToShortDateString(),
                    Not = r.Care_Note
                }).ToList();
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                var record = new CareRecord
                {
                    Animal_Id = (int)cmb_animal.SelectedValue,
                    Volunteer_Id = (int)cmb_volunteer.SelectedValue,
                    Care_Date = dateTimePicker1.Value,
                    Care_Note = txt_note.Text
                };
                db.CareRecords.Add(record);
                db.SaveChanges();
                MessageBox.Show("Bakım kaydı eklendi! 🐾");
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
                    var record = db.CareRecords.Find(id);
                    if (record != null)
                    {
                        db.CareRecords.Remove(record);
                        db.SaveChanges();
                        MessageBox.Show("Kayıt silindi!");
                        btn_listele_Click(sender, e);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void rd_enCokBakilan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_enCokBakilan.Checked)
                {
                    var result = db.CareRecords
                        .GroupBy(r => r.Animal.Animal_Name)
                        .Select(g => new { Ad = g.Key, Adet = g.Count() })
                        .OrderByDescending(x => x.Adet)
                        .FirstOrDefault();
                    lbl_linq1.Text = result != null ? $"En çok bakılan: {result.Ad} ({result.Adet} bakım)" : "Kayıt yok";
                }
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }

        private void rd_enAktifGonullu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_enAktifGonullu.Checked)
                {
                    var result = db.CareRecords
                        .GroupBy(r => r.Volunteer.Volunteer_Name)
                        .Select(g => new { Ad = g.Key, Adet = g.Count() })
                        .OrderByDescending(x => x.Adet)
                        .FirstOrDefault();
                    lbl_linq2.Text = result != null ? $"En aktif gönüllü: {result.Ad} ({result.Adet} bakım)" : "Kayıt yok";
                }
            }
            catch (Exception ex) { MessageBox.Show($"Hata: {ex.Message}"); }
        }
    }
}