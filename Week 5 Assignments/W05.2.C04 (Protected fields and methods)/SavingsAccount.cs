public class SavingsAccount: BankAccount
{
    private bool _locked;

    public SavingsAccount(double b, double i): base(b, i)
    {
        _locked = true;
    }

    public override double Withdraw(double a)
    {
        if (_locked) return 0;
        return base.Withdraw(a);
    }

    public override void NextYear()
    {
        YearsPassed++;
        if (YearsPassed < 5) base.NextYear();
        else _locked = false;
    }
}