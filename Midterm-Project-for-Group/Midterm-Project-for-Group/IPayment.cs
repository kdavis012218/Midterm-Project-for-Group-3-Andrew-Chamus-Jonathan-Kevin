using System;
using System.Collections.Generic;

namespace Midterm_Project_for_Group
{//Kevin
    interface IPayment
    {
        bool Approval(double pay, double subTotal);
        double CalcAmount();
    }
    class CashPayment
    {
        public static bool Approval(double cash, double total)
        {
            bool approved = false;
            if (cash >= total)
            {
                approved = true;
            }
            else
            {
                Console.WriteLine("That is not enough");
                CalcAmount();
            }
            return approved;
        }

        public static double CalcAmount()
        {
            Console.WriteLine("How much would you like to pay?");
            if (double.TryParse(Console.ReadLine(), out double paying))
            {
                return paying;
            }
            CalcAmount();
            return paying;
        }

        public static double Change(double cash, double totalBill)
        {
            double change = totalBill - cash;
            Console.WriteLine("Here is your change: " + change);
            return change;
        }

    }


    class PaymentOptions
    {

        public static string Payment_Options(double total)
        {
            string reciptLine = "";
            Console.WriteLine(" What is your payment method");
            Console.WriteLine("Cash, Check, or Credit?");
            string paymentmethod = Console.ReadLine().ToLower();

            if (paymentmethod == "cash")
            {
                double pay = CashPayment.CalcAmount();
                Console.WriteLine("Amount tendered " + pay);
                CashPayment.Approval(pay, total);
                CashPayment.Change(pay, total);
                reciptLine = ("Cash Payment of " + pay + " out of " + total);
                return reciptLine;
            }

            else if (paymentmethod == "check")
            {
                System.Console.Write("Please enter Check number");
                string checknumber = Console.ReadLine();
                Console.WriteLine("Check number verified");
                Console.WriteLine("Transaction approved");
                reciptLine = ("Check Payment of " + total + " out of " + total);
                return reciptLine;
            }

            else if (paymentmethod == "credit_card" || paymentmethod == "credit" || paymentmethod == "card")
            {
                Console.Write("Please enter Card number");
                string credit_card = Console.ReadLine();
                Console.WriteLine("Card number verified");

                Console.WriteLine("Please enter expiration date");
                string expiration_date = Console.ReadLine();

                Console.WriteLine("Please enter security code");
                string csecurity_code = Console.ReadLine();
                Console.WriteLine("Transaction approved");

                reciptLine = ("Card ********" + credit_card.Substring(0, 4) + " paid " + total + " of " + total);
                return reciptLine;


            }
            else
            {
                Payment_Options(total);
                return reciptLine;
            }

        }


        public static double CalcSubTotal(List<MenuItem> orderBasket)
        {
            double subTotal = 0;
            foreach (MenuItem item in orderBasket)
            {
                subTotal += item.itemCost;
            }
            return subTotal;
        }
        public static double CalcTax(double subTotal)
        {
            double tax = 0.06;
            double sTax = tax * subTotal;
            sTax = Math.Round(sTax, 2);
            return sTax;
        }
    }
}

