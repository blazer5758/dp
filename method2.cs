using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication5
{
    class Program
    {
        public static void area(int x,int y)
        {
            Console.WriteLine("Area=" + x * y);
        }
        public static void area(double x, double y)
        {
            Console.WriteLine("Area=" + x * y);
        }
        static void Main(string[] args)
        {
            area(10, 20);
            area(2.5, 2.5);
        }
    }
}
