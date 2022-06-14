using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace SoftTech_TQ_Training.Multithreding
{
    public class program
    {


        public void Run()
        {
            Thread t = Thread.CurrentThread; // returns the name currently executing thread
            lock (this) // this ref to current thread
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(t.Name);
                    Console.WriteLine(i);
                    Thread.Sleep(2000); // 2sec

                }
            }
            // code goes here.... can run concurrently
        }
    }
    class MultiDemo
    {

        static void Main(string[] args)
        {
            program demo = new program();
            Thread t1 = new Thread(new ThreadStart(demo.Run));
            Thread t2 = new Thread(new ThreadStart(demo.Run));
            Thread t3 = new Thread(new ThreadStart(demo.Run));
            t1.Name = "t1 Thread";
            t2.Name = "t2 Thread";
            t3.Name = "t3 Thread";
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.AboveNormal;
            //t3.Priority = ThreadPriority.Highest;
            t1.Start();
            //  t1.Join(); // block the other thread's execution, t1 will completed its task
            t2.Start();
            t3.Start();
        }


    }
}
    
