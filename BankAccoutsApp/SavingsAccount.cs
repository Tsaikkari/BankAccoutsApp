using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccoutsApp
{
    public class SavingsAccount(string owner, decimal interestRate) : BankAccount(owner + " (" + interestRate + "%)")
    {
        public decimal InterestRate { get; private set; } = interestRate;

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "AML deposit limit reached";

            this.Balance += (InterestRate * amount / 100) + amount;
            return "Deposit completed successfully.";
        }
    }
}
