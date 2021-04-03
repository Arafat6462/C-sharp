using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a[0] = "AIUB";
            a[1] = "BUET";
            a[2] = "NSU";

            for(int i=0; i<5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }

    public class A
    {
        private string[] arr = new string[5];

        // indexer

        public string this[int i]
        {
            set
            {
                arr[i] = value;
            }
            get
            {
                return arr[i];
            }
        }
    }

    public class B
    {
        private string
    }
}
