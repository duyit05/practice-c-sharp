using System;
using System.Linq;
using MyLib;

namespace LearnCSharp._4_ExtensionMethod
{
    static class Abc
    {
        // this ở đây la chi dinh mo rong cho lop nao
        // this string la mo rong cho lop string, this double mo rong cho double....
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
    }

    public class ExtensionMethod
    {
        // public static void Main(string[] args)
        // {
        //     "Xin".Print(ConsoleColor.Cyan);
        //     "Chao".Print(ConsoleColor.DarkRed);
        //     "Cac".Print(ConsoleColor.DarkBlue);
        //     "Ban".Print(ConsoleColor.DarkRed);
        //
        //     double a = 2.5;
        //     Console.WriteLine(a.BinhPhuong());
        //     Console.WriteLine(a.CanBacHai());
        //     Console.WriteLine(a.Sin());
        //     Console.WriteLine(a.Cos());
        //
        // }
    }
}