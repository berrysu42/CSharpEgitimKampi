using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();


        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList(); 
            dataGridView1.DataSource = values;


        }
        private void button2_Click(object sender, EventArgs e)  //btnAdd
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                //eklenecek isim ve soyisim yeri boş ise
                MessageBox.Show("İsim ve soyisim alanları boş bırakılamaz!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;//işlemi durdur
            }
            // Yeni Guide nesnesi oluştur
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;

            // Veritabanına ekle
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtId.Text)|| !int.TryParse(txtId.Text,out int id))
            {
                MessageBox.Show("Geçerli bir ID giriniz!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            // Veritabanında bu ID'ye sahip bir Guide kaydının olup olmadığını kontrol et
            var removeValue = db.Guide.Find(id);
            //silme yaparken ID üzerinden silme yapılır

            // Eğer kaydın bulunmadığını tespit edersek

            if (removeValue == null)
            {
                MessageBox.Show("Bu ID'ye sahip bir rehber bulunamadı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            //int id = int.Parse(txtId.Text);
            

            // Veritabanından silme
            db.Guide.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Rehber başarıyla silindi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

            // Gerekirse, formdaki ilgili alanları temizle
            txtId.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //ID'ye göre güncelleme yapılacak
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName= txtName.Text;
            updateValue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla Güncellendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x=> x.GuideId==id).ToList();
            dataGridView1.DataSource = values;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Çıkış yapmak için kullanıcıdan onay al
            var result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?",
                                         "Çıkış Onayı",MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            // Eğer kullanıcı 'Evet' derse, uygulamayı kapat
            if(result==DialogResult.Yes)
            {
                Application.Exit();      // Uygulama kapanır
            }


        }
    }
}
