using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new  //rehberlerimizi getireceğiz.
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString()); 
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ID'nin boş veya geçersiz olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Geçerli bir ID giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabanında bu ID'ye sahip bir kaydın olup olmadığını kontrol et
            var deletedValue = db.Location.Find(id);

            // Eğer kayıt bulunamazsa kullanıcıyı bilgilendir
            if (deletedValue == null)
            {
                MessageBox.Show("Bu ID'ye sahip bir kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }

            // Kayıt bulunduysa silme işlemini gerçekleştir
            db.Location.Remove(deletedValue);
            db.SaveChanges();

            // Kullanıcıya başarılı bir şekilde silindiğini bildir
            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Gerekirse, formdaki ilgili alanları temizle
            txtId.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //ID'ye göre güncelleme yapılacak
            int id = int.Parse(txtId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.DayNight = txtDayNight.Text;
            updateValue.Price = decimal.Parse(txtPrice.Text);
            updateValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updateValue.City = txtCity.Text;
            updateValue.Country = txtCountry.Text;
            updateValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // Çıkış yapmak için kullanıcıdan onay al
            var result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?",
                                         "Çıkış Onayı", MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            // Eğer kullanıcı 'Evet' derse, uygulamayı kapat
            if (result == DialogResult.Yes)
            {
                Application.Exit();      // Uygulama kapanır
            }
        }

        
    }
}
