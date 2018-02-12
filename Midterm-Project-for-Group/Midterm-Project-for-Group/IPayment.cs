using System;

namespace Midterm_Project_for_Group
{//Kevin
    interface IPayment
    {
        bool Approval();
        double CalcAmount();
    }
    class CashPayment : IPayment
    {
        double amount;

        public bool Approval()
        {
            throw new System.NotImplementedException();
        }

        public double CalcAmount()
        {
            Console.WriteLine("How much would you like to pay?");
            bool maybePay = double.TryParse(Console.ReadLine(), out double paying);
            return paying;
        }
    }
    class CardPayment : IPayment
    {
        double amount;

        public bool Approval()
        {
            throw new System.NotImplementedException();
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
        double amount;

        public bool Approval()
        {
            throw new System.NotImplementedException();
        }

        public double CalcAmount()
        {
            Console.WriteLine("How much would you like to pay?");
            bool maybePay = double.TryParse(Console.ReadLine(), out double paying);
            return paying;
        }
    }
}
