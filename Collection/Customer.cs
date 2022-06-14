using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SoftTech_TQ_Training.Collection
{
    class Customer
    {
        public class Cust
        {
            public Cust(int id, string name)
            {
                ID = id;
                Name = name;
            }
            private int m_id;
            public int ID
            {
                get { return m_id; }
                set { m_id = value; }
            }
            private string m_name;
            public string Name
            {
                get { return m_name; }
                set { m_name = value; }
            }

            internal static void Add(int iD, Cust cust1)
            {
                throw new NotImplementedException();
            }
        }
        class Customer1
        {
            static void Main(string[] args)
            {
                List<int> myInts = new List<int>();
                myInts.Add(1);
                myInts.Add(2);
                myInts.Add(3);
                for (int i = 0; i < myInts.Count; i++)
                {
                    Console.WriteLine("MyInts: {0}", myInts[i]);
                }
                Dictionary<int, Cust> customer = new Dictionary<int, Cust>();
                Cust cust1 = new Cust(1, "Cust 1");
                Cust cust2 = new Cust(2, "Cust 2");
                Cust cust3 = new Cust(3, "Cust 3");
                Cust.Add(cust1.ID, cust1);
                Cust.Add(cust2.ID, cust2);
                Cust.Add(cust3.ID, cust3);
                //foreach (KeyValuePair<int, Customer> custKeyVal in customer)
                //{
                //    Console.WriteLine("Customer ID: {0}, Name: {1}", custKeyVal.Key);
                //}
                //Console.ReadKey();
            }
        }
    }
}
