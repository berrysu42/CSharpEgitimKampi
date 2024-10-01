using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Double Variables
            //double number;
            //number = 4.85;
            //Console.WriteLine("The Number->" + number);

            //Console.WriteLine("***** Fruit and Vegetable Price List *****");
            //double bananaPrice = 39.90;
            //double strawberryPrice = 35.50;
            //double mangoPrice = 63.25;
            //double datefruitPrice = 250.50;
            //double pumpkinPrice = 10.25;
            //double potatoPrice = 8.75;
            //double tomatoPrice = 9.85;
            //Console.WriteLine("\tFruite Price");
            //Console.WriteLine("----- Banana Unit Price -> " + bananaPrice + "₺");
            //Console.WriteLine("----- Strawberry Unit Price ->" + strawberryPrice + "₺");
            //Console.WriteLine("----- Mango Unit Price -> " + mangoPrice);
            //Console.WriteLine("----- Date Fruit Unit Price ->" + datefruitPrice + "₺");
            //Console.WriteLine("\t Vegetable Price");
            //Console.WriteLine("----- Pumpkin Unit Price -> " + pumpkinPrice + "₺");
            //Console.WriteLine("----- Potato Unit Price -> " + potatoPrice + "₺");
            //Console.WriteLine("----- Tomato Unit Price -> " + tomatoPrice + "₺");
            //Console.WriteLine();

            //double bananaGram = 1.245;
            //double strawberryGram = 2.650;
            //double mangoGram = 1.110;
            //double datefruiteGram = 2.234;
            //double pumpkinGram = 1.421;
            //double potatoGram = 5.215;
            //double tomatoGram = 4.200;

            //double bananaTotalPrice = bananaGram * bananaPrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double mangoTotalPrice = mangoGram * mangoPrice;
            //double datefruiteTotalPrice = datefruiteGram * datefruitPrice;
            //double pumpkinTotalPrice = pumpkinGram * pumpkinPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Product Received: Banana - " + "Unite Price: " + bananaPrice + "- Gram: " +
            //    bananaGram + "-Total Price: " + bananaTotalPrice + "₺");
            //Console.WriteLine("Product Received: Strawberry - " + "Unite Price: " + strawberryPrice + "- Gram: " +
            //    strawberryGram + "-Total Price: " + strawberryTotalPrice + "₺");
            //Console.WriteLine("Product Received: Mango - " + "Unite Price: " + mangoPrice + "- Gram: " +
            //    mangoGram + "-Total Price: " + mangoTotalPrice + "₺");
            //Console.WriteLine("Product Received: Date Fruite - " + "Unite Price: " + datefruitPrice + "- Gram: " +
            //    datefruiteGram + "-Total Price: " + datefruiteTotalPrice + "₺");
            //Console.WriteLine("Product Received: Pumpkin - " + "Unite Price: " + pumpkinPrice + "- Gram: " +
            //    pumpkinGram + "-Total Price: " + pumpkinTotalPrice + "₺");
            //Console.WriteLine("Product Received: Potato - " + "Unite Price: " + potatoPrice + "- Gram: " +
            //    potatoGram + "-Total Price: " + potatoTotalPrice + "₺");
            //Console.WriteLine("Product Received: Tomato - " + "Unite Price: " + tomatoPrice + "- Gram: " +
            //  tomatoGram + "-Total Price: " + tomatoTotalPrice + "₺");
            //Console.WriteLine();

            //double totalFruitePrice = bananaGram * bananaPrice + strawberryGram * strawberryPrice + mangoGram * mangoPrice + datefruiteGram * datefruitPrice;
            //double totalVegetablePrice = pumpkinGram*pumpkinPrice + potatoGram*potatoPrice + tomatoGram*tomatoPrice;
            //double totalShoppingPrice = totalFruitePrice + totalVegetablePrice;
            //Console.WriteLine("\t***** Total Fruite Price *****\n");
            //Console.WriteLine("Total Fruite Price: " + totalFruitePrice + "₺" );
            //Console.WriteLine() ;

            //Console.WriteLine("\t***** Total Vegetable Price *****");
            //Console.WriteLine("\nTotal Vegetable Price: " + totalVegetablePrice + "₺");
            //Console.WriteLine();
            //Console.WriteLine("Total Shopping Price ->"+totalShoppingPrice);

            #endregion

            #region  char Variables
            //char symbol;
            //symbol = '₺';
            //Console.WriteLine("The character-> " + symbol);
            #endregion

            #region   Data Entry from Keyboard -> for string

            //ctrl+f ile seçili isimleri değiştirebiliriz
            //Console.WriteLine("***** CSharp Passenger Information *****");
            //string passengerName, passengerSurname, passengerDstrict, passengerCity,
            //    passengerrAge, passengerIdentityNumber;
            //Console.Write("Passenger Name: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Passenger Surname: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Passenger Dstrict: ");
            //passengerDstrict = Console.ReadLine();
            //Console.Write("Passenger City: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Passenger Age ");
            //passengerrAge = Console.ReadLine();
            //Console.Write("Passenger Identity Number: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("\t***** Passenger Information *****\n");
            //Console.WriteLine("Passenger Identitiy Number : " + passengerIdentityNumber + " - " + 
            //    "Passenger Full Name : " + passengerName + " " + passengerSurname +
            //    passengerDstrict + '/' + passengerCity + " " + passengerrAge);
            #endregion

            #region  Data Entry from Keyboard and Casting -> for int
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount , computerCount, chairCount, tvCount ;
            //Console.Write("Plase, enter the number of shoes purchased-> ");
            //shoesCount = int.Parse (Console.ReadLine());
            //Console.Write("Plase, enter the number of computer purchased-> ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Plase, enter the number of chair purchased-> ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Plase, enter the number of television purchased-> ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Total Amount Due" + " -> " + totalPrice);
            #endregion

            #region     Data Entry from Keyboard and Casting -> for double

            //double exam1, exam2, exam3;
            //double result;
            //Console.Write("Plase,enter exam1 : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Plase,enter exam2 : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Plase,enter exam3 : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();

            //Console.WriteLine("Result :" +  result);

            #endregion

            #region Data Entry from Keyboard and Casting-> for char
            char gender;
            Console.Write("Plase, enter ginder: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Your chose : " +  gender);



            #endregion

            Console.Read();
        }
    }
}
