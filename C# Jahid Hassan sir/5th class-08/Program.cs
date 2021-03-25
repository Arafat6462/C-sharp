using System;

namespace _5th_class_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int d =3;
            Add(4,d,d:5, c:4); // named parameter. call 4th parameter insted of 3rd parameter.
                            // but optional parameter must appear after required parameter.
                            // here passed by value type not address.
  
            int a=1,b=2;
            ChangeValue(ref a, ref b);// here pass by refrence(memory address) not value.
            Console.WriteLine("a is : "+a+"\nb is : "+b);

            // swaping
            Swap(ref a,ref b); // for ref: must assign the value of variable before use.
            Console.WriteLine("\n\na is : "+a+"\nb is : "+b);
            
            int x,y;
            Swap2(out x,out y); // for out: must be change on the on method before leave. pre-assigning not mendatory.
          }
        static void Add(int a, int b, int c=0, int d=0){ //optional parameter. you can call with 2,3 or 4 parameter. 
            
            int sum = a+b+(c*1)+(d*4);
            Console.WriteLine(sum);

        }

        static void ChangeValue(ref int a, ref int b){ // change will made in main method's a,b value. ref is kind of modefier, that change behaviour.
            a=5;
            b=6;
        }

        static void Swap(ref int a, ref int b){
            int t=0;
            t=a; // not store address of a in t. "T" sotre value of a.
            a=b;
            b=t;
           
        }
        static void Swap2(out int a, out int b){
            a=5;
            b=5;
          Console.WriteLine("out"+a+" "+b);
        }
        
    }
}
