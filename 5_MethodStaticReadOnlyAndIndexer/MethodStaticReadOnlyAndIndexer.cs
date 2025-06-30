using System;

namespace LearnCSharp.MethodStaticReadOnlyAndIndexer
{
    class CountNumber
    {
        public static int number = 0;
        public static void Info()
        {
            Console.WriteLine("So lan truy cap: " + number);
        }

        public void Count()
        {
            CountNumber.number++;
           
        }
    }

    class Student
    {
        public readonly string name; // readonly chỉ đọc
        public Student(string name) => this.name = name;
    }

    class Vector
    {
        double x;
        double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Info() => Console.WriteLine($"x = {x} , y = {y}");
        
        // + 
        public static Vector operator+(Vector v1, Vector v2)
        {
            // return new Vector(v1.x + v2.x, v2.y + v2.y);
            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            return new Vector(x, y);
        }
        
        public static Vector operator+(Vector v1, double v2)
        {
            // return new Vector(v1.x + v2.x, v2.y + v2.y);
            double x = v1.x + v2;
            double y = v1.y + v2;
            return new Vector(x, y);
        }
        
        // tao indexer [chi so]
        // dung tu this tra ve kieu du kieu cung kieu voi thuoc tinh cua object
        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
            
            get
            {
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
        }
        
        public double this[string s]
        {
            set
            {
                switch (s)
                {
                    case "toadox":
                        x = value;
                        break;
                    case "toadoy":
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
            
            get
            {
                switch (s)
                {
                    case "toadox":
                        return x;
                    case "toadoy":
                        return y;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
        }
    }
    public class MethodStaticReadOnlyAndIndexer
    {
        // public static void Main(string[] args)
        // {
        //     CountNumber c1 = new CountNumber();
        //     CountNumber c2 = new CountNumber();
        //     
        //     c1.Count();
        //     c2.Count();
        //     CountNumber.Info();
        //
        //     Student student = new Student("Nguyen Van Duy");
        //     Console.WriteLine(student.name);
        //
        //     Vector v1 = new Vector(2, 3);
        //     Vector v2 = new Vector(1, 1);
        //     var v3 = v1 + v2;
        //     v1.Info();
        //     v2.Info();
        //     v3.Info();
        //     
        //     // quá tải du lieu
        //     Vector vectorData = new Vector(5,6);
        //     vectorData[0] = 10;
        //     vectorData[1] = 11;
        //     vectorData.Info();
        //     Console.WriteLine(vectorData["toadox"]);
        //
        // }
    }
}