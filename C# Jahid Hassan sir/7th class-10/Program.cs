using System;

namespace _7th_class_10
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[,] array = new int[5,7]; // predifine multi-dimentional array. here 2D array. Row*Column.
                                        // here 2D array [5,7] astually is, indivisual five 1D/single array with column 7.
                                      //   [5,] here 5 store different five pointer, and that pointer angain point single array with lingth 7.

            array[1,2] = 5; // row = 1, column = 2 is assign as 5;


            // taking input of 2D array.
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                   // array[row,column] = Int32.Parse(Console.ReadLine());
                }
            }

            // jagged array.
            int[][] jaggedArray = new int[3][]; // jagged array is for "diff column for each row."
                                              // do't declare column. because for each row, column-number is different.
             
             jaggedArray[0] = new int[2]; // jaggedArray[0] or 1d-array[0] with length/column = 2. 
             jaggedArray[1] = new int[5]; 
             jaggedArray[2] = new int[Int32.Parse(Console.ReadLine())]; // dynamic declaration.
              

               // taking input of jagged array.
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < jaggedArray[row].Length; column++) // here we can't use "column" like 2D array. because in jagged array for each row column is different.
                                                                                // so, use jaggedArray[Row.Length]. length/column of that particular row
                {
                //    jaggedArray[row][column] = Int32.Parse(Console.ReadLine());
                }
            }
            
              //  Console.WriteLine("longth is : "+jaggedArray.Length); // out-put is number of row = 3.
               
               
             // output of jagged array.
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine("\n\nclass {0} :",row);
                for (int column = 0; column < jaggedArray[row].Length; column++) // here we can't use "column" like 2D array. because in jagged array for each row column is different.
                                                                                // so, use jaggedArray[Row.Length]. length/column of that particular row
                {
                   //  Console.Write(jaggedArray[row][column]+"\t");
                }
            }




            ///// string

            string name = "Arafat";
            Console.WriteLine(name);
            Console.WriteLine(name.ToLower());  // for lower case
            Console.WriteLine(name.ToUpper()); // for upper case

            if(name == "nipu")
            Console.WriteLine("match"); 
            
            if(name == Console.ReadLine())
            Console.WriteLine("match");

            if(name.ToUpper() == Console.ReadLine().ToUpper()) // both convert to uppercase for match by case insensetive.
            Console.WriteLine("match");

            Console.WriteLine("s : ");
            string s = Console.ReadLine();

            if(s.ToUpper().Contains("NI")) // check if "NI" contain in string.
            {
                Console.WriteLine("contain");
                int index = s.ToUpper().IndexOf("NI"); // show the index of first ni.
                Console.WriteLine(index);
                Console.WriteLine(s.ToUpper().LastIndexOf("NI"));  // show the index of last ni.

            }
            Console.WriteLine(s.ToUpper().IndexOf("helasod")); // if not found then index will -1.

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);   // print char by char. all this thik possible because of string is char type array.
            }

            // print only voual from s
            Console.WriteLine("\n\nvouals : ");
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].ToString().ToLower() == "a" || s[i].ToString().ToLower() == "e".ToString().ToLower() ||
                 s[i].ToString().ToLower() == "i".ToString().ToLower() || s[i].ToString().ToLower() == "o".ToString().ToLower() || 
                 s[i].ToString().ToLower() == "u") // to use to "ToUppercase" first convert to in string with "ToString".
                                                 //   and for 'a'=c har and "a" = string.
                Console.WriteLine(s[i]);
            }
            
            
            // another way to print only voual from s
            Console.WriteLine("\n\nvouals : ");
            string check = "aeiouAEIOU";    
            int worldInS =0;
            for (int i = 0; i < s.Length; i++)
            {
                if(check.Contains(s[i]))
                Console.WriteLine(s[i]);

                if(!check.Contains(s[i]))
                Console.WriteLine("cONS : "+s[i]);

                if(s[i] == ' ') // counting word.
                worldInS ++;
                  
            }

            Console.WriteLine("char of s : "+s.Length);
            Console.WriteLine("word in s is {0} ",(worldInS+1));

            var store = s.Split(' '); // find word by the ' ' space seperated string. and store all word in store variable like string array.

            foreach(var v in store){
                Console.WriteLine(v); // print all word stored in store . and store variable is a array.
            }

            Console.WriteLine("word in string : "+store.Length); // simply find the word in string.


            // substring
            string sub = "arafat hossain";
            Console.WriteLine("substring is : "+sub.Substring(5)); // print all cahr after 5th char.
            Console.WriteLine("substring is : "+sub.Substring(5,3)); // print all cahr starting from 5 to next 3 char. 1st parameter is starting and 2nd parameter is how length.


            // take aiub id and print id details:
            Console.WriteLine("enter your aiub id : ");
            string id = Console.ReadLine();
            var iid = id.Split('-');
            Console.WriteLine("Year : "+iid[0]);
            Console.WriteLine("student no : "+iid[1]);
            Console.WriteLine("semester : "+ (iid[2] == "1"? "spring" : iid[2]=="2"? "summer" : iid[2] == "3"? "fall": "invalid"));// using ternary operation.

            // checking
            if(iid.Length!=3 || iid[0].Length!=2 || iid[1].Length!=5 || iid[2].Length!= 1)  // checking by speliting.
            Console.WriteLine("invalid id !!!");
        }
    }  
}
