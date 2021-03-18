using System;

namespace _2nd_class_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            a = Int16.Parse(Console.ReadLine());
            b = Int16.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            if(s=="+")
            {
                Console.WriteLine(a+b);
            } else if(s=="-")
            {
                Console.WriteLine(a-b);
            } if(s=="*")
            {
                Console.WriteLine(a*b);
            } if(s=="/")
            {
                Console.WriteLine(a/(float)b); // type caste for dloat result
            }
            else
            Console.WriteLine("invalid");

            Console.WriteLine(s=="+"? a+b: s=="-"? a-b: s=="*"? a*b : (s=="/"? a/(b+0.0) : "Invalid T")); //same code using ternary operation. (b+0.0) for tyep casting.
            // ?: is a ternary operator. use only exist single line of code and same type output.

            int x = a>5? 7 : (a>9? x=11 : x=0); // for assignment. 

            Console.WriteLine(x);


            // switch case check only equals value. not (> <) comparision operation
            // same condition check for == operation. and depend on one value. like here (s).
            // in c++, java you can't compare string but in c# you can.
            switch(s)
            {
                case "+":
                Console.WriteLine(a+b);
                break;
                
                case "-":
                Console.WriteLine(a-b);
                break;

                case "*":
                {Console.WriteLine(a*b);
                break; }// terminate from this block. due check will not happen.
                        // but in continue skip this iteration and perform next iteration.

                case "/":
               { Console.WriteLine(a/(double)b);
                break;}

                default:
                {Console.WriteLine("invalid");
                break;}
            }



            Console.WriteLine(s=="+"? (a+b).ToString(): "Invalid operation"); // you can convert int to string.
         }
    }
}
