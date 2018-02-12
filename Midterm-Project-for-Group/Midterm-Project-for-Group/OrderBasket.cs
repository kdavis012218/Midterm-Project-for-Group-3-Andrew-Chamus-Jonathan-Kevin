using System;
using System.Collections.Generic;
namespace Midterm_Project_for_Group
{//Andrew
    class OrderBasket
    {
        public static void ViewList(List<MenuItem> orderBasket)
        {
            foreach (MenuItem item in orderBasket)
            {
                Console.WriteLine(item.menuLine);
            }
        }
        public static void RemoveOrder(List<MenuItem> mcMenu, List<MenuItem> orderBasket)
        {


            {

                Console.WriteLine("Which item would you like to remove?");
                string input = Console.ReadLine();
                bool removeFood = int.TryParse(input, out int f);
                foreach (MenuItem item in orderBasket)
                {
                    if (f == item.menuNumber)
                    {
                        orderBasket.Remove(item);
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
}