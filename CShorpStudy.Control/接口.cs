using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CShorpStudy.Control
{
    public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance
        {
            get;
        }
    }

    public class SaverAccount : IBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawa1 attempt failed");
            return false;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
    }

    class 接口
    {
    }
}
