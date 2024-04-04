using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
        eded:
            Console.WriteLine("Eded daxil edin:");
            int eded = int.Parse(Console.ReadLine());

            if (eded < 1000)
            {
                Console.WriteLine("minimum dordreqemli eded daxil edilmelidir");
                goto eded;

            }
            int testEded = eded;
            int count=0;
            while (testEded > 0)
            {
                testEded /= 10;
                count++;

            }

            int[] arr = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                int lastNum= eded %10;
                arr[i] = lastNum;
                eded /= 10;
                Console.WriteLine(arr[i]);
            }

        }
    }
}
                      
        






