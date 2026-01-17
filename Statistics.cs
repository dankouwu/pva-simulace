public class Statistics
{
    public double AverageWaitingTime { get; set; }
    public int MaxQueueLength { get; set; }
    List<Customer> ProcessedCustomers { get; set; }
    public int TotalCustomersProcessed { get; set; }

    // Method to calculate statistics
    public void CalculateStatistics(List<Customer> processedCustomers, int maxQueueLength)
    {
        ProcessedCustomers = processedCustomers;
        MaxQueueLength = maxQueueLength;
        TotalCustomersProcessed = processedCustomers.Count;

        if (processedCustomers.Count == 0)
        {
            AverageWaitingTime = 0;
            return;
        }

        double totalWait = processedCustomers.Sum(c => Math.Max(0, c.ServiceStartTime - c.ArrivalTimeSeconds));
        AverageWaitingTime = totalWait / processedCustomers.Count;
    }

    // Method to display the statistics
    public void DisplayStatistics()
    {
        Console.WriteLine($"\nPrůměrná doba čekání: {AverageWaitingTime:F1} s");
        Console.WriteLine($"Maximální délka fronty: {MaxQueueLength}");
        Console.WriteLine($"Celkově obslouženo: {TotalCustomersProcessed} zákazníků");
    }
}

