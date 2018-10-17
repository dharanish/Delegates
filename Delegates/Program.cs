using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            MyDelegate del = Foo;
            del();
            Console.WriteLine(del.Method);
            Console.WriteLine(del.Target);

            Program p = new Program();
            del = p.InstanceMethod;
            del();
            Console.WriteLine(del.Method);
            Console.WriteLine(del.Target);
        }

        static void Foo()
        {
            Console.WriteLine("Foo");
        }

        void InstanceMethod()
        {
            Console.WriteLine("InstanceMethod");
        }
    }
}
