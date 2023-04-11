interface IPayable
{
    string Name{ get; set; }
    string Info{ get; }

    void GetPaymentAmount() { }
}