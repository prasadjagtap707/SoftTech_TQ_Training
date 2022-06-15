using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTech_TQ_Training.Delegate_Event
{
    public delegate void MyDelegate();
    public class Calculate
    {
        public event MyDelegate add;
        public event MyDelegate sub;

        public void Accept(int n)
        {
            if (n == 1)
            {
                add();
            }
            else if (n == 2)
            {
                sub();
            }
        }
    }
        class Dele_Event
        {
            static void Addition()
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"addition is :{a + b}");
            }
            static void Substract()
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"sub is :{a - b}");
            }

            static void Main(string[] args)
            {
                Calculate c1 = new Calculate();
                c1.add += new MyDelegate(Addition);
                c1.sub += new MyDelegate(Substract);

                c1.Accept(2);

            }

        }
    
}
