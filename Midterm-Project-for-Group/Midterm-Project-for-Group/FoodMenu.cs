
using System;
using System.Collections.Generic;
using System.IO;
namespace Midterm_Project_for_Group
{//Chamus
    class FoodMenu
    {
        public static List<MenuItem> MakeFoodMenu()
        {
            //This is for making our Original Menu, where our customer/console user will choose from;
            int x = 0; // This will be added to the MenuItem as it is added to the mcMenu
            string path = @"C:\Users\Grand Circus Student\source\repos\Midterm-Project-for-Group-3-Andrew-Chamus-Jonathan-Kevin\McMenu.txt";
            List<MenuItem> mcMenu = new List<MenuItem>();
            StreamReader menu = new StreamReader(path);
            while (true)
            {
                string foodLine = menu.ReadLine();
                string catagoryLine = menu.ReadLine();
                string descriptionLine = menu.ReadLine();
                bool works = double.TryParse(menu.ReadLine(), out double costLine);
                x++;
                MenuItem item = new MenuItem(foodLine, catagoryLine, descriptionLine, costLine, x);
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
            //This Method is called when the ConsoleUser chooses option 1 from the MainMenu
            Console.Clear();
            foreach (MenuItem line in foodMenu)
            {
                Console.WriteLine(line.menuLine);
            }
        }
    }
    class MenuItem
    {
        //Instance Variables
        public string itemName;
        public string catagory;
        public string description;
        public double itemCost;
        public string menuLine;

        public MenuItem(string itemName, string catagory, string description, double cost, int x)
        {
            //This is our MenuItem Constructor
            this.itemName = itemName;
            this.catagory = catagory;
            this.description = description;
            this.itemCost = cost;
            this.menuLine = MenuLine(itemName, itemCost, description);
        }
        public static string MenuLine(string name, double cost, string description)
        {
            //This method will constuct the menuLine. This is used only for presenting all of the MenuItem objects' instance variables at once.
            string costString = cost.ToString();
            return string.Format("{0,1}{1,30}\n{2,20}\n" + "\n", name, costString, description);
        }
    }
}

