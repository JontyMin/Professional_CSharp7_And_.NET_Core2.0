using System;

namespace BankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IBankAccount venusAccount=new SaverAccount();
            venusAccount.PayIn(200);
            //venusAccount.Withdraw(20);
            Console.WriteLine(venusAccount.ToString());

            ITransferBankAccount jupiterAccount=new CurrentAccount();
            jupiterAccount.PayIn(500);
            jupiterAccount.TransferTo(venusAccount, 100);
            Console.WriteLine(jupiterAccount.ToString());
        }
    }

    public class SaverAccount:IBankAccount
    {
        private decimal _balance;
        public void PayIn(decimal amount) => _balance += amount;
        

        public bool Withdraw(decimal amount)
        {
            if (_balance>amount)
            {
                _balance -= amount;
                return true;
            }

            Console.WriteLine("Withdrawal attempt failed.");
            return false;
        }

        public decimal Balance => _balance;

        public override string ToString() => $"Venus Bank Saver:Balance={_balance,6:C}";
    }

    public class CurrentAccount:ITransferBankAccount
    {
        private decimal _balance;
        public void PayIn(decimal amount)
        {
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance > amount)
            {
                _balance -= amount;
                return true;
            }

            Console.WriteLine("Withdrawal attempt failed.");
            return false;
        }


        public decimal Balance => _balance;
        public bool TransferTo(IBankAccount destination, decimal amount)
        {
            bool result = Withdraw(amount);
            if (result)
            {
                destination.PayIn(amount);
            }

            return result;
        }

        public override string ToString() => $"Venus Bank Saver:Balance={_balance,6:C}";

    }

    /// <summary>
    /// 接口名称通常以字母I开头
    /// </summary>
    public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }

    public interface ITransferBankAccount : IBankAccount
    {
        bool TransferTo(IBankAccount destination, decimal amount);
    }
}
