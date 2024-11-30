using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
         int b = 10;
            Console.WriteLine($"Before swappping the value of a= {a} and b={b}");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"After swapping the value of a= {a} and b={b}");
       }
    }
}
