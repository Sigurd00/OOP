namespace Banking
{
    public class BankAccount
    {
        private double Balance;
        private int BorrowingRate;
        private int SavingsRate;

        public BankAccount(double balance, int borrowingRate, int savingsRate)
        {
            if (balance >- 100000 && balance <= 250000)
            {
                Balance = balance;
            } else
            {
                throw new ArgumentException("Balance is not positive");
            }
            if(borrowingRate >= 6 && borrowingRate <= 10)
            {
                BorrowingRate = borrowingRate;

            } else
            {
                throw new ArgumentException("Borrowing rate is either too high or too low");
            }
            if (savingsRate >= 0 && savingsRate <= 2)
            {
                SavingsRate = savingsRate;

            } else
            {
                throw new ArgumentException("Savings rate is either too low or above borrowing rate");
            }
        }

        public double AccountBalance()
        {
            return Balance;
        }

        public void Deposit(int money)
        {
            if (money > 0)
            {
                Balance += money;
            }
        }
        public void Withdraw(int money)
        {
            if(money > 0)
            {
                Balance -= money;
            } 
        }
        public void Interests()
        {
            if (Balance > 0)
            {
                Balance *= (1.0 + SavingsRate / 100);
            }
            else
            {
                Balance *= (1.0 - BorrowingRate / 100);
            }
        }
    }
}