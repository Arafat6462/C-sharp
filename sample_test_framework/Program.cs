using System;
namespace sample_test_framework
{
    class Program
    {
        private int a;
      /*  Program()
        {
            Console.WriteLine("i'm in default constructor");
        }*/
        Program( int a=0)
        {
            this.a = a;
            Console.WriteLine("i'm in parameterized constructor");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.ReadKey();

        }
    }
}
