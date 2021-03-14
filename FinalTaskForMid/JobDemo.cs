using JobDemo;
using System;

namespace JobDemo

{
    public class Job
    {
        // instance variable
        private int jobNumber;
        private String jobDescription;
        private String customerName;
        private float estimateHour;
        private float jobPrice = 45.00f;

        // constructor
        public Job(int jobNumber, string customerName, string jobDescription, float estimateHour)
        {

            // set value through instance property.
            JobNumber = jobNumber + this.GetHashCode(); // generate a number for each Job object(this).
            JobDescription = jobDescription;
            CustomerName = customerName;
            EstimateHour = estimateHour;
            JobPrice = estimateHour;
        }

        // set and get property
        public float JobPrice { get => jobPrice; set => jobPrice = value * jobPrice; }
        public int JobNumber { get => jobNumber; set => jobNumber = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public float EstimateHour { get => estimateHour; set => estimateHour = value; }

        // Instance Method
        public override string ToString()
        {
            return "\n\tJob Number : " + jobNumber + "\n" + "\tJob Description : " + jobDescription + "\n" + "\tCustomer Name : " + customerName + "\n" + "\tEstimate Hour : " + estimateHour + "\n" + "\tJob Price : " + jobPrice + "$";
        }

        public override bool Equals(object obj)
        {

            return obj.Equals(JobNumber) ? true : false;
        }
    }



    ///////////////// queation (3a)  ///////////////////
   public class JobDemo1
    {
        public void PrintJobDemo1()
        {
            Job job1 = new Job(0, "Arafat", "Tour guide", 4.5f);
            Job job2 = new Job(1, "Saki", "Project Manager", 8.0f);
            Console.WriteLine(job1.ToString());
            Console.WriteLine("    ---------------------------------------");
            Console.WriteLine(job2.ToString());
            Console.WriteLine("\n\ttwo jobs are equal : " + job1.Equals(job2.JobNumber));
            Console.ReadKey();
        }
    }




    ///////////////// queation (3b)  ///////////////////
    public class JobDemo2
    {
        // show message and take input
        public string TakeInput(Object obj)
        {
            Console.Write(obj);
            return Console.ReadLine();
        }

        // check for jobnumber duplicacy
        static int[] jobNumber = new int[5];
        static int number;
        public int TakeInputJobNumber(Object obj, int jobIndex)
        {
            Console.WriteLine("\n\t**********Job-{0}**********", jobIndex + 1);
            Console.Write(obj);

            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < jobIndex; i++)
            {
                if (jobNumber[i] == number)
                {
                    TakeInputJobNumber("Please enter job Number again : ", jobIndex);
                }

            }

            jobNumber[jobIndex] = number;
            return number;



        }
        public void PrintJobDemo2()
        {

            Job[] job = new Job[5];
            job[0] = new Job(Convert.ToInt32(TakeInputJobNumber("Please enter job Number : ", 0)), TakeInput("Please enter customer Name : "), TakeInput("Please enter job Description : "), float.Parse(TakeInput("Please enter estimateHour : ")));
            job[1] = new Job(Convert.ToInt32(TakeInputJobNumber("Please enter job Number : ", 1)), TakeInput("Please enter customer Name : "), TakeInput("Please enter job Description : "), float.Parse(TakeInput("Please enter estimateHour : ")));
            job[2] = new Job(Convert.ToInt32(TakeInputJobNumber("Please enter job Number : ", 2)), TakeInput("Please enter customer Name : "), TakeInput("Please enter job Description : "), float.Parse(TakeInput("Please enter estimateHour : ")));
            job[3] = new Job(Convert.ToInt32(TakeInputJobNumber("Please enter job Number : ", 3)), TakeInput("Please enter customer Name : "), TakeInput("Please enter job Description : "), float.Parse(TakeInput("Please enter estimateHour : ")));
            job[4] = new Job(Convert.ToInt32(TakeInputJobNumber("Please enter job Number : ", 4)), TakeInput("Please enter customer Name : "), TakeInput("Please enter job Description : "), float.Parse(TakeInput("Please enter estimateHour : ")));

            double price = 0;
            foreach (Job j in job)
            {
                Console.WriteLine(j.ToString());
                price += j.JobPrice;
            }
            Console.WriteLine("\n\n\t**Total of all job price is : {0}$ **", price);
            Console.ReadKey();


        }
    }




    ///////////////// queation (3c)  ///////////////////

    public class RushJob : Job
    {
        public RushJob(int jobNumber, string customerName, string jobDescription, float estimateHour) : base(jobNumber, customerName, jobDescription, estimateHour)
        {

        }
         
        public static int[] sortArray(int[] array)
        {
            Array.Sort<int>(array);
            return array;
        }
            ////// @overWride any method *******************************************
        }

        public class JobDemo3
        {
            public void PrintJobDemo3()
        {
                JobDemo2 jobDemo2 = new JobDemo2();

                RushJob[] rushJobs = new RushJob[5];
                rushJobs[0] = new RushJob(Convert.ToInt32(jobDemo2.TakeInputJobNumber("Please enter job Number : ", 0)), jobDemo2.TakeInput("Please enter customer Name : "), jobDemo2.TakeInput("Please enter job Description : "), float.Parse(jobDemo2.TakeInput("Please enter estimateHour : ")));
                rushJobs[1] = new RushJob(Convert.ToInt32(jobDemo2.TakeInputJobNumber("Please enter job Number : ", 1)), jobDemo2.TakeInput("Please enter customer Name : "), jobDemo2.TakeInput("Please enter job Description : "), float.Parse(jobDemo2.TakeInput("Please enter estimateHour : ")));
                rushJobs[2] = new RushJob(Convert.ToInt32(jobDemo2.TakeInputJobNumber("Please enter job Number : ", 2)), jobDemo2.TakeInput("Please enter customer Name : "), jobDemo2.TakeInput("Please enter job Description : "), float.Parse(jobDemo2.TakeInput("Please enter estimateHour : ")));
                rushJobs[3] = new RushJob(Convert.ToInt32(jobDemo2.TakeInputJobNumber("Please enter job Number : ", 3)), jobDemo2.TakeInput("Please enter customer Name : "), jobDemo2.TakeInput("Please enter job Description : "), float.Parse(jobDemo2.TakeInput("Please enter estimateHour : ")));
                rushJobs[4] = new RushJob(Convert.ToInt32(jobDemo2.TakeInputJobNumber("Please enter job Number : ", 4)), jobDemo2.TakeInput("Please enter customer Name : "), jobDemo2.TakeInput("Please enter job Description : "), float.Parse(jobDemo2.TakeInput("Please enter estimateHour : ")));

                double rushJopPrice = 0;
                int[] sortJobNumber = new int[5];

                for (int i=0; i<rushJobs.Length; i++)
                {
                    sortJobNumber[i] = rushJobs[i].JobNumber; 
                    /*Console.WriteLine(rushJobs[i].ToString()); 
                    rushJopPrice += rushJobs[i].JobPrice;*/
                }

                RushJob.sortArray(sortJobNumber);

            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    if (sortJobNumber[i] == rushJobs[j].JobNumber)
                    {
                        Console.WriteLine(rushJobs[j].ToString());
                    }
                }
            }
 
                Console.WriteLine("\n\n\t**Total of all rush job price is : {0}$ **", rushJopPrice+150);
                Console.ReadKey();
            }
        }

    }

    public class JobDemo4
    {
        public static void Main(string[] args)
        {
        JobDemo1 jobDemo1 = new JobDemo1();
        JobDemo2 jobDemo2 = new JobDemo2();
        JobDemo3 jobDemo3 = new JobDemo3();


        jobDemo1.PrintJobDemo1();
        jobDemo2.PrintJobDemo2();
        jobDemo3.PrintJobDemo3();
         }
}
