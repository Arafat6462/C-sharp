using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Addition
    {
       virtual public void Display()
        {
            Console.WriteLine("hello world");
        }
    }
    class Program : Addition
    {
      override   public void Display()
        {
            Console.WriteLine("good bye");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Addition addition = new Addition();
            addition.Display();
            program.Display();

            Console.ReadKey();
        }
    }
}
