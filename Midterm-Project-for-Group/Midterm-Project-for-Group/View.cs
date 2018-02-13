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
                double tax = PaymentOptions.CalcTax(subTotal);
                double total = subTotal + tax;


                Console.WriteLine("SubTotal =  " + subTotal);
                Console.WriteLine("Tax =  " + tax);
                Console.WriteLine("Your total is =  " + total);
                string reciptLine = PaymentOptions.Payment_Options(total);
                Console.WriteLine(reciptLine);
                //
                //Recipt is added to the Bin file/debug file//
                //
                Recipt customerRecipt = new Recipt(orderBasket, reciptLine, customerNumber, tax, subTotal);
            }
            orderBasket = new List<MenuItem>();

            customerNumber++;
            Continue(mcMenu, orderBasket, customerNumber);


        }
        public static void Continue(List<MenuItem> mcMenu, List<MenuItem> orderBasket, int customerNumber)
        {
            Console.WriteLine("Would you like to continue?");
            string reply = Console.ReadLine();
            if (reply == "yes" || reply == "y")
            {
                Console.Clear();
                MainMenu(mcMenu, orderBasket, customerNumber);
            }
            else if (reply == "no" || reply == "n")
            {
                Console.WriteLine("GoodBye, Thanks for eating at McDonalds");


            }
            else
            {
                Console.WriteLine("I'm sorry I do not understand");
                Continue(mcMenu, orderBasket, customerNumber);
            }
        }
    }
}
