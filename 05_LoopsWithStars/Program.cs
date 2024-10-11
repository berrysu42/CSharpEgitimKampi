using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane * olusturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //#endregion

            //#region Yan yana 10 tane * olusturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region  Alt alta 10 tane * olusturma ve her satırda 10 yıldız olsun
            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();    
            //}

            #endregion

            #region Dik üçgen oluşturma (ici dolu)
            //for (int i = 1; i <= 5; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region  Dik üçgen oluşturma (ici bos)

            //for (int i = 1; i <= 5; i++) 
            //{
            //    for (int j = 1; j <= i; j++) 
            //    {
            //        if (j == 1 || j == i || i == 5)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" "); 
            //        }
            //    }
            //    Console.WriteLine(); 
            //}

            #endregion

            #region Ters dik üçgen oluşturma

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters ve düz 2 dik üçgenin birleşimi 
            //for (int k = 1; k <= 5; k++)
            //{
            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 4;i >= 1;i--)
            //{
            //    for(int j = 1;j <= i;j++)
            //    {
            //        Console.Write("*");
            //    }  
            //    Console.WriteLine();
            //}

            #endregion



            #region  Baklava Dilimi
            //int n = 10;
            ////üst kısım
            //for (int i = 1; i <= n; i++)
            //{
            //    //sol taraftaki boşluk
            //    for (int j = 1; j<= n-i; j++)
            //    {
            //        Console.Write(" ");   //sol taraftan boşluk bırak
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}  

            // //alt kısım
            //for(int i = n-1;i >= 1; i--)
            //{
            //    //sol taraftaki boşluk
            //    for(int j = 1;j <= n-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region   piramit
            //int n = 10;
            ////üst kısım
            //for (int i = 1; i <= n; i++)
            //{
            //    //sol taraftaki boşluk
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");   //sol taraftan boşluk bırak
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Paralel Kenar
            //int n = 10;
            //for (int i = n - 1; i >= 1; i--)
            //    {
            //        //sol taraftaki boşluk
            //        for(int j = 1;j <= n-i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        //yıldızlar
            //        for (int k = 1; k <= 2 * n - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();

            //    }

            #endregion

            #region Ters Piramit
            int n = 10;
            for (int i = n - 1; i >= 1; i--)
            {
                //sol taraftaki boşluk
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            #endregion


            Console.Read();

        }
       
    }
}
