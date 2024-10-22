using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatebaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            //c# da sql yapılarını kullanmamızı sağlayan bir çerçevedir.
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("3-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V5J3NP8;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();//bağlantıyı açma
            //Data Source=DESKTOP-V5J3NP8  veri tabanımızın bağlantı adresi
            //initial Catalog=EgitimKampiDb veri tabanımızın adı
            //integrated security=true bağlantının güvenliğini doğrulama

            SqlCommand command = new SqlCommand("select *from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable(); //verileri geçici belleğe alma
            adapter.Fill(datatable); //RAM bellek üzerinden kullanıcıya select *from TblCategory bu sorguyu gösterebilmek.
            connection.Close();   //bağlantıyı kapatma

            //döngü oluşturup verileri çekmemiz lazım
            //var değişken türü bütün değişkenleri üzerine alır.
            foreach (DataRow row in datatable.Rows)  
            {
                foreach (var item in row.ItemArray) //veritabanında her türlü veri türü olduğu için var ı yazdık.
                {   
                    //row dan gelen item'leri okuyacağız.
                    Console.Write(" "+item.ToString());
                }
                Console.WriteLine();
            }  

            Console.Read();
        }
    }
}
