using System;

namespace _8th_class_11
{
    class Program
    {
        static void Main(string[] args)
        {
           // int a;  // pre-define data type. size and all thing are fixed already.

            Student student = new Student("Arafat","18-37576-1", 3.2, 104); // student is a virable of data type Student. that store Student(data type) information is called object.
                                                                            // default constructor will automatically call if no constructor is created.
                                                                            // any constructor create in class then default constructor will not created.

            Employee employee = new Employee();   
            Console.WriteLine(student.Name); 
            student.Name = "NIpu";
            Console.WriteLine(student.Name);
           // student.showIt("arafat");    
         }
    }
}
