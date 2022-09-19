using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Menu menu = new Menu();
            menu.menuItems();

            int choice;
            MainMenu menu1 = new MainMenu();
            menu1.menuItems();
            choice = int.Parse(Console.ReadLine());
            
           menu.userInput = choice;
            
           
        }
    }
}
