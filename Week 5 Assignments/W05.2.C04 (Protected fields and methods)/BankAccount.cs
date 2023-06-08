public class BankAccount
{
    private double _balance;
    protected int YearsPassed = 0;
    protected double InterestRate;

    public BankAccount(double b, double i)
    {
        _balance = b;
        InterestRate = i;
    }

    public double ReadBalance() => _balance;

    public void Deposit(double d)
    {
        if (d >= 0) _balance += d;
    }

    public virtual double Withdraw(double a)
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
    public virtual void NextYear()
    {
        ApplyInterest();
    }

    protected void ApplyInterest()
    {
        _balance *= (1 + InterestRate);
    }
}