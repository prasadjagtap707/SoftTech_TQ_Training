using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTech_TQ_Training.Office_Work
{
    class Excep_Handling
    {
        static void Main(string[] args)
        {
            int a = 4, b = 2, c;
            try
            {
                c = a / b;
                Console.WriteLine($"Division is {c}");

            }
            // Exception it is base class for all excetions, can handle all type of exceptions in the program
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            try
            {
                Console.WriteLine(a);
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }
        }


    }
}

