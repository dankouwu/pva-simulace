public class SimulationParameters
{
    public int NumberOfRegisters { get; set; }  // Number of registers (cashiers)
    public int SimulationDuration { get; set; }  // Duration of the simulation in seconds
    public double CustomerArrivalRate { get; set; }  // Average number of customers per second
    public (int MinItems, int MaxItems) ItemRange { get; set; }  // Range of items per customer

    private GetUserInput _userInputHelper = new GetUserInput();

    // Constructor to initialize with default values
    public SimulationParameters() { }

    // Method to get input from the user
    public void GetUserInput()
    {
        NumberOfRegisters = _userInputHelper.GetIntInput("Enter the number of registers (cashiers): ");
        SimulationDuration = _userInputHelper.GetIntInput("Enter the duration of the simulation (in seconds): ");
        CustomerArrivalRate = _userInputHelper.GetDoubleInput("Enter the average customer arrival rate (customers per second): ");
        ItemRange = _userInputHelper.GetItemRangeInput("Enter the minimum number of items per customer: ", "Enter the maximum number of items per customer: ");
    }

    public void DisplayParameters()
    {
        Console.WriteLine("\nSimulation Parameters:");
        Console.WriteLine($"Number of Registers: {NumberOfRegisters}");
        Console.WriteLine($"Simulation Duration: {SimulationDuration} seconds");
        Console.WriteLine($"Customer Arrival Rate: {CustomerArrivalRate} customers/second");
        Console.WriteLine($"Item Range per Customer: {ItemRange.MinItems} to {ItemRange.MaxItems} items");
    }
}

