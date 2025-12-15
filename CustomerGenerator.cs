public class CustomerGenerator
{
    private Random _random = new Random();
    private SimulationParameters _parameters;

    public CustomerGenerator(SimulationParameters parameters)
    {
        _parameters = parameters;
    }

    // Method to simulate customer arrivals
    public Customer GenerateCustomer()
    {
        int items = _random.Next(_parameters.ItemRange.MinItems, _parameters.ItemRange.MaxItems + 1);
        DateTime arrivalTime = DateTime.Now.AddSeconds(_random.NextDouble() * 5);  // Random arrival within 5 seconds
        return new Customer(Guid.NewGuid().GetHashCode(), arrivalTime, items);
    }

    // Method to simulate Poisson arrival distribution for customers
    public void GenerateCustomersOverTime(double timeInterval)
    {
        // Implement logic for customer arrival using Poisson distribution or a similar approach
    }
}

