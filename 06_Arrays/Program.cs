using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Temel Dizi Örnekleri ve tüm elemanları listeleme

            //Değişken türü [] diziAdı = new DeğişkenTürü[ElemanSayısı]
            // int[] sayı = new int[5];

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "yellow";
            //colors[2] = "white";
            //colors[3] = "blue";

            //Console.WriteLine(colors[0]);
            //for (int i = 0; i < 4; i++) { 
            //    Console.WriteLine(colors[i]);
            //}

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "İstanbul";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //for (int i = 0; i <cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);

            //}

            //int[] number = new int[10];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = i;    

            //    Console.WriteLine(number[i]);
            //    // i++; bu komut ile sadece çift sayıları yazdırırız.

            //}


            //int[] number = new int[10];
            //number[2] = 24;
            //number[4] = 642;
            //number[7] = 50;



            //for (int i = 0; i < number.Length; i++)
            //{  

            //    Console.WriteLine(number[i]);
            //    //int formatında dizi tanımladığımızda değer ataması yapmaz isek o indexin default değeri 0 olur.

            //}

            //dizilerin başka türlü oluşturma yöntemi
            //string[] cities = {"Ankara","roma","atina","Bursa" };
            //Console.WriteLine(cities[3]+"\n");
            //for (int i = 0; i < cities.Length; i++) { 
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 4,85,96,75,125,635,488,522,7456,2365,1120 };
            //for (int i = 0; i < numbers.Length; i++) {
            //    // Console.WriteLine(numbers[i]);
            //    if (numbers[i] %3 == 0) {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            #region  sıralama

            //int[] numbers = { 55, 21, 12, 10, 35, 78 };

            //for (int i = 0; i < numbers.Length-1; i++) { //döngünün sıralama işlemini kaç kez tekrarlayacağı
            //    for (int j = 0; j < numbers.Length - 1; j++) { // dizinin elemanlarını karşılaştırır.
            //        if(numbers[j] > numbers[j+1])
            //        {
            //            //eleman değişimi
            //            int temp;
            //            temp = numbers[j];
            //            numbers[j] = numbers[j+1];
            //            numbers[j+1] = temp;
            //        }
            //     }
            //}
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region  En büyük elemanı bulma
            //int[] numbers = { 55, 21,70, 12, 10, 35, 78 };
            //int maxNumber = numbers[0];
            //for (int i = 1; i < numbers.Length; i++) { 
            //    if (numbers[i] > maxNumber) {
            //        maxNumber=numbers[i] ; 
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region Dizinin eleman sayısını bulma
            //string[] persons = { "ali", "ayşe", "ahmet", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);
            #endregion

            #region küçükten büyüğe sıralama
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region tersten yazdırma 
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            ////35,22,10...85,45
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion


            #region Dizi Metotları

            //string[] persons = {"ali","buse","ayşegül","merve","çınar","kaya"};
            //aranan elemanın index değerini bulma
            //int index = Array.IndexOf(persons, "merve");
            //Console.WriteLine(index);

            //max-min metotları
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı ->"+numbers.Max());
            //Console.WriteLine("Dizinin en büyük elemanı ->" + numbers.Min());
            #endregion


            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) {
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz. -> ");   // + kullanmadan yazdırma
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("\n ----------------------------");
            //for (int i = 0; i < cities.Length; i++) {
            //    Console.WriteLine(cities[i]);
            //}


            #endregion


            #region Dizideki tüm elemanların toplamı
            //int sum = 0;
            //int[] numbers = {50,12,63,45,1};
            //for (int i = 0; i < numbers.Length; i++) { 
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            #endregion


            #region Tek mi, Çift mi

            //ilk yöntem
            //int[] numbers = { 10, 11, 54, 71, 83, 56 };
            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine("Çift sayılar-> " + numbers[i]);

            //    }

            //}
            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine("Tek sayılar-> " + numbers[i]);

            //    }
            //}
            
            #endregion
            Console.Read();
        }
    }
}
