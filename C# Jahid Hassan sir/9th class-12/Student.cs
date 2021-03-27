using System;
 
namespace _9th_class_12
{
class Student
    {
        private string name;    // member field = if you declare some variable inside class the those variable are called member field.
        private string id;    
        private double cgpa;  // default member field's are private.
        private int creditCompleted;

        public Student(string name, string id, double cgpa, int creditCompleted)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.creditCompleted = creditCompleted;
        }

        //get
        public string GetId() // why i put id private and privide a public method to acces id...?
                             // if i took id public, then any one can access and modify it directly. but here took it public but
                             // i can control who can access or change the value with logic. though it public, you can't directly
                             // change it. you have to access id by method. when this public method give you access only then you can change it.
        {
            return this.id;
        }


        // set
        public void SetId(string id)
        {
            if(string.IsNullOrEmpty(id)) // "tring.IsNullOrEmpty()" check weather it null or empty.
            { 
                Console.WriteLine("invalid id");
                return;
            }
            this.id = id;
        }



        // proparty like as variable/member but work as a method/property.
        public string Name // it's a read and write property. if only set exist = "write only property" and for only get="read only property"
        { 
            set // set accessor only accept one parameter and store in variable "value"
             {
                 if(string.IsNullOrEmpty(value))
                 {
                  Console.WriteLine("invalid name");
                  return;
                 }
                 name=value; 
             }
          get // get accessor and set condition on return
           {
               if(name.Length<3)
               {
                   Console.WriteLine("to shoet");
               }
                return name;
           }   
        }

        public double Cgpa{ set=>cgpa=value; } // write only property.
        public int CreditCompleted{ set=>creditCompleted=value; get=>creditCompleted;}
    }
}