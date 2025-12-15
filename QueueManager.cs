public class QueueManager
{
    public List<Queue<Customer>> Registers { get; set; }  // List of queues representing registers

    public QueueManager(int numberOfRegisters)
    {
        Registers = new List<Queue<Customer>>();
        for (int i = 0; i < numberOfRegisters; i++)
        {
            Registers.Add(new Queue<Customer>());
        }
    }

    // Method to add a customer to the shortest queue
    public void AddCustomerToShortestQueue(Customer customer)
    {
        // Implement logic to find the shortest queue and add the customer
    }

    // Method to process customers (simulate service at registers)
    public void ProcessCustomers(double timeInterval)
    {
        // Implement logic to simulate processing customers
    }
}

