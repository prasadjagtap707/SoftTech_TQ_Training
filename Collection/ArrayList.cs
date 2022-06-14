using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTech_TQ_Training.Collection
{
    class ArrayList12
    {
        static void Main(string[] args)
        {
            ArrayList EmpList = new ArrayList();
            EmpList.Add("Sandeep");
            EmpList.Add(25);
            foreach (var item in EmpList)
            {
                string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(arrayItem);
            }
            Console.Read();
        }
       
     

    }
}
