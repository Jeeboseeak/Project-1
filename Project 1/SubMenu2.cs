using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class SubMenu2 : Menu
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
                    Console.WriteLine("1.Year 1");
                    Console.WriteLine("2.Year 2");
                    Console.WriteLine("3. Go Back");

                    Console.WriteLine("\nEnter choice: ");
                    choice = int.Parse(Console.ReadLine());
                    base.userInput = choice;
                } while (base.userInput < 1 || base.userInput > 3);



                do
                {
                    switch (base.userInput)
                    {
                        case 1:
                            // Console.Clear();
                            Console.WriteLine("\n---YEAR 1---\n");
                            Console.WriteLine("DGT 1042Y(1) Mathematics for Computing\n" +
                                              "DGT 1032Y(1) Web Design and Development\n - Projects Done: Website\n" +
                                              "DGT 1033Y(1) Business Computing\n" +
                                              "DGT 1038Y(1) Programming and Data Structures\n" +
                                              "DGT 1031Y(1) Database Systems and Administrations\n");


                            break;

                        case 2:
                            // Console.Clear();
                            Console.WriteLine("\n---YEAR 2---\n");
                            Console.WriteLine("DGT 2029Y(3) Multimedia Authoring and Development\n- Projects Done: Photoshop, Sketchup Design, 2D Game Design\n" +
                                              "DGT 2030Y(3) Networking Principles\n- Projects Done: Network Design for a building\n" +
                                              "DGT 2034Y(3) Internet Technologies and Web Services\n Project Done: Website\n" +
                                              "DGT 2035Y(3) Software Modelling and Design\n- Project Done: Pastry Shop GUI\n" +
                                              "DGT 2036Y(3) Principle of Software Development\n");

                            break;
                        case 3:

                            goBack = true;
                            return;
                    }
                } while (goBack);
            }
        }

    }
}