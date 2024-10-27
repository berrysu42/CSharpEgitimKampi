using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CRUD => Create-Read-Update-Delete
            #region  Kategori Ekleme İşlemi
            /*
            Console.WriteLine("***** Menü Sipariş İşlem Panali *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Eklemek İstediğiniz Kategori Adı: ");
            string categoryName=Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V5J3NP8;initial" +
                " catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            //ekleme işlemi
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1",categoryName);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Kategori başarıyla eklendi!");
            

            //Product tablosuna 
            Console.WriteLine("***** Menü Sipariş İşlem Panali *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();
            */

            #endregion

            #region Ürün Ekleme İşlemi
            //Console.WriteLine("***** Menü Sipariş İşlem Panali *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName=Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-V5J3NP8;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün ekleme işlemi gerçekleşmiştir.");

            #endregion

            #region Ürün Listeleme İşlemi

            //Console.WriteLine("***** Menü Sipariş İşlem Panali *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-V5J3NP8;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows) {
            //    foreach (var item in row.ItemArray) { 
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();

            #endregion

            #region   Ürün Silme İşlemi

            //Console.WriteLine("***** Menü Sipariş İşlem Panali *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-V5J3NP8;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();


            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme işlemi başarıyla gerçekleşti!");

            #endregion

            #region   Ürün Güncelleme İşlemi
            Console.WriteLine("***** Menü Sipariş İşlem Panali *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data source=DESKTOP-V5J3NP8;initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);

            //degisiklikleri kaydetmek için
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme işlemi başarıyla gerçekleştirildi!");
            #endregion
            Console.Read();
        }
    }
}
