using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class MainMenu : Menu
    {
       
        public override void menuItems()
        {
            int choice;
            while (true)
            {
                do
                {

                    Console.WriteLine("---Main Menu---");
                    Console.WriteLine("1.Experience/Job History");
                    Console.WriteLine("2. Education/Training");
                    Console.WriteLine("3.Skills");
                    Console.WriteLine("4.Technological Skills");
                    Console.WriteLine("5.Contact Details");

                    Console.WriteLine("\nEnter choice: ");
                    choice = int.Parse(Console.ReadLine());
                    base.userInput = choice;

                } while (choice < 0 || base.userInput > 5);

                Console.Clear();
                // bool isSub = false;
                switch (base.userInput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ceridian (2022)\n");


                        SubMenu1 submenu = new SubMenu1();
                        submenu.menuItems();

                        /*Console.WriteLine("\nEnter choice: ");
                        submenu.choice = Convert.ToInt32(Console.ReadLine());
                        */
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("University of Mauritius (2020 - 2023)\n");

                        SubMenu2 submenu2 = new SubMenu2();
                        submenu2.menuItems();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Skills:\n -Team player\n -Quick Learner\n -Agility and Adaptability\n");
                        menuItems();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Technological Skills:\n -Web Development\n -Programming Languages: Java, Javascript, etc...\n");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Contact Details:\n -Email: k.jeeboseea@xyz.com\n" +
                            " -Mobile Number: 53527820\n");
                        break;
                }

            }
        }

    }
}
