public class Program 
{
    public static void Main()
    {
        List<Bill> Bills = new() {
            new ElectricityBill(50, "John Smith"), 
            new ElectricityBill(75, "Jane Doe"),
            new GasBill(100, "Bob Johnson", false),
            new GasBill(125, "John Doe", true)};

        int totalAmount = 0;
        foreach (Bill bill in Bills)
        {
            totalAmount += (int)bill.Amount;
            Console.WriteLine(bill.GetDescription());
        }
        Console.WriteLine($"Total amount: {totalAmount}");
    }
}