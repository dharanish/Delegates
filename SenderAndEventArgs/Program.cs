using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SenderAndEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow c1 = new Cow {Name = "Cow1"};
            c1.Mooing += OnMooing;
            c1.WakeUpCow();
            Cow c2 = new Cow {Name = "Cow2"};
            c2.Mooing += OnMooing;
            c2.WakeUpCow();
        }

        private static void OnMooing(object sender, EventArgs e)
        {
            var cow = sender as Cow;
            Console.WriteLine(cow.Name);
        }

        public class Cow
        {
            public string Name { get; set; }
            public event EventHandler Mooing;

            public void WakeUpCow()
            {
                Mooing?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
