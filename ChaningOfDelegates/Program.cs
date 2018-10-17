using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChaningOfDelegates
{
    class Program
    {
        public delegate int MeDelegate();

        public delegate int MeDelegate2();
        static void Main(string[] args)
        {
            MeDelegate del = M1;
            del += M2;
            del += M3;

            MeDelegate2 del2 = M1;
            del2 += M2;
            del2 += M3;

            int val = del();
            Console.WriteLine(val);

            //Incase we need to print return value for each delegate invocation

            foreach (MeDelegate d in del.GetInvocationList())
            {
                Console.WriteLine(d());
            }
        }

        static int M1()
        {
            Console.WriteLine("M1");
            return 1;
        }

        static int M2()
        {
            Console.WriteLine("M2");
            return 2;
        }

        static int M3()
        {
            Console.WriteLine("M3");
            return 3;
        }
    }
}
