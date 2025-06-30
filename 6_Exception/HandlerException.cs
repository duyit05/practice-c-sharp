using System;

namespace LearnCSharp._6_Exception
{
    public class HandlerException
    {
        public static void Register(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException();
            }

            if (age > 18 || age < 100)
            {
                throw new AgeValid();
            }

            Console.WriteLine($"Xin chao{name}, tuoi {age}");
        }

        // public static void Main(string[] args)
        // {
        //     try
        //     {
        //         Register("123", 17);
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e.Message);
        //     }
        // }
    }
}