using System;
using System.Collections.Generic;
namespace Midterm_Project_for_Group
{//Andrew
    class OrderBasket
    {
        public static List<MenuItem> RemoveOrder(List<MenuItem> mcMenu)
        {
            bool run = true;
            while (run == true)
            {
                int x = 0;
                foreach (MenuItem item in mcMenu)
                {
                    Console.WriteLine(x + "  " + item);
                    x++;
                }
                Console.WriteLine("Which item would you like to remove?");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int f) && f <= mcMenu.Count)
                {
                    mcMenu.RemoveAt(f);
                    run = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            return mcMenu;
        }
    }
}