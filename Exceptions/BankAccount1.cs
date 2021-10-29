public class BankAccount
{
    public int Balance
    {
        get
        {
            return Balance;
        }
        set
        {
            if (value >= 0)
            {
                Balance = value;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }
    }

    public BankAccount(int balance)
    {
        if (balance >= 0)
        {
            Balance = balance;
        }
        else
        {
            throw new InsufficientFundsException();
        }
    }

    public void Deposit(int value)
    {
        Balance += value;
    }
    public void Withdraw(int value)
    {
        if (Balance - value < 0)
        {
            throw new InsufficientFundsException();
        }
        Balance -= value;
    }
}
