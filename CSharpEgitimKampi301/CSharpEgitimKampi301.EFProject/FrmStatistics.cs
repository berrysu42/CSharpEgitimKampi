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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x=>x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x=> (decimal?)x.Capacity)?.ToString("0.00"); //"0" yaparsak yuvarlama yapar
            lblAvgLocationPrice.Text = db.Location.Average(x => (decimal?)x.Price)?.ToString("0.00")+"₺";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x=>x.LocationId==lastCountryId).Select(y=>y.Country).FirstOrDefault().ToString();
            
            //Gidilen Cİty'nin kapasitesini getrme. Burda city miz kapadokya
            lblCappadociaLoactionCapacity.Text = db.Location .Where(x=>x.City== "Kapadokya").Select(y=>y.Capacity).FirstOrDefault().ToString();

            //Türkiyedeki her bir turun ortalama kapasitesini yazdırma 230/5=46 230 kişi 5 Şehir
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x=>x.Country == "Türkiye").Average(y=>y.Capacity).ToString();

            //Roma gezisinin rehberinin ismini bulma.Burda bir alt sorgu var
            var romeGuideId = db.Location.Where(x=>x.City== "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();//alt sorgu burda. 
            //Location tablosundan Roma Turistik isimini bulup ordan GuideId'yi çekip daha sonra Guide Tablosuna gidip bulduğumuz Id'ye sahip ismi çektik.
            lblRomeGuideName.Text =db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName+ " "+ y.GuideSurname).FirstOrDefault().ToString();

            //En yüksek kpasiteli turun adını yazdıralım
            var maxCapacity = db.Location.Max(x=>x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            //en pahalı turun şehir bilgisini yazdıralım
            var maxPrice = db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            //Adı Ayşegül Çınar olanın tur sayısını bulma
            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x=>x.GuideId==guideIdByNameAysegulCinar).Count().ToString();

            //Milanoya ait gece gündüz tatilini yazdırma
            lblMilanoDayNight.Text= db.Location.Where(x=>x.City== "Milano").Select(y=>y.DayNight).FirstOrDefault().ToString();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }





        //private void label5_Click(object sender, EventArgs e)
        // {

        //}




    }
}
