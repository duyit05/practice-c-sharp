using System;

namespace LearnCSharp._3_event
{
    public class EventStructure
    {
        class DuLieuNhap : EventArgs
        {
            public int Data { set; get; }
            public DuLieuNhap(int x) => Data = x;
        }

        // Publisher
        class UserInput
        {
            // delegate void KIEU (object ? sender, EventArgs args)
            public event EventHandler SuKienNhapSo;

            public void Input()
            {
                do
                {
                    Console.Write("Nhap vao so nguyen: ");
                    string s = Console.ReadLine();
                    int i = Int32.Parse(s);
                    SuKienNhapSo?.Invoke(this, new DuLieuNhap(i));
                } while (true);
            }
        }

        class TinhCan
        {
            public void Sub(UserInput input)
            {
                input.SuKienNhapSo += Can;
            }

            // delegate void KIEU (object ? sender, EventArgs args)
            public void Can(object sender, EventArgs e)
            {
                DuLieuNhap duLieu = (DuLieuNhap)e;
                int i = duLieu.Data;
                Console.WriteLine($"Can bac 2 cua {i} la {Math.Sqrt(i)} ");
            }
        }

        class TinhBinhPhuong
        {
            public void Sub(UserInput input)
            {
                input.SuKienNhapSo += BinhPhuong;
            }

            public void BinhPhuong(object sender, EventArgs e)
            {
                DuLieuNhap duLieu = (DuLieuNhap)e;
                int i = duLieu.Data;
                Console.WriteLine($"Binh phuong cua {i} la {i * i} ");
            }
        }

        // public static void Main(string[] args)
        // {
        //     UserInput input = new UserInput();
        //     input.SuKienNhapSo += (sender, e) =>
        //     {
        //         DuLieuNhap duLieu = (DuLieuNhap)e;
        //         Console.WriteLine("Ban vua nhap so : " + duLieu.Data);
        //     };
        //
        //     TinhCan tinhCan = new TinhCan();
        //     tinhCan.Sub(input);
        //     TinhBinhPhuong tinhBinhPhuong = new TinhBinhPhuong();
        //     tinhBinhPhuong.Sub(input);
        //     
        //     input.Input();
        // }
    }
}