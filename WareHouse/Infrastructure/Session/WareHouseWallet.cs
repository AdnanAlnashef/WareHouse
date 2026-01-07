using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Exceptions;
using WareHouse.Infrastructure.Storage;

namespace WareHouse.Infrastructure.Session
{
    public static class WareHouseWallet
    {
        public static decimal Balance { get; private set; }

        public static void Load()
        {
            Balance = WalletStorage.Load().Balance;
        }

        public static void Add(decimal amount)
        {
            if (amount <= 0)
                throw new NegativeAmmountException();
            Balance += amount;
            WalletStorage.Save(Balance);
        }

        public static bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
                return false;
            Balance -= amount;
            WalletStorage.Save(Balance);
            return true;
        }

        public static void Reset()
        {
            Balance = 0;
        }
    }
}
