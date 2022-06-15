using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SoftTech_TQ_Training.Office_Work
{
    class Arraylist_NG
    {

        static void Main(string[] args)
        {
            //ArryList Add the value in non Generic type Collecton

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(11);
            list.Insert(1, 55);
            list.IndexOf(2);

            //arraylist capcity 
            Console.WriteLine("ArrayList Capcity " + list.Capacity);

            //Arraylist Count 
            Console.WriteLine("Count  " + list.Count);

            //search record  in arraylist 
            Console.WriteLine("Search the record in ArrayList : " + list.Contains(10));


            //  content arrylist 
            Console.Write("Content: ");
            foreach (object i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n  Fixed size  " + list.IsFixedSize);

            //READ THE DATA OF LIST 

            // Console.WriteLine("ReadOnly "+list.IsReadOnly);




            // sortd arraylist
            //Console.Write("Sorted Content: ");

            // arrive the exception because the non generic arrylist are contain,
            // the some string and int so that exception are arrrive s
            try
            {
                list.Sort();
                foreach (int i in list)
                {
                    Console.Write(i + " ");

                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            //******Stack************** 

            Stack s = new Stack();

            //push the data in stack 
            s.Push(10);
            s.Push(12);
            s.Push(13);
            s.Push(145);
            Console.WriteLine("Current stack: ");
            foreach (int i in s)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine("Removing values ");

            // pop the data in stack
            s.Pop();
            //  s.Pop();
            // s.Pop();

            Console.WriteLine("Current stack: ");
            foreach (int s1 in s)
            {
                Console.Write(s1 + " ");
            }

            // Queue

            Queue q = new Queue();

            //Add the queue elements 
            Console.WriteLine("\n Enqueue operation ");
            q.Enqueue("Prasd");
            q.Enqueue("Abhi");
            q.Enqueue("Swapnil");
            q.Enqueue("Kiran");

            foreach (string qu in q)
            {
                Console.Write(qu + " ");
            }

            //Remove the queue element 
            Console.WriteLine("\n  ---Dequeue operation  ---");
            q.Dequeue();

            foreach (string qu1 in q)
            {
                Console.Write(qu1 + " ");
            }


            Console.ReadLine();

        }
    }
}
}
