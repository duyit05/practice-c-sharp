using System;

namespace LearnCSharp._3_event
{
    /*
     publisher -> class -> phat su kien
     subscriber -> class -> nhan su kien
     */
    public delegate void SuKienNhapSo(int x);

    class UserInput
    {
        public event SuKienNhapSo SuKienNhapSo;

        public void Input()
        {
            do
            {
                Console.Write("Nhap vao so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phat su kien
                SuKienNhapSo?.Invoke(i);
            } while (true);
        }
    }

    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.SuKienNhapSo += Can;
        }
        public void Can(int i)
        {
            Console.WriteLine($"Can bac 2 cua {i} la {Math.Sqrt(i)}");
        }
    }

    class TinhBinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.SuKienNhapSo += BinhPhuong;
        }

        public void BinhPhuong(int i)
        {
            Console.WriteLine($"Binh phuong cua {i} la {i * i}");
        }
    }

    public class EventConcept
    {
        // public static void Main(string[] args)
        // {
        //     // publisher
        //     UserInput user = new UserInput();
        //     user.SuKienNhapSo += x =>
        //     {
        //         Console.WriteLine("Ban vua nhap so: " + x);
        //     };
        //
        //     // subscriber
        //     TinhCan tinhCan = new TinhCan();
        //     tinhCan.Sub(user);
        //     TinhBinhPhuong tinhBinhPhuong = new TinhBinhPhuong();
        //     tinhBinhPhuong.Sub(user);
        //     
        //     
        //     user.Input();
        // }
    }
}