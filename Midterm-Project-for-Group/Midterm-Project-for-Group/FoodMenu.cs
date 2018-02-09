using System.Collections.Generic;
namespace Midterm_Project_for_Group
{//chamus
    class FoodMenu
    {
        //Static Method to create our list of menuItems;
        public static List<MenuItem> MakeFoodMenu()
        {
            List<MenuItem> mcMenu = new List<MenuItem>();

            return mcMenu;



        }
    }

    class MenuItem
    {
        public string itemName;
        public double itemCost;
        public bool itemMealDeal = false;


        public MenuItem()
        {

        }
    }
}
