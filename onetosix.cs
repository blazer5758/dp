1)a)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the ending range:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All even numbers from 1 to {0} are ", n);
            evenodd(2, n);
            Console.WriteLine("\nAll odd numbers from 1 to {0} are ", n);
            evenodd(1, n);
            Console.WriteLine("\n");
            return;
        }
        static void evenodd(int stval,int n)
        {
            if (stval > n)
                return;
            Console.Write("{0} ", stval);
            evenodd(stval + 2, n);
        }
    }
}
1.b)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;
            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the elements:\n", n);
            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("Elements in ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i]<arr1[j])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements in descending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
         Console.Write("\n");
        }
    }
}

2)
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

3)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication7
{
    class Box{
        private double length;   
        private double breadth;  
        private double height;   
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();   
            Box Box2 = new Box();   
            Box Box3 = new Box();   
            double volume = 0.0;   
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);
            Box3 = Box1 + Box2;
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
        }
    }
}
4)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication9
{
    interface polygon
    {
        void area();
    }
    class rectangle : polygon
    {
        public void area()
        {
            int l = 20;
            int b = 30;
            int area = l * b;
            Console.WriteLine("The area of rectangle is " + area);
        }
    }
    class square : polygon
    {
        public void area()
        {
            int l = 20;
            int area = l * l;
            Console.WriteLine("The area of square is " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle();
            r1.area();
            square s1 = new square();
            s1.area();
        }
    }
}

5.a)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "CoMpuTer";
            String s2 = " science";
            Console.WriteLine("The length of the string is " + s1.Length);
            Console.WriteLine("The concatenation of the string is " + String.Concat(s1, s2));
            Console.WriteLine("The comparison of two string is " + String.Compare(s1, s2));
            String s3 = String.Copy(s1);
            Console.WriteLine("Copying the string:" + s3);
            Console.WriteLine("Startwith:" + s2.StartsWith("S"));
            Console.WriteLine("Endswith:" + s1.EndsWith("r"));
            Console.WriteLine("Remove:" +s1.Remove(2,4));
            Console.WriteLine("Replace:" + s2.Replace("e","o"));
            Console.WriteLine("Substring:" + s1.Substring(3));
            Console.WriteLine("Lowercase:" +s1.ToLower());
            Console.WriteLine("Uppercase:" + s2.ToUpper());

        }
    }
}
b)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] number = { 8, 17, 24, 5, 25 };
                int[] divisor = { 2, 0, 0, 5 };
                for (int j = 0; j < number.Length; j++)
                    try
                    {
                        Console.WriteLine("Quotient: " + number[j] / divisor[j]);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Not possible to Divide by zero");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index is Out of Range");
                    }
            }
      }
}
6)
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
