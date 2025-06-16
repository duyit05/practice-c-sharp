using System;
using System.Linq;

namespace LearnCSharp._2_lamda
{
    public class Lambda
    {
        /*
         cách 1:
         (tham_so) => bieu_thuc

         cách 2:
         (tham_so) => {
           cac_bieu_thuc
           return bieu_thuc_tra_ve
         }
         */
        // public static void Main(string[] args)
        // {
        //     // viet day du
        //     Action<string> actionDayDu;
        //     actionDayDu = (string s) => Console.WriteLine(s);
        //     actionDayDu.Invoke("Lambda viet day du");
        //
        //     // Viet tat
        //     Action<string> actionVietTat;
        //     actionVietTat = s => Console.WriteLine(s);
        //     actionVietTat.Invoke("Lamdba viet tat");
        //
        //     // Khi co nhieu tham so
        //     Action<string, string> actionVietTatNhieuThamSo;
        //     actionVietTatNhieuThamSo = (s, x) => Console.WriteLine(s + " " + x);
        //     actionVietTatNhieuThamSo.Invoke("Day la lambda", "viet tat nhieu tham so");
        //
        //     Console.WriteLine("1.====================================================.1");
        //     // Lambda co nhieu bieu thuc va tra ve kieu du lieu
        //     Func<int, int, int> calculator;
        //     calculator = (a, b) =>
        //     {
        //         int result = a + b;
        //         return result;
        //     };
        //     Console.WriteLine($"{calculator.Invoke(5, 6)}");
        //     Console.WriteLine("1.====================================================.1");
        //
        //     Console.WriteLine("2.====================================================.2");
        //     int[] array = { 2, 4, 64, 5, 7, 8, 9, 33, 55 };
        //     var kq = array.Select((int x) => { return Math.Sqrt(x); });
        //     foreach (var result in kq)
        //     {
        //         Console.WriteLine(result);
        //     }
        //
        //     Console.WriteLine("2.====================================================.2");
        //
        //     Console.WriteLine("3.====================================================.3");
        //     array.ToList().ForEach(x =>
        //         {
        //             if (x % 2 != 0)
        //                 Console.WriteLine(x);
        //         }
        //     );
        //     Console.WriteLine("3.====================================================.3");
        //
        //     Console.WriteLine("4.====================================================.4");
        //     var resultWhere = array.Where(x => { return x % 4 == 0; });
        //     foreach (var item in resultWhere)
        //     {
        //         Console.WriteLine(item);
        //     }
        //     Console.WriteLine("4.====================================================.4");
        // }
    }
}