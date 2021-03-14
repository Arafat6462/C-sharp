using System;
namespace sample_test_framework
{
    class Program
    {

        static int[] jobNumber = new int[5];
        static int number;
        public static int TakeInputJobNumber(Object obj, int jobIndex)
        {
            Console.Write(obj);
              number = Convert.ToInt32(Console.ReadLine());

            // is number already exist in array
            for (int i = 0; i < jobIndex; i++)
            {
                if (jobNumber[i] == number)
                {
                    TakeInputJobNumber("Please enter job Number again : ", jobIndex);
                }
            }

            jobNumber[jobIndex] = number;
            return number;
 
        }
        static void Main(string[] args)
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine(TakeInputJobNumber("Input : ", i));    
            }

            Console.WriteLine("\n-----------");
            for (int i=0; i<jobNumber.Length; i++)
            {
                Console.WriteLine(jobNumber[i]);
            }
            Console.ReadKey();
        }
    }
}
