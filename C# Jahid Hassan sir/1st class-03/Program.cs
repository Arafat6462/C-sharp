using System;

namespace _1st_class_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // console is a predifine class in .net framework. WriteLine is static method.
            String s = Console.ReadLine(); // Take input as string.
            Console.WriteLine(s);

         int b =0 ,c=0;
         float d =0;

        try{  // try to do that code. if not possible then goto catch.
                // use try catch only when you uncertain the result.
              b = Convert.ToInt16(s);
              c = Int32.Parse(s);
              d = float.Parse(Console.ReadLine()); // take input as string and parse as a float.
            }
        catch(Exception ){
            Console.WriteLine("invalid input : ");
        }
            
           Console.WriteLine(b);
           Console.WriteLine(c);

            Console.Write("salary amount : ");

             try{
             double bonus = float.Parse(Console.ReadLine());
             Console.WriteLine("bonus is : {0} tk",bonus*.6); // {0} is a place holder. insind place holder first result after , will set.

             Console.WriteLine("enter the salary for seccond user : \n second bonuse is : {0}",Int16.Parse(Console.ReadLine())*.6); // here first call readLine then WriteLine.
            }
            catch(Exception){
                Console.WriteLine("invalid input");
            }
            Console.WriteLine("Helllo {0} , {1} , {2} ","Arafat", "Hossain", "Nipu"); // place holder.
            
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine(x%2==0? "enve": "odd"); // ternary operation. if true print first "even" or false = 2nd on "odd".

            Console.WriteLine(x%3==0? "Divided by 3": x%5 == 0? "Divided by 5": "");

            Console.WriteLine(x%4 == 0? "divided by 4" : x%6 ==0? "divided by 6": "invalid number" );
            
            if(x%5 ==0)
            Console.WriteLine("Divided by 5");
           A.B();
        }
    }
 
     class A{
       public  static void B(){

        }
    }
}
 