public class QueueManager
{
    public List<List<Customer>> Registers { get; set; }  // List of lists representing registers
    public double ProcessTimePerItem { get; set; } = 2.0; // Time taken to process each item in seconds
    public double PaymentTime { get; set; } = 15.0; // Fixed time for payment in seconds
    public List<Customer> ProcessedCustomers { get; set; } // List to store processed customers

    public QueueManager(int numberOfRegisters)
    {
        Registers = new List<List<Customer>>();
        for (int i = 0; i < numberOfRegisters; i++)
        {
            Registers.Add(new List<Customer>());
        }
        ProcessedCustomers = new List<Customer>();
    }

    // Method to add a customer to the shortest register (list)
    public void AddCustomerToShortestQueue(Customer customer)
    {
        var shortestQueue = Registers.OrderBy(r => r.Count).First();
        shortestQueue.Add(customer);
    }

    // Method to process customers (simulate service at registers)
    public void ProcessCustomers(double timeInterval, int currentTimeSeconds)
    {
        foreach (var register in Registers)
        {
            if (register.Count == 0) continue;

            var currentCustomer = register.First();

            if (currentCustomer.ServiceTime <= 0)
            {
                currentCustomer.ServiceTime = (int)Math.Ceiling((currentCustomer.NumberOfItems * ProcessTimePerItem) + PaymentTime);
                if (currentCustomer.ServiceStartTime == 0)
                {
                    currentCustomer.ServiceStartTime = currentTimeSeconds;
                }
            }

            currentCustomer.ServiceTime -= (int)timeInterval;

            if (currentCustomer.ServiceTime <= 0)
            {
                currentCustomer.DepartureTime = currentTimeSeconds;
                ProcessedCustomers.Add(currentCustomer);
                register.RemoveAt(0);
            }
        }
    }
}