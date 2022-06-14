using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTech_TQ_Training.Collection
{
    class Dictio
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>();
            countries.Add(91, "India");
            countries.Add(1, "USA");

            foreach (var item in countries)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
