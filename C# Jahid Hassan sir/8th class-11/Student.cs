using System;
namespace _8th_class_11
{
  public  class Student // custome data type. 
                // default class access modifier = internal.
    {

// public     : common ground floor toilet of a buliding. that can access anyone. (from any where)
// internal   : common toilet of an appartment. that can access only who can enter the appartment. (only inside the project)
// private    : attach toilet of a bed room. tha can access only himself/herself or owner. non of them can access.(only inside the same class)
// protected  : your child can access you bed attach private toilet. youc child get this access by inheritance.(this class + inharitated class)



                         // class and structure are user define data type.
                        // let's say a student has 6 property (2 string, 1 double, 2 int, 1 bool). and i want this for 40 student.
                       // so, i need 40*6=240 variable and need to remember it all :(
                      // in this situation you can use class and structure. 
      
                   // class is a reference type and struct is value type.
                   // here Student(class name) is a data type. :). you can create a variable of data type Student that is call object.
      
 
        private string name;    // member field = if you declare some variable inside class the those variable are called member field.
        private string id;    
        private double cgpa;  // default member field's are private.
        private int CreditCompleted;  


        // constructor use for assign the value. and it's name is as like class name.
       public Student(string name, string id, double cgpa, int CreditCompleted) // local variable = if you declare some variable inside method then those variable are called local viriable.
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.CreditCompleted = CreditCompleted;

        } 
        
        // method/constructor overloading. for different assignable parameter from object.
        public Student(string name, double cgpa )   // local variable = if you declare some variable inside method then those variable are called local viriable.
        {
            this.name = name; // "this" refer member field.
            this.cgpa = cgpa;
 
        }

        // public Student() // default or empty constructor.
        // {

        // }

        public string Name 
        {
            set=>this.name = Name;
            get => name;
        }
        public string Id {get => id;}

        public void SetCgpa(double cg) // so why not make cgpa public as we give a public method to acces cgpa
                                    // reasone is we can add condition on public method who can change value or access it. althow it public.
        {
            if(cg>=0 && cg<=4.0)
            this.cgpa = cg;
            else
            Console.WriteLine("invalid cg");
            return;
        }

        public void showIt() // here we make all field private but still we show all this field info publicly. what's the matter.
                            // the point is if is there any login method, then first we can check login details then show the info. :)
                            // it's like getter and setter. we can put condition on this get and set althow those are public but still every one can't acces this.
                            // making field public means i give permission to all.
                            // making field method public means i give you an option to ask the value. then my wish to give it or not with logic :)

        {
           // Console.WriteLine("hello"+a);
           // Conso.WriteLine("name is : {0} , id is : {1} , cgpa is : {2} nad credit complete is : {3}",name,id,cgpa,CreditCompleted);
        }
    }
}