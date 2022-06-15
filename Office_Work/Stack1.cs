using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SoftTech_TQ_Training.Office_Work
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push(10);
            s.Push(12);
            s.Push(13);
            s.Push(15);
            Console.WriteLine("Current stack: ");
            foreach (int i in s)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
