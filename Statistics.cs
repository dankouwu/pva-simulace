public class Statistics
{
    public double AverageWaitingTime { get; set; }
    public int MaxQueueLength { get; set; }
    List<Customer> ProcessedCustomers { get; set; }
    public int TotalCustomersProcessed { get; set; }

    // Method to calculate statistics
    public void CalculateStatistics(List<Customer> processedCustomers, List<Queue<Customer>> registers)
    {
        // Implement logic for calculating statistics (average wait time, max queue length, etc.)
    }

    // Method to display the statistics
    public void DisplayStatistics()
    {
        // Implement the display logic on the console
    }
}

