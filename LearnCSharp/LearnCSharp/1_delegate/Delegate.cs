using System;

namespace LearnCSharp._1_delegate
{
    public delegate void ShowLog(string message);

    internal class Delegate
    {
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static int Sum(int a, int b) => a + b;
        static int Hieu(int a, int b) => a - b;

        static void Tich(int a, int b, ShowLog log)
        {
            int kq = a * b;
            log?.Invoke($"Tich = {kq}");
        }

        // public static void Main(string[] args)
        // {
        //     ShowLog log = null;
        //     log = Info;
        //     log?.Invoke("Xin chao ABC");
        //     log = Warning;
        //     log("Hoc ve delegate");
        //     
        //     // Delegate kiểu Action và Func
        //     // Action dành cho kiểu trả về void có thể nhận tham so
        //     Action action;                  // delegate void Kieu();
        //     Action<string, int> action1;    // delegate void Kieu(string s, int i);
        //     Action<string> action2;         // delegate void Kieu(string s);
        //     action2 = Warning;
        //     action2 += Info;
        //     action2?.Invoke("Thong bao tu delegate");
        //     
        //     // Func dành cho kiểu có trả về dữ lieu, kiểu tra về duoc liet ke o cuoi cung
        //     Func<int> func;                         // delegate int Kieu();
        //     Func<string, double, string> func1;     // delegate String Kieu(string s, double s);
        //     Func<int, int, int> func2;
        //     int a = 5, b = 5;
        //     func2 = Hieu;
        //     Console.WriteLine($"Tong = {func2(a,b)}");
        //     
        //     Tich(a,b,Info);
        // }
    }

}