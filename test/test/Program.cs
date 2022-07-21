using System;

namespace EncapsulationDemo
{
    public class Bank
    {
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                // validate the value
                if (value < 0)
                {
                    Console.WriteLine("value cannot be negative");
                }
                else
                {
                    balance = value;
                }
            }
        }
    }
    class BankUser
    {
        public static void Main()
        {
            Bank SBI = new Bank();
            SBI.Balance = 100;
            Console.WriteLine(SBI.Balance);
            SBI.Balance = -50;
            Console.WriteLine(SBI.Balance);
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}