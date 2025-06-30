using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp._11_LinQ
{
    public class LinQ
    {
        // public static void Main(string[] args)
        // {
        //     List<Brand> brands = new List<Brand>()
        //     {
        //         new Brand(1, "Cong Ty AAA"),
        //         new Brand(2, "Cong Ty BBB"),
        //         new Brand(3, "Cong Ty CCC")
        //     };
        //
        //     List<Product> products = new List<Product>()
        //     {
        //         new Product(1, "Bàn Trà", 400, new string[] { "Xám", "Xanh" }, 5),
        //         new Product(2, "Tranh Treo", 400, new string[] { "Vàng", "Xanh" }, 1),
        //         new Product(3, "Đèn Trùm", 500, new string[] { "Trắng" }, 3),
        //         new Product(4, "Bàn Học", 200, new string[] { "Trắng", "Xanh" }, 1),
        //         new Product(5, "Túi da", 300, new string[] { "Đỏ", "Đen", "Vàng" }, 2),
        //         new Product(6, "Giường Ngủ", 500, new string[] { "Trắng" }, 2),
        //         new Product(7, "Tủ Áo ", 600, new string[] { "Trắng" }, 3)
        //     };
        //
        //     // SELECT
        //     // var result = products.Select((p) =>
        //     // {
        //     //     return p.Price;
        //     // });
        //     // foreach (var p in result)
        //     // {
        //     //     Console.WriteLine(p);
        //     // }
        //
        //     // WHERE
        //     // var result = products.Where((p) =>
        //     // {
        //     //     return p.Price >= 200 && p.Price <= 300;
        //     //
        //     // });
        //     // foreach (var p in result)
        //     // {
        //     //     Console.WriteLine(p);
        //     // }
        //
        //     // Min, Max, Sum, Average
        //     // var result = products.Min(product => product.Price);
        //
        //
        //     // Join
        //     // var result = products.Join(brands , p => p.Brand, b => b.Id , (p, b) =>
        //     // {
        //     //     return new
        //     //     {
        //     //         Ten = p.Name,
        //     //         ThuongHieu = b.Name
        //     //     };
        //     // });
        //     // foreach (var p in result)
        //     // {
        //     //     Console.WriteLine(p);
        //     // }
        //
        //     // GroupJoin
        //     // var result = brands.GroupJoin(products, b => b.Id, p => p.Brand, (b, p) =>
        //     // {
        //     //     return new
        //     //     {
        //     //         ThuongHieu = b.Name,
        //     //         CacSanPham = p
        //     //     };
        //     // });
        //     // foreach (var b in result)
        //     // {
        //     //     Console.WriteLine(b.ThuongHieu);
        //     //     foreach (var p in b.CacSanPham)
        //     //     {
        //     //         Console.WriteLine(p);
        //     //     }
        //     // }
        //
        //     // TAKE => lấy ra số luong san pham dau tien 
        //     // products.Take(3).ToList().ForEach(p => Console.WriteLine(p));
        //
        //     // Skip => bỏ qua so luong phan tu dau tien
        //     // products.Skip(2).ToList().ForEach(p => Console.WriteLine(p));
        //
        //     // Orderby => Sap xep tang dan / OrderbyDescending => Sap xep giam dan
        //     // products.OrderBy(p=> p.Price).ToList().ForEach(p=> Console.WriteLine(p));
        //
        //     // Reverse => Dao nguoc => chi dung cho mang so
        //
        //     // GroupBy => Nhom gia tri theo 1 dieu kien nao do
        //
        //     // var result = products.GroupBy(p => p.Price);
        //     // foreach (var group in result)
        //     // {
        //     //     Console.WriteLine($" So luong san pham gia: {group.Key}");
        //     //     int count = 0;
        //     //     foreach (var p in group)
        //     //     {
        //     //         Console.WriteLine(p);
        //     //         count++;
        //     //     }
        //     //     Console.WriteLine($"Tong so luong san pham gia {group.Key} la: {count}");
        //     // }
        //
        //     // Distinct => Loai bo gia tri trung lap
        //
        //     // products.SelectMany(p => p.Colors)
        //     //     .Distinct().ToList()
        //     //     .ForEach(p => Console.WriteLine(p));
        //
        //     // Single => ko tim thay gia tri se  nem ra exception, SingleOrDefault => ko tim thay gia tri thi tra ra null
        //     // var result = products.Single(p => p.Price == 600);
        //     // Console.WriteLine(result);
        //
        //     // Any => tra ve true neu dung, false neu sai
        //     // var result = products.Any(p => p.Price==00);
        //     // Console.WriteLine(result);
        //
        //     // All => Kiem tra xem tat ca gia => 200 hay khong, tra ve true false
        //     // var result = products.All(p => p.Price >= 300);
        //     // Console.WriteLine(result);
        //
        //     // Count 
        //     // var result = products.Count(p => p.Price >= 300);
        //     // Console.WriteLine($"Gia lon hon 300 la: {result}");
        //
        //     var result =
        //         products.Join(brands, p => p.Brand, b => b.Id,
        //                 (product, brand) =>
        //                 {
        //                     return new
        //                     {
        //                         TenSanPham = product.Name,
        //                         TenThuongHieu = brand.Name,
        //                         GiaGiamDan = product.Price
        //                     };
        //                 })
        //             .OrderByDescending(p => p.GiaGiamDan)
        //             .Where(p => p.GiaGiamDan >= 300 && p.GiaGiamDan <= 400);
        //
        //     foreach (var product in result)
        //     {
        //         Console.WriteLine(product);
        //     }
        //
        //     Console.WriteLine("==================== TRUY VAN LINQ CO BAN ========================");
        //
        //     Console.WriteLine("=============== TRUY VAN LAY RA TEN CUA PRODUCT ===================");
        //     var query = from p in products select p.Name;
        //     foreach (var qr in query)
        //     {
        //         Console.WriteLine(qr);
        //     }
        //
        //     Console.WriteLine("=============== TRUY VAN LAY PRODUCT CO PRICE >= 400 ===================");
        //     var query1 = from p in products
        //         where p.Price >= 400
        //         select new
        //         {
        //             Ten = p.Name,
        //             Gia = p.Price
        //         };
        //     query1.ToList().ForEach(product => Console.WriteLine(product));
        //
        //     Console.WriteLine("=============== TRUY VAN LAY PRODUCT CO COLOR LA MAU XANH ===================");
        //     var query2 =
        //         from p in products
        //         from color in p.Colors
        //         where p.Price <= 500 && color == "Xanh"
        //         orderby p.Price ascending
        //         select new
        //         {
        //             Ten = p.Name,
        //             Gia = p.Price,
        //             CacMau = p.Colors
        //         };
        //     query2.ToList().ForEach(p => Console.WriteLine($"{p.Ten} - {p.Gia} - {string.Join(",", p.CacMau)}")
        //     );
        //
        //     Console.WriteLine("=============== TRUY VAN LAY PRODUCT NHOM THEO PRICE ===================");
        //     var query3 =
        //         from p in products
        //         group p by p.Price
        //         into gr // tu khoa into de luu bien tam thoi
        //         orderby gr.Key ascending
        //         select gr;
        //
        //     query3.ToList().ForEach(group =>
        //     {
        //         Console.WriteLine(group.Key);
        //         group.ToList().ForEach(p => Console.WriteLine(p));
        //     });
        //
        //     Console.WriteLine(
        //         "=============== TRUY VAN LAY PRODUCT NHOM THEO PRICE SU DUNG TU KHOA let ===================");
        //     var query4 = from p in products
        //         group p by p.Price
        //         into gr
        //         orderby gr.Key
        //         let sl = "So luong la: " + gr.Count()
        //         select new
        //         {
        //             Gia = gr.Key,
        //             CacSanPham = gr.ToList(),
        //             SoLuong = sl
        //         };
        //     query4.ToList().ForEach(group =>
        //     {
        //         Console.WriteLine(group.Gia);
        //         Console.WriteLine(group.SoLuong);
        //         group.CacSanPham.ToList().ForEach(p => Console.WriteLine(p));
        //     });
        //
        //     Console.WriteLine("=============== TRUY VAN LAY PRODUCT VA BRAND SU DUNG JOIN ===================");
        //     var query5 =
        //         from product in products
        //         join brand in brands  
        //             on
        //             product.Brand equals brand.Id into t
        //             from b in t.DefaultIfEmpty()
        //         select new
        //         {
        //             TenSanPham = product.Name,
        //             Gia = product.Price,
        //             TenThuongHieu = (b != null) ? b.Name : "No Brand"
        //         };
        //     query5.ToList().ForEach(p => Console.WriteLine(p));
        // }
    }
}