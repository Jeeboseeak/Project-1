using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class SubMenu1 : Menu
    {
        public override void menuItems()
        {
            int choice;
            bool goBack = false;
            while (goBack != true)
            {
                do
                {
                    Console.WriteLine("---SubMenu---");
                    Console.WriteLine("1.Overview of job description");
                    Console.WriteLine("2. Go Back");

                    Console.WriteLine("\nEnter choice: ");
                    choice = int.Parse(Console.ReadLine());
                    base.userInput = choice;
                } while (base.userInput < 1
                || base.userInput > 2);



                do
                {
                    switch (base.userInput)
                    {
                        case 1:
                            // Console.Clear();
                            Console.WriteLine("\nInternship at Ceridian Mauritius, where currently undergoing a JEDI Programme.\n");

                            break;
                        case 2:

                            goBack = true;
                            return;
                    }
                } while (goBack);
            }
        }
    }
}