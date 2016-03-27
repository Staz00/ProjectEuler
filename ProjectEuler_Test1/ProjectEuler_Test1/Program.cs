using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_Test1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Controller c = new Controller();

            Console.WriteLine(c.FibonacciWithEven(4000000));
            Console.ReadLine();
        }

        public static void something()
        {

        }
    }
}
