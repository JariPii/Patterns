    internal class BankAccount
    {
    private decimal balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Deposit must be positive");
        }

        this.balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void WithDraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be positive");
        }

        if(amount > balance)
        {
            throw new IndexOutOfRangeException("Insufficient funds");
        }

        this.balance -= amount;
    }

    }

