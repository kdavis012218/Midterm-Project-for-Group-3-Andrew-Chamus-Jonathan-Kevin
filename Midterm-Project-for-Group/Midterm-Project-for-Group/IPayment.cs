using System;

namespace Midterm_Project_for_Group
{//Kevin
    interface IPayment
    {
        bool Approval(double pay, double subTotal);
        double CalcAmount();
    }
    class CashPayment : IPayment
    {
        public bool Approval(double cash, double subTotal)
        {
            bool approved = false;
            if (cash >= subTotal)
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

        public double CalcAmount()
        {
            Console.WriteLine("How much would you like to pay?");
            bool maybePay = double.TryParse(Console.ReadLine(), out double paying);
            return paying;
        }

        public double Change(double cash, double totalBill)
        {
            double change = totalBill - cash;
            return change;
        }

    }
    class CardPayment : IPayment
    {
        double amount;

        public bool Approval(double pay, double subTotal)
        {

            bool approved = false;
            if (pay >= subTotal)
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

        public double CalcAmount()
        {
            Console.WriteLine("How much would you like to pay?");
            bool maybePay = double.TryParse(Console.ReadLine(), out double paying);
            return paying;
        }
    }
    class CheckPayment : IPayment
    {
        int checkNumber;

        public bool Approval(double pay, double subTotal)
        {
            bool approved = false;
            if (pay >= subTotal)
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

        public double CalcAmount()
        {
            Console.WriteLine("How much would you like to pay?");
            bool maybePay = double.TryParse(Console.ReadLine(), out double paying);
            return paying;
        }
    }
}
