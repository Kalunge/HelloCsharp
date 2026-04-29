using System;

namespace Methods
{
    class Program
    {
        private static string classVariable = "Class Cariable";
        
        public static void Main()
        {
            Console.WriteLine(GetSquare(4));
        }
        
        
        
        static double GetSquare(int num)
        {
            Console.WriteLine(classVariable);
            return Math.Pow(num, 2);
        }
    }
}

