using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SoftTech_TQ_Training.Multithreding
{
    class Program
    {
        public static void Main()
        {
            Thread Object1 = new Thread(Example1); //Creating the Thread    
            Thread Object2 = new Thread(Example2);
            Object1.Start(); //Starting the Thread    
            Object2.Start();
            Object1.Join();
        }
        static void Example1()
        {
            Console.WriteLine("Thread1 Started");
            //lock (this)
          //  {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Thread1 Executing");
                    Thread.Sleep(3000);
                }
           // }
        }
        static void Example2()
        {
            Console.WriteLine("Thread 2 Started");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread 2 Executing");
                Thread.Sleep(3000);
            }
        }
    }
}
