using System;

namespace _2nd_class_05
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<10; i++){ // 1.initialization(Int i=0), 2.condition(i<5), 3.value changing formula(i+=1).
                                    // work as 1-> 2-> loop-> 3-> 2-> loop-> 3-> 2-> loop.....
           // Console.WriteLine("even");
            }
             
            int j =0;
            while(j<10){
               // Console.WriteLine("love you");
                j++;
            }

            int k = 10;
            for(int i =1; i<=5 && k>=0; i++) // you can add multiple condition on for loop :)
            {
                Console.WriteLine(i+"\t"+(6-i));
                k--;
            }

            for(int i=0,p=5; i<5 && p>0; i++,p--) // you can add multiple things in for loop.
            {
                Console.WriteLine(i+1 +"\t"+ p);
            }

            int ii =0;
           // for(Console.WriteLine("for loop"); ii<5; ii++){}

            int jj=0;
            for(;jj<10;) // fon't necessaryly to declare all .
            {
                
                jj++;
            }


            for(int m=0; m<10; m++){
                if(m%2!=0)
                continue; // continue means. compiler think continue is the last line of that code.

              //  Console.WriteLine("even");
            }

            // xoxo
            // oxox
            // xoxo
            // oxox
            for(int i=0; i<20; i++){
                for(int c=0; c<50; c++){

                    if(i%2==0){
                        Console.Write(c%2==0? "x": "o");
                    }
                    else
                    {
                      Console.Write(c%2!=0? "x": "o");
 
                    }
                }
                Console.WriteLine();
            }

            
        }
    }
}
