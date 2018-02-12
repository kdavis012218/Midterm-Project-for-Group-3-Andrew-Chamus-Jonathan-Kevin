using System;
using System.Collections.Generic;

namespace Midterm_Project_for_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> mcMenu = FoodMenu.MakeFoodMenu();
            List<MenuItem> orderBasket = new List<MenuItem>();
            Console.WriteLine("Welcome to the McDonald's AI Kiosk");
            //MenuItem objects have a double value called itemCost;
            View.MainMenu(mcMenu, orderBasket);

        }
    }
}
