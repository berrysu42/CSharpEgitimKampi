using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //kendi metotlarımızı oluşturma
            /*Bir yapının metot olduğunu anlamak için sonunda mutlaka parantez()
             açılıp kapatılması gerekir.C# da metotlar mor renkli bir küp ile temsil edilir.
            2'ye ayrılır geriye değer döndüren ve geriye değer döndürmeyen metotlar. Geriye
           değer döndürmeyen metotlar void() olarak adlandırılır.
            */

            //müşterileri ekrana yazdıran void() metotları
            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");

            //}
            //metot çağırma
            //customerList();

            //void sum() {
            //    int number1 = 50,number2=100;
            //    int total=number1 + number2;
            //    Console.WriteLine(total);
            //}
            //sum();
            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ali Yılmaz");

            //Customer card preparing
            //void customerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surName);
            //}

            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar
            //void sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    Console.WriteLine(result);
            //}
            //sum(4,5);
            #endregion

            #region   Geriye Değer Döndüren Metotlar
            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";
            //    return name + " " + surName;

            //}

            //Console.WriteLine(studentCard()); 
            #endregion

            #region Geriye Değer Döndürend string Parametreli Metotlar
            //string countryCard(string countryName, string capital, string flagColor) {
            //    string cardInfo = "Ülke: "+countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    Console.WriteLine(cardInfo);
            //    return cardInfo;

            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz...->");
            //x = Console.ReadLine();

            //Console.Write("Başkenti girniz.--->");
            //y= Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz.--->");
            //z = Console.ReadLine();

            //countryCard(x, y, z);
            //Console.WriteLine(countryCard(x, y, z));


            //Ark arkaya 2 kez yazırma
            //Console.WriteLine(countryCard("Filistin","Kudüs","Kırmızı-Yeşil-Siyah"));

            //countryCard("Türkiye", "Ankara", "Kırmızı-Beyaz");

            #endregion

            #region Geriye Değer Döndüren int Parametreli Metotlar
            //int sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(4, 15));
            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(44, 36));
            //Console.WriteLine(sum(14, 20));

            #endregion

            #region Örnek Uygulama
            string examResult(string student,int exam1, int exam2,int exam3) {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                
                    return $"{student}: Öğrenci sınavı geçti. "+"Ortalama: "+result;
                   // return student+": Öğrenci sınavı geçti. " + "Ortalama: " + result;


                else
                    return $"{student}: Öğrenci başarısız oldu. " + "Ortalama: " + result;
                    //return student + ": Öğrenci sınavı geçti. " + "Ortalama: " + result;
            }
            Console.WriteLine(examResult("Ali Kaya",25,41,85));
            Console.WriteLine(examResult("Ayşe Çınar", 36,88,33));
            Console.WriteLine(examResult("Caner Tunç", 36, 68, 33));

            #endregion




            Console.Read();
        }
    }
}
