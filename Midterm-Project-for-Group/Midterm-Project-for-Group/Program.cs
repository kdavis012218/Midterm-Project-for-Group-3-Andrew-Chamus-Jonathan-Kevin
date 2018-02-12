using System;
using System.Collections.Generic;

namespace Midterm_Project_for_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerNumber = 0;
            List<MenuItem> mcMenu = FoodMenu.MakeFoodMenu();
            List<MenuItem> orderBasket = new List<MenuItem>();
            Console.WriteLine("Welcome to the McDonald's AI Kiosk");
            View.MainMenu(mcMenu, orderBasket, customerNumber);

        }
    }
}
