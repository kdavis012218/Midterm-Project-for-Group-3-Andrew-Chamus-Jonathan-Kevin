using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm_Project_for_Group
{//Chamus
    class FoodMenu
    {

        public static List<MenuItem> MakeFoodMenu()
        {
            string path = @"C:\Users\Grand Circus Student\source\repos\Midterm-Project-for-Group-3-Andrew-Chamus-Jonathan-Kevin\McMenu.txt";
            List<MenuItem> mcMenu = new List<MenuItem>();
            StreamReader menu = new StreamReader(path);
            while (true)
            {
                string foodLine = menu.ReadLine();
                bool works = double.TryParse(menu.ReadLine(), out double costLine);

                MenuItem item = new MenuItem(foodLine, costLine);
                mcMenu.Add(item);
                MenuSum(mcMenu);
                if (foodLine == null)
                {
                    break;
                }

            }

            return mcMenu;



        }
        public static void MenuSum(List<MenuItem> foodMenu)
        {
            double summ;
            double cost = 0, sum = 0;
            foreach (var item in foodMenu)
            {
                summ = item.itemCost;
                // cost = double.Parse(summ);
                cost = Convert.ToInt32(summ);
                sum = sum + cost;

            }

        }

        public static void Option1ShowList(List<MenuItem> foodMenu)
        {
            foreach (MenuItem line in foodMenu)
            {
                Console.WriteLine(line.menuLine);
            }

        }
    }

    class MenuItem
    {
        public string itemName;
        public double itemCost;
        public bool category = false;
        public string menuLine;


        public MenuItem(string itemName, double cost)
        {
            this.itemName = itemName;
            this.itemCost = cost;
            this.menuLine = MenuLine(itemName, itemCost);
        }
        public static string MenuLine(string name, double cost)
        {
            string costString = cost.ToString();
            return string.Format("{0,30}{1,20}", name, costString);
        }
    }
}
