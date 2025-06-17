using System;

namespace LearnCSharp._6_Exception
{
        public class NameEmptyException : Exception
        {
            public NameEmptyException() : base("Ten phai khac rong")
            {
            }
        }

        public class AgeValid : Exception
        {
            public AgeValid() : base("Tuoi phai lon hon 18 va nho hon 100")
            {
                
            }
        }
}