using System;
using System.Collections.Generic;
namespace Midterm_Project_for_Group
{//Andrew
    class OrderBasket
    {
        public static void ViewList(List<MenuItem> orderBasket)
        {
            Console.WriteLine("");
            Console.WriteLine("Your Order: ");
            int x = 1;
            double sub = 0;
            foreach (MenuItem item in orderBasket)
            {
                sub += item.itemCost;
                Console.WriteLine(x + " " + item.menuLine);
                x++;
            }
            Console.WriteLine();
            Console.WriteLine("Your SubTotal is : " + sub);
        }
        public static void RemoveOrder(List<MenuItem> mcMenu, List<MenuItem> orderBasket)
        {
            {
                Console.WriteLine("Which item would you like to remove?");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int f))
                {
                    orderBasket.RemoveAt(f - 1);
                }
                else
                {
                    Console.WriteLine("This is not a valid input");
                    View.MainMenu(mcMenu, orderBasket);
                }
            }
        }
    }
}