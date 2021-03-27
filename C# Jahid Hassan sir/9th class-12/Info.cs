using System;
namespace _9th_class_12
{
    class Info
    {
        string name;
        string id;
        double salary;

        public Info(string name, string id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public Info(){}

         public string Name
         {
             set
             {
                 if(string.IsNullOrEmpty(value))
                 {
                     Console.WriteLine("invalid name");
                     return;
                 }
                 name = value;

         }   }
         public double Salary{set=>salary=value; get=>salary;}

         public void show()
         {
             Console.WriteLine("name is : {0} \nid is : {1} \nsalary is : {2}",name,id,salary);
         }

         public void bonus()
         {
             Console.WriteLine("bonus is : "+(salary<50000? salary*.1:salary*1.5)+" tk");
         }
        
    }
    
}