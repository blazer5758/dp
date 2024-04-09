using System;
namespace hloo
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int n, i, j, tmp;
            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the elements:\n", n);
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        Console.Write("Elements in ascending order:\n");
        for (i = 0; i<n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
         
            Console.Write("\nElements in descending order:\n");
            for (i = n-1; i>=0; i--)
            {
                Console.Write("{0}  ", arr[i]);
            }
         Console.Write("\n");
        }
    }
}
