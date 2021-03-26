using System;

namespace _6th_class_09
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            int a = Int32.Parse(Console.ReadLine());
            }
            catch(Exception){
                Console.WriteLine("something wrong happen ");
            }

            // try parse.
            string input = Console.ReadLine();
            int b;
            bool boo = Int32.TryParse(input, out b);// 1st input = try to convert and 2dn b = where to store. method return boolean out put & out change variable value. techancally method return multiple output.
            Console.WriteLine("ok "+boo+"  "+b); // boo = true/false and b = value of possiable.  
          
            // try parse in another way. if you don't want to use try catch
            if(Int32.TryParse(input, out b) == false)
                    Console.WriteLine("can't parse the input. ");
            else
            Console.WriteLine("parse input succesfully. ");



            // array.
            int[] array = new int[5]; // to declare reference type variable use new keyword. allocate memory in runtime.
                                     // in compile time memory allocation all fixed before code run. and for run time all fefine when code is running.
                                     // compile time like packed food. don't care if you need any more or not.  and run time like buffe/unlimited as much as you can take.

            
            int[] array2 = {3,4,5,6,7,7}; // if you don't want to use new, the initialize when declare. length will be size of input initialization.

            array[3]=4;
            Console.WriteLine("array is : {0} {1} ",array[array.Length-1], array2[4]);
          

          // for-each loop
          foreach(var arr2 in array2){  // define a variable of type array. or dynamic var type. 
                                       //  all array value will store on thar variable one by one. so, print that variable. 
            
              Console.WriteLine(arr2); // print the variable that declare in foreach loop and hold each array element.
                                      // don't have index access. use it where index don't needed.
          }

        Console.WriteLine("\n"+array2[0]); // out-put = 3
        ChangeValue(array2);
        Console.WriteLine(array2[0]);  // out-put = 4o4. because array is a referance type variable. so, pass by referance happen without ref,out.

          }

          static void ChangeValue(int[] a){
              a[0] = 404;
          }
    }
}
