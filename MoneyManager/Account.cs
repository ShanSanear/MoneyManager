using System;

namespace MoneyManager
{
    public class Account
    {
        private int _amountInAccount;
        public Account(int cashInAccount)
        {
            _amountInAccount = cashInAccount;
        }

        public void IncreaseCash(int increaseBy)
        {
            if (increaseBy <= 0)
            {
                throw new InvalidOperationException("Value can only be increased by positive amount");
            }
            _amountInAccount += increaseBy;
        }

        public void DecreaseCash(int decreaseBy)
        {
            if (decreaseBy <= 0)
            {
                throw new InvalidOperationException("Value can only be decreased by positive amount");
            }
            _amountInAccount -= decreaseBy;
        }

        public void SetCash(int valueToSet)
        {
            _amountInAccount = valueToSet;
        }

        public int GetCash()
        {
            return _amountInAccount;
        }
    }
}