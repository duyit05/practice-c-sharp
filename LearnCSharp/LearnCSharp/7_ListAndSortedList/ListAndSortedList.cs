using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnCSharp._7_ListAndSortedList
{
    public class ListAndSortedList
    {
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Origin { get; set; }

            public Product(int id, string name, double price, string origin)
            {
                Id = id;
                Name = name;
                Price = price;
                Origin = origin;
            }
        }

        // public static void Main(string[] args)
        // {
        //     // List
        //     List<int> ds1 = new List<int>();
        //     ds1.Add(1);
        //     ds1.Add(2);
        //     ds1.Add(3);
        //     // add 1 mang so nguyen
        //     ds1.AddRange(new int[] { 4, 5, 6, 6, 6, 6 });
        //     // chen phan tu theo index,value
        //     ds1.Insert(0, -1);
        //     // remove phan tu theo index
        //     ds1.RemoveAt(1);
        //     // remove phan tu theo gia tri
        //     ds1.Remove(6);
        //     // remove tat ca cac phan tu chia het cho 2
        //     ds1.RemoveAll(n => n % 2 == 0);
        //     Console.WriteLine("So luong phan tu: " + ds1.Count);
        //     foreach (var i in ds1)
        //     {
        //         Console.WriteLine(i + " ");
        //     }
        //
        //     Console.WriteLine("==================================");
        //
        //     // tim kiem trong list
        //     List<int> ds2 = new List<int>() { 7, 8, 9, 5, 6, 9, 0, 1, 2 };
        //     // tra ve phan tu dau tien thoa man dieu kien
        //     var value = ds2.Find((e) => { return e % 2 == 0; });
        //     Console.WriteLine(value);
        //
        //     // tra ve list cac phan tu thoa man dieu kien
        //     var listValue = ds2.FindAll((x) => { return x >= 5; });
        //     foreach (var data in listValue)
        //     {
        //         Console.WriteLine(data + " ");
        //     }
        //     Console.WriteLine("==================================");
        //     List<Product> products = new List<Product>()
        //     {
        //         new Product(1,"Iphone X",1000,"China"),
        //         new Product(2,"Sam Sung",900,"China"),
        //         new Product(3,"Sony",1100,"Japan"),
        //         new Product(4,"Nokia",800,"China")
        //     };
        //     Console.WriteLine("======= TIM KIEM PRODUCT 1 KET QUA DUY NHAT =========");
        //     var findProduct = products.Find(x =>
        //     {
        //         return x.Origin == "Japan";
        //     });
        //     if (findProduct != null)
        //     {
        //         Console.WriteLine($"{findProduct.Name},{findProduct.Price},{findProduct.Origin}");
        //     }
        //     Console.WriteLine("======= TIM KIEM PRODUCT TRA RA 1 LIST KET QUA ==========");
        //     var findAllProduct = products.FindAll(x =>
        //     {
        //         return x.Price <= 900;
        //     });
        //     foreach (var product in products)
        //     {
        //         Console.WriteLine($"{product.Name},{product.Price},{product.Origin}");
        //     }
        //
        //     Console.WriteLine("======= TIM KIEM PRODUCT THEO DIEU KIEN BAT DAU VOI CHU  "+ "S" +"  ==========");
        //
        //     var findProductStartWith = products.FindAll(x =>
        //     {
        //         return x.Name.StartsWith("S");
        //     });
        //     foreach (var startWith in findProductStartWith)
        //     {
        //         Console.WriteLine($"{startWith.Name} - {startWith.Price} - {startWith.Origin}");
        //
        //     }
        //     
        //     Console.WriteLine("============= DANH SACH PRODUCT BAN DAU  =============");
        //     foreach (var list in products)
        //     {
        //         Console.WriteLine($"{list.Name} - {list.Price} - {list.Origin}");
        //
        //     }
        //     
        //     Console.WriteLine("======= SAP XEP ==========");
        //     products.Sort((product1, product2) =>
        //     {
        //         if (product1.Price > product2.Price) return 1;
        //         if (product1.Price < product2.Price) return -1;
        //         return 0;
        //     });
        //     
        //     Console.WriteLine("============= DANH SACH PRODUCT SAU KHI SAP XEP  =============");
        //     foreach (var list in products)
        //     {
        //         Console.WriteLine($"{list.Name} - {list.Price} - {list.Origin}");
        //
        //     }
        //     
        //     Console.WriteLine("============================ SORTED LIST ========================");
        //     SortedList<string, Product> sorted = new SortedList<string, Product>();
        //     sorted["sanpham1"] = new Product(1,"Xaomi",1000,"Viet Nam");
        //     sorted["sanpham2"] = new Product(2,"Hono",1500,"Thai lan");
        //     
        //     sorted.Add("sanpham3",new Product(2,"Vivo",1500,"Thai lan"));
        //     var p = sorted["sanpham2"];
        //     
        //
        //     // duyet sorted list
        //     foreach (KeyValuePair<string, Product> items in sorted)
        //     {
        //         var keys = items.Key;
        //         var values = items.Value;
        //         Console.WriteLine($"{keys} - {values.Name}");
        //     }
        // }
    }
}