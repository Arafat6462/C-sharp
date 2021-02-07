using System;
 
namespace firstExample_Lab
{
    class Carspeed
    {
        private float acceleration;
        private string engin_number;
        private bool start;
        private float time;
        static void Main(string[] args)
        {
            start_car();


         }

        Carspeed(float acceleration = 0, string engin_number = "", bool start = false)
        {

        }

        public static void start_car()
        {
            start = true;
            Console.WriteLine("hekahj");
        }
    }
}
