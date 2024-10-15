using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccoutsApp
{
    public class BankAccount(string owner)
    {
        public string Owner { get; set; } = owner;
        public Guid AccountNumber { get; set; } = Guid.NewGuid();
        public decimal Balance { get; protected set; } = 0;

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "AML deposit limit reached";

            Balance += amount;
            return "Deposit completed successfully.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You can not withdraw $" + amount;
            if (amount > Balance)
                return "You don't have enough money";

            Balance -= amount;
            return "Withdraw completed successfully.";
        }
    }
}
