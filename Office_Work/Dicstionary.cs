using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTech_TQ_Training.Office_Work
{
    class Dicstionary
    {

        static void Main(string[] args)
        {

            // Dictionary - generic collection object to store data in the form of 
            //key- value pair
            // Dictionary class is using to the key and value pair 

            Console.WriteLine("+++++++");
            Dictionary<int, string> dic = new Dictionary<int, string>();


            dic.Add(123, "Welcome");
            dic.Add(124, "to");
            dic.Add(125, "C# ");

            foreach (KeyValuePair<int, string> ele1 in dic)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();


            Console.WriteLine("+++++++");

            Dictionary<string, string> dic1 =
                    new Dictionary<string, string>(){
                                  {"a.1", "Dog"},
                                  {"a.2", "Cat"},
                                {"a.3", "Pig"} };

            foreach (KeyValuePair<string, string> ele2 in dic1)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }

            Console.ReadLine();
        }
    }
}
