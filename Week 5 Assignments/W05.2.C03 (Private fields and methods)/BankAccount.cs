class BankAccount
{
    private double _balance;

    public BankAccount(double b)
    {
        _balance = b;
    }

    public double ReadBalance() => _balance;

    public void Deposit(double d)
    {
        if (d >= 0) _balance += d;
    }

    public double Withdraw(double a)
    {
        if (a < 0) return 0;
        if (SufficientBalance(a))
        {
            return _balance -= a;
        }
        return 0;

        
    }
    private bool SufficientBalance(double a)
    {
        if (a <= _balance) return true;
        return false;
    }
}