using System;

namespace test
{
    class Carspeed
    {

        private float acceleration;
        private string engin_number;
        private bool start;
        private float time;

        static void Main(string[] args)
        {

            Console.WriteLine("hella");
 
            Carspeed carspeed = new Carspeed();
             Console.WriteLine("Details for the car 1");
             Console.Write("Enter the engin number : " );
             carspeed.engin_number =  Console.ReadLine;


             Console.Write("Enter the acceleration : " );
             carspeed.acceleration = float.Parse(Console.ReadLine);

             Console.Write("Enter the time : " );
             carspeed.time = float.Parse(Console.ReadLine);

             Console.WriteLine("engin number of a car set to "+carspeed.engin_number);
             Console.WriteLine("car acceleration is "+carspeed.acceleration);
             Console.WriteLine("car started succesfully "+carspeed.start_car);
             Console.WriteLine("velocity of the car after"+carspeed.time+" is "+ carspeed.get_velocity(carspeed.time,carspeed.acceleration));
             Console.WriteLine("car stop succesfully "+carspeed.stop_car);

             


            for(int i=2; i<4; i++){

            Carspeed carspeed = new Carspeed();
             Console.WriteLine("Details for the car " +i);
             Console.Write("Enter the engin number : " );
             carspeed.engin_number =  Console.ReadLine;


             Console.Write("Enter the acceleration : " );
             carspeed.acceleration = float.Parse(Console.ReadLine);

             Console.Write("Enter the time : " );
             carspeed.time = float.Parse(Console.ReadLine);

             Console.WriteLine("engin number of a car set to "+carspeed.engin_number);
             Console.WriteLine("car acceleration is "+carspeed.acceleration);
             Console.WriteLine("car started succesfully "+carspeed.start_car);
             Console.WriteLine("velocity of the car after"+carspeed.time+" is "+ carspeed.get_velocity(carspeed.time,carspeed.acceleration));
             Console.WriteLine("car stop succesfully "+carspeed.stop_car);

             

            }

            
        }

         public void Carspeed(float acceleration =0, string  engin_number= "" , bool start= false){

            

         }

         public static void start_car( ){
              Carspeed.start = true;
 

         }
         
          public static void stop_car(){
             Carspeed.start = false;


         } 
         
          public static void set_acceleration( float acceleration){
              this.acceleration = acceleration;

         }  
         
         public static void set_engin_number(string engin_number){
             This.engin_number = engin_number;

         }

         public static float get_velocity(float time ,float acceleration){
             return time * acceleration;
         }


    }
    }
}
