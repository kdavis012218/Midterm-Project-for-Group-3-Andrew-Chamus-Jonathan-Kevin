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
                string costLine = menu.ReadLine();
                MenuItem item = new MenuItem(foodLine, costLine);
                mcMenu.Add(item);
                if (foodLine == null)
                {
                    break;
                }

            }

            return mcMenu;



        }
        public static void Option1ShowList(List<MenuItem> foodMenu)
        {
            foreach (MenuItem line in foodMenu)
            {
                System.Console.WriteLine(line.menuLine);
            }
        }
    }

    class MenuItem
    {
        public string itemName;
        public double itemCost;
        public bool itemMealDeal = false;
        public string menuLine;


        public MenuItem(string itemName, string cost)
        {
            this.itemName = itemName;
            this.itemCost = double.Parse(cost);
            this.menuLine = MenuLine(itemName, itemCost);
        }
        public static string MenuLine(string name, double cost)
        {
            string costString = cost.ToString();
            return string.Format("{0,20}{1,4}", name, costString);
        }
    }
}
