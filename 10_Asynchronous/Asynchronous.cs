using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharp._10_Asynchronous
{
    // bat dong bo
    public class Asynchronous
    {
        static void DoSomeThing(int seconds, string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{msg,10} ....Start");
            Console.ResetColor();
            for (int i = 0; i <= seconds; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,10} {i,2}");
                Console.ResetColor();
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = color;
            Console.WriteLine($"{msg,10} ....End");
            Console.ResetColor();
        }

        static async Task Task2()
        {
            Task t2 = new Task(() =>
            {
                DoSomeThing(10,"T2", ConsoleColor.DarkBlue);
            });
            t2.Start();
            await t2;
            Console.WriteLine("T2 DONE");
        }

        static async Task Task3()
        {
            Task t3 = new Task((object obj) =>
            {
                string tentacvu = (string)obj;
                DoSomeThing(4,"T3",ConsoleColor.DarkCyan);
            },"T3");
            t3.Start();
            await t3;
            Console.WriteLine("T3 DONE");
        }
        // public static void Main(string[] args)
        // {
        //     // asynchronous
        //     // Task
        //     Task t2 = Task2();
        //     Task t3 = Task3();
        //     
        //   
        //     DoSomeThing(6, "T1", ConsoleColor.Magenta);
        //
        //
        //     Task.WaitAll(t2, t3);
        //     Console.WriteLine("Hello World");
        //     Console.ReadKey();
        // }
    }
}