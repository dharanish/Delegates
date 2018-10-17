using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOrRemoveEventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow c = new   Cow();
            c.Mooing += () => Console.WriteLine("Hello");
            c.WakeUpCow();
        }
    }

    public class Cow
    {
        private Action mooing;
        public event Action Mooing
        {
            add
            {
                mooing += value;
                Console.WriteLine("Adding");
            }
            remove
            {
                mooing -= value;
                Console.WriteLine("Removing");
            }
        }

        public void WakeUpCow()
        {
            mooing();
        }
    }
}
