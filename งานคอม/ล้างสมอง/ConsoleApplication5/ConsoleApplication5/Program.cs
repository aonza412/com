using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    
    class Program
    {
        public int[] a = { 12, 34, 45, 67, 89 };
        static void Main(string[] args)
        {
            MathCalculation math = new MathCalculation();
            Console.WriteLine(math.Max());
            Console.WriteLine(math.Min());
        }
    }
    class MathCalculation
    {
        Program b = new Program();
        public int Max()
        {
            return  b.a.Max();
        }
        public int Min()
        {
            return b.a.Min();
        }
        public int Aerage()
        {
            for (int i = 0; i<= b.a.Length; i++)
            {
                int sum = 0;
                sum += b.a[i];
            }
            int sum2 = sum;
            return 
        }

    }
    

}
