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
        public static void RemoveOrder(List<MenuItem> mcMenu, List<MenuItem> orderBasket, int customerNumber)
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
                    View.MainMenu(mcMenu, orderBasket, customerNumber);
                }
            }
        }
        public static void AddOrder(List<MenuItem> mcMenu, List<MenuItem> orderBasket)
        {
            string order;
            string quantity;
            FoodMenu.Option1ShowList(mcMenu);
            Console.WriteLine("Which item number would you like to add?");
            order = Console.ReadLine();
            Console.WriteLine("How many Would you like?");
            quantity = Console.ReadLine();
            if (int.TryParse(order, out int x) && int.TryParse(quantity, out int y))
            {
                x = x - 1;
                for (int i = 0; i < y; i++)
                {
                    orderBasket.Add(mcMenu[x]);
                }
            }
            Console.WriteLine();
            foreach (MenuItem line in orderBasket)
            {
                Console.WriteLine(line.menuLine);
            }

        }


    }
}