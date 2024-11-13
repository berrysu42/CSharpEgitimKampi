/*
 Bu class sadece oluşturacağımız category tablosuna ait değerleri tutacak 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        // code-first yaklaşımı, C# daki sınıfları alıyor SQL'de birer tabloya C# daki o sınıfların içindeki propertyleri alıyor SQL'de birer sütuna dönüştürüyor.
        // Property yapacağız.

        //code-first yaklaşımı içinde CategoryId'nin birincil anahtar olduğunu ve otomatik artan olduğunu bildirmek adına sınıfın ismi birebir aynı yazılır ve sonuna Id eklenir.
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }  //1-N ilişki formatı
    }
}
/*
Field-Veriable-Property bu 3 komut arasında farklar vardır.
Eğer ki, bir değişken int x; -- direk sıınıfın içinde tanımlanırsa bu Field
Eğer ki, bir değişken yapısı sonra get ve set diye 2 değer alırsa -- bu Property
Eğer ki, bir değişken metot içinde tanımlanıyorsa bu kez Veriable olur.

int x; --> Field
public int y {get;set;} --> Property

void test()
{
    int z;  --> Veriable
}
*/