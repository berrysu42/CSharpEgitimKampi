using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For loops

            /* For(x;y;z)
             * x->başlangıç
             * y->bitiş
             * z-> artış/azalış miktarı
             */

            //int i;
            //int total = 0;
            //for (i = 0; i <= 5 ; i++)
            //{
            //    Console.WriteLine(i);

            //    total +=i;
            //    Console.WriteLine("Result -> "+ total);
            //    Console.WriteLine("*************");

            //}
            //i += 1;

            //int i;
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı ");
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz ->");
            //int finishValue = int.Parse(Console.ReadLine());
            //int i;
            //for ( i = 0; i <= finishValue; i++) {
            //    Console.WriteLine("Yaşasın Cumhuriyet");

            //}
            //Console.WriteLine("Sayınız-> " + finishValue);

            #endregion

            #region For Loop with Decision Structures
            //0-100 arasında 5'e tam bölünen sayıları listele

            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i % 5 == 0) 
            //        Console.WriteLine(i);
            //}

            //ardışık sayıların toplamı
            //int totalValue = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //           totalValue += i;
            //}
            //Console.WriteLine("0'dan 100'e kadar olan sayıların toplamı -> "+totalValue);

            // 1-20 arası çift syıların toplamı
            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}


            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            // 1-50 arası 7'ye tam bölünen syılar
            //int count = 0;
            //for (int i = 1; i <= 50; i++) 
            //    {
            //        if (i % 7 == 0)
            //        {                             
            //            Console.WriteLine(i);
            //            count++;
            //        }
            //    }   
            //Console.WriteLine("--------");
            //Console.WriteLine(count);

            /*Bakteri artışı her sattin sonunda kendini 2ye bölerek artmaktadır.
              24 saatin sonunda kaç bakteri olur?  
             */
            //int bacteria = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteria *= 2;
            //    Console.WriteLine(i+".saatin sonundaki bakteri sayıs -> " + bacteria);


            //}
            //Console.WriteLine("24 saatin sonundaki bakteri sayıs -> "+bacteria);
            #endregion

            #region While Loops

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello Loops -> "+i);
            //    i++;
            //}

            //1-10 arasında 3'e tam bölünen sayıları bulun.
            //int i = 1;
            //while (i <= 10) {
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            //1-10 arası sayıların toplamı
            //int i = 1;
            //int sum = 0;
            //while (i <= 10) { 
            //    Console.WriteLine(i);
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("------------------");
            //Console.WriteLine("Total result -> "+sum);

            //klavyeden grilen 3 basamaklı sayının basamkları toplamı nedir?

            //int sum = 0;
            //int number;
            //Console.Write("Lütfen 3 basamaklı sayınızı giriniz -> ");
            //number = int.Parse(Console.ReadLine());

            //while(number!= 0)
            //{
            //    sum += number % 10;
            //    number /= 10;

            //}
            // Console.WriteLine(sum);

            //2.yöntemim
            //Console.Write("Sayıyı giriniz -> ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number / 10) % 10;
            //Console.WriteLine("Yüzler basamağındaki sayının değeri -> " + hundreds);
            //Console.WriteLine("--------- ");

            //Console.WriteLine("Birler basamağındaki sayının değeri -> " + ones);
            //Console.WriteLine("--------- ");

            //Console.WriteLine("Onlar basamağındaki sayının değeri-> " + tens);
            //Console.WriteLine("--------- ");

            //sum = hundreds + tens + ones;
            //Console.WriteLine("Basamaklar toplamı -> " + sum);


            //Hocamızın kodu
            Console.Write("Sayıyı giriniz -> ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            hundreds = number / 100;
            tens = (number % 100) / 10;

            Console.WriteLine(ones + "-"+ tens + "-"+ hundreds);

            sum = hundreds + tens + ones;

            Console.WriteLine(sum);












            #endregion
            Console.Read();



        }
    }
}
