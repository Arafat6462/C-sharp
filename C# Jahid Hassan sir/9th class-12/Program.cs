using System;

namespace _9th_class_12
{
    class Program
    {
        static void Main(string[] args)
        {
             Student student = new Student("arafat","rer",3.3,1012);
             Console.WriteLine(student.GetId());
             student.SetId("arfaT");
             Console.WriteLine(student.GetId());

            // calling will automatially heppen. when set call and when get call.
             Console.WriteLine(student.Name);
             student.Name = "ar";
             Console.WriteLine(student.Name);

             Info info = new Info( );
             info.show();
             info.Salary=50000;
             info.bonus();

         }
    }

    
}
