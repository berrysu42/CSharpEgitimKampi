using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            // Console.OutputEncoding = Encoding.UTF8;
            #region Foreach Loop
            // 4 parametre alır foreach(1;2;3;4)
            /*
              1.parapetre -> Değişken türü
              2.parametre -> Değişken adı
              3.parametre -> in eki
              4.parametre -> Liste, koleksiyon dizi adı
             */
            //string[] cities = {"Roma","Budapeşte","Ankara","İstanbul" ,
            //        "Varşova" };
            //foreach (string i in cities) { 
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 65780, 10394 };

            //foreach (int number in numbers) {
            //    Console.WriteLine(number);

            //}

            //Çift sayıları yazdırma
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 65780, 10394 };
            //foreach (int number in numbers) { 
            //    if (number % 2 == 0) 
            //        Console.WriteLine(number);
            //}

            //dizi içinde yer alan sayıların toplamı
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 65780, 10394 };
            //int sum = 0;

            //foreach (int number in numbers) {
            //    sum += number;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region  Listelerle foreach kullanımı
            //List<int> list = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //kelimenin harflerini yazdırma
            //string word = "Merhaba";
            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region

            #endregion Örnek Sınav SistemiUygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            //Kullanıcıdan sınıftaki kişi sayısını alma
            Console.WriteLine("--------------------");
            Console.Write("Sınıfınızda kaç tane öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            //Ogrenci isimlerini ve notlarını saklayacak dizi tanımları
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz...->");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 notu sınav alınsın
                for (int j = 0; j < 3; j++)
                {
                    
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz...-> ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

             //Sınav ortalamaları
             for (int i = 0; i < studentCount; i++) {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin sınav ortalaması: {studentExamAvg[i]}");

                //Geçip kalma durumu
                if (studentExamAvg[i] >= 60)
                    Console.WriteLine($"{studentNames[i]} sınavı geçti 😊");
                else
                    Console.WriteLine($"{studentNames[i]} sınavı geçemedi 😌");
                Console.WriteLine("--------------------");

            }
            

            Console.Read();
        }
    }
}
