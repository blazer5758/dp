using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            Console.WriteLine("Before swapping:");
            Console.WriteLine("a=" + a+",b=" +b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping:");
            Console.WriteLine("a=" + a+",b=" +b);
        }
    }
}
