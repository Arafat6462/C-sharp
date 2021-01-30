using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello arafat sdfdd");

            method(4);

    
        }

        static void method(int a)
        {
            Console.WriteLine(a % 2 == 0 ? "even"  : "odd");
        }
    }
}
