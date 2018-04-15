using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankAccount.Test
{
    public class AccountShould
    {
        [Fact]
        public void have_zero_balance_first_time()
        {
            decimal expectedBalance = 0m;

            Account account = new Account();

            decimal currentBalance = account.Balance;

            Assert.Equal(expectedBalance, currentBalance);
        }
    }
}
