namespace _8th_class_11
{
    class Employee
    {
        string name;
        double salary;
        string depeartment;

        public Employee()
        {
            
        } 
        public Employee(string name)
        {
            this.name = name;
        }
         public Employee(string name, string depeartment, double salary)
        {
            this.name = name;
            this.depeartment = depeartment; 
            this.salary = salary;
        }

    }    
}