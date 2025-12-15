public class SimulationParameters
{
    public int NumberOfRegisters { get; set; }  // Number of registers (cashiers)
    public int SimulationDuration { get; set; }  // Duration of the simulation in seconds
    public double CustomerArrivalRate { get; set; }  // Average number of customers per second
    public (int MinItems, int MaxItems) ItemRange { get; set; }  // Range of items per customer

    // Constructor to initialize with default values
    public SimulationParameters() { }

    // Method to get input from the user
    public void GetUserInput()
    {
        // Implement input validation and assignment
    }

    // Method to save configuration to a file (optional)
    public void SaveConfiguration()
    {
        // Implement save functionality to text file
    }
}

