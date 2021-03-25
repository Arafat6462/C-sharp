using System;

namespace _4th_class_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           
           Console.WriteLine(Addition(2,2));
           Console.WriteLine(Addition(Int32.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine()))); // taking two input and call a method in writeline method.
           double m = Multi(3,3,2);
           Console.WriteLine(m);
           
              m = Multi(10,3);
           Console.WriteLine(m);
           Console.WriteLine("addition is : "+Addition(2,3));
        }


           // Function
         // return_type FunctionName (parameter List){}
        static int Addition(){
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());

            int sum = x + y;

            return sum;
           // Console.WriteLine(sum);
        }

        // static int Addition(int a, int b){ // (method signature = name + parameter list or type). not return type.
        //     Console.WriteLine("Addition with 2 parameter");
        //     return a+b;
        // }  
        // static int Addition(int a, int b, int c=0){
        //          Console.WriteLine("Addition with 3 parameter");

        //     return a+b+c;
        // } 
         static int Addition(int a, int b, int c=0, int d=0){ // optional parameter. you can call wit 2,3 or 4 parameter. but if there multiple method fo optional parameter 
                                                             // and you call then there was a confilct to wich on call
                                                             // optional parametrs must appear agter all required patameters.
                                                             // for multiplication in optional param set 1 not 0
                                                             // and for string empty or null

               Console.WriteLine("Addition with 4 parameter");

            return a+b+c+d;
        }

        static double Multi(int a, int b, int c){
          //  Console.WriteLine("Addition with 4 parameter");

            return (double)a*b/(c+0.0); // type casting int to double
        }

        static double Multi (int a, int b){ // method overloading. 2 Multi method but diff parameter list.

            return (double)a/b;
        }
    }
}
