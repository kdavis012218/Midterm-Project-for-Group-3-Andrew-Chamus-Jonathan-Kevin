using System;
using System.Collections.Generic;
namespace Midterm_Project_for_Group
{
    class View
    {
        public static void MainMenu(List<MenuItem> mcMenu, List<MenuItem> orderBasket, int customerNumber)
        {
            Console.WriteLine("Here are your  Options");
            Console.WriteLine("1. View Menu");
            Console.WriteLine("2. Add menu item to your order");
            Console.WriteLine("3. Remove menu item from your order");
            Console.WriteLine("4. Checkout");
            bool userChoice = int.TryParse(Console.ReadLine(), out int userC);
            if (userChoice == false || userC < 1 || userC > 4)
            {
                Console.WriteLine("That is not a valid Menu option");
                MainMenu(mcMenu, orderBasket, customerNumber);
            }
            else if (userC == 1)
            {
                FoodMenu.Option1ShowList(mcMenu);
                MainMenu(mcMenu, orderBasket, customerNumber);
            }
            else if (userC == 2)
            {
                OrderBasket.AddOrder(mcMenu, orderBasket);
                MainMenu(mcMenu, orderBasket, customerNumber);
            }

            else if (userC == 3)
            {
                OrderBasket.ViewList(orderBasket);
                OrderBasket.RemoveOrder(mcMenu, orderBasket, customerNumber);
                OrderBasket.ViewList(orderBasket);
                MainMenu(mcMenu, orderBasket, customerNumber);
            }
            else
            {
                double subTotal = PaymentOptions.CalcSubTotal(orderBasket);
                Console.WriteLine("SubTotal =  " + subTotal);
                double tax = PaymentOptions.CalcTax(subTotal);
                Console.WriteLine("Tax =  " + tax);
                double total = subTotal + tax;
                Console.WriteLine("Your total is =  " + total);
                string reciptLine = PaymentOptions.Payment_Options(total);
                Console.WriteLine(reciptLine);
                //
                //Recipt is added to the Bin file/debug file//
                //
                Recipt customerRecipt = new Recipt(orderBasket, reciptLine, customerNumber);
            }
            orderBasket = new List<MenuItem>();
            Continue(mcMenu, orderBasket, customerNumber);


        }
        public static void Continue(List<MenuItem> mcMenu, List<MenuItem> orderBasket, int customerNumber)
        {
            Console.WriteLine("Would you like to continue?");
            if (Console.ReadLine() == "yes")
            {
                MainMenu(mcMenu, orderBasket, customerNumber);
            }
            else if (Console.ReadLine() == "no")
            {
                Console.WriteLine("GoodBye, Thanks for eating at McDonalds");
                return;

            }
            else
            {
                Console.WriteLine("I'm sorry I do not understand");
                Continue(mcMenu, orderBasket, customerNumber);
            }
        }
    }
}
