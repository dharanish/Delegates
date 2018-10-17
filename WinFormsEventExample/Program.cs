using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button {Text = "BUt"};
            Form vorm = new Form();
            vorm.Controls.Add(button);
            button.Click += (sender, eventArgs) => sender.GetType().Name);
            button.MouseHover += (sender, eventArgs) => button.Top = new Random().Next(10);
            vorm.Show();
            Application.Run();
            IEnumerable<int>
        }
    }
}
