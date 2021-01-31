using System;
 
namespace firstExample_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("enter a number please : ");

            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((i+1) + " " + (i+2) + " " + (i+3));

             Console.ReadKey();
        }
    }
}
