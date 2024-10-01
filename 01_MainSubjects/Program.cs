using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            /*
            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");
            //Console.Write(" Canım");

            Console.WriteLine("***** Yemek Kategoriler *****\n");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar ");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-Soğuk İçecekler");
            Console.WriteLine("\n***** Yemek Kategoriler *****");

            //ctrl+d ile   satırı kopyalayıp yazar
            //ctrl+d ile satırı kopyalayıp aşağı yazrar
            Console.Read();
            */
            #endregion

            #region String Değişkenler

            //string
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervation Cards ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Customer Communication: " + customerPhone);
            //Console.WriteLine("Customer Email Address: "+ customerEmail);
            //Console.WriteLine("Customer Adress: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Customer Communication: " + customerPhone);
            //Console.WriteLine("Customer Email Address: " + customerEmail);
            //Console.WriteLine("Customer Adress: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine();

            #endregion

            #region Int Deiğşkenler
            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int frisePrice = 50;
            int waterPrice = 10;
            int cokePrice = 35;
            int lemonadePrice = 30;

            Console.WriteLine("***** Price of Restaurant Menu *****\n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\t The Food ");
            Console.WriteLine("---> Hamburger Price: " + hamburgerPrice+ " TL");
            Console.WriteLine("---> Pizza Price: " + pizzaPrice + " TL");
            Console.WriteLine("---> Frise Price: " + frisePrice + " TL");
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\t The Drink ");
            Console.WriteLine("---> Water Price: " + waterPrice + " TL");
            Console.WriteLine("---> Coke Price: " + cokePrice + " TL");
            Console.WriteLine("---> Lemonade Price: " + lemonadePrice + " TL");
            Console.WriteLine("\n--------------------------\n");
            int hamburgerCount;
            int pizzaCount;
            int friseCount;
            int waterCount;
            int cokeCount;
            int lemonadeCount;

            int totalPrice = 0;
            int totalHamburgerPrice = 0;
            int totalPizzaPrice = 0;
            int totalFrisePrice = 0;
            int totalWaterPrice = 0;
            int totalCokePrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friseCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            hamburgerPrice = hamburgerPrice * hamburgerCount;
            pizzaPrice = pizzaPrice * pizzaCount;
            frisePrice = frisePrice * friseCount;
            waterPrice = waterPrice * waterCount;
            cokePrice = cokePrice * cokeCount;
            lemonadePrice = lemonadePrice * lemonadeCount;

            totalPrice = hamburgerPrice + pizzaPrice + frisePrice + waterPrice + cokePrice + lemonadePrice;

            Console.WriteLine("************* Price *************");
            Console.WriteLine("Hamburger Price -> " + hamburgerPrice + " TL");
            Console.WriteLine("Pizza Price -> " + pizzaPrice + " TL");
            Console.WriteLine("Frise Price -> " + frisePrice + " TL");
            Console.WriteLine("Water Price -> " + waterPrice + " TL");
            Console.WriteLine("Coke Price -> " + cokePrice + " TL");
            Console.WriteLine("Lemonade Price -> " + lemonadePrice + " TL");
            Console.WriteLine("Total Price to be Paid -> " + totalPrice + " TL");


            #endregion

            Console.Read();
        }
    }
}


//Yorum satırları // işaretiyle yapılır.

/* Çoklu yorum satırı da aşağıdaki gibi
 * dşvmdföv
 * mcşödvdvşd
 * dlmvdlmbl*/