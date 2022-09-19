using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
      class Menu
    {
        public int userInput { get; set; }
        public virtual void menuItems()
        {
            Console.WriteLine("I am Jeeboseea Kritika, a second year student at the University of Mauritius, studying Applied Computing.");
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.Clear();
        }

    }
}