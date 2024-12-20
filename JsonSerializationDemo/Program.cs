using JsonSerializationDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Choose logger: 1 - Console, 2 - File");
        int choice = int.Parse(Console.ReadLine() ?? "1");

        ILogger logger = choice switch
        {
            1 => new ConsoleLogger(),
            2 => new FileLogger(),
            _ => throw new ArgumentException("Invalid choice")
        };

        var service = new OrderService(logger);
        service.PlaceOrder("Laptop");
    }
}
