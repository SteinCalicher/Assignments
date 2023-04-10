class Car : ICommute
{
    public int Mileage { get; private set; }
    public Car() => Mileage = 0;
    public void Move(int i) => Console.WriteLine($"drove {i} kms\nMileage: {Mileage += i} kms");
}