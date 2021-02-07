using System;
namespace LabTask
{
    class CarSpeed
    {
        private float acceleration;
        private string engin_number;
        private bool start;
        private float time;

        public CarSpeed(float acceleration = 0, string engin_number = "", bool start = false )
        {
            this.acceleration = acceleration;
            this.engin_number = engin_number;
            this.start = true;
          }
        
        public bool Start { get => start; set => start = value; }

        public void set_acceleration(float acceleration)
        {
            this.acceleration = acceleration;
            Console.WriteLine("Acceleration is : "+acceleration);
        }
        public void set_engin_number(String engin_number)
        {
            this.engin_number = engin_number;
            Console.WriteLine("Engein number of a car set to : "+engin_number);
        } 
        public float get_velocity()
        {
            if (Start)
            {
                Console.WriteLine("Velocity of the car after "+time+"'s is "+ (acceleration*time));
                return acceleration * time;
            }
            else
            {
                Console.WriteLine("start the car first then retrive velocity after acceleration.");
                return 0;
            }
        }

        public void Start_car()
        {
            Start = true;
            Console.WriteLine("\nCar start successfully");
        }
        
        public void Stop_car()
        {
            Start = false;
            Console.WriteLine("Car stop successfully");
        }
        

        static void Main(string[] args)
        {
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("\n\t\tdetails for car " + (i+1));
                Console.WriteLine("\t**********************************");
                CarSpeed carSpeed = new CarSpeed();

                Console.Write("\nEnter the engine number : ");
                carSpeed.set_engin_number(Console.ReadLine());
                
                Console.Write("\nEnter the acceleration : ");
                carSpeed.set_acceleration(float.Parse(Console.ReadLine()));
                
                Console.Write("\nEnter the time : ");
                carSpeed.time=float.Parse((Console.ReadLine()));

                carSpeed.Start_car();
                carSpeed.get_velocity();
                carSpeed.Stop_car();
                Console.WriteLine("\n\n\n");
            }

            Console.ReadKey();

        }
    }
     
}
