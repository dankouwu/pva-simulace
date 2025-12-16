public class CheckoutSimulator
{
    private SimulationParameters _parameters;
    private QueueManager _queueManager;
    private CustomerGenerator _customerGenerator;

    public CheckoutSimulator(SimulationParameters parameters)
    {
        _parameters = parameters;
        _queueManager = new QueueManager(parameters.NumberOfRegisters);
        _customerGenerator = new CustomerGenerator(parameters, _queueManager);
    }

    // Main simulation loop
    public void RunSimulation()
    {
        // Implement the logic for running the simulation, processing customers, and updating the state
    }

    // Method to generate customers
    private void GenerateCustomers()
    {
        // Call the GenerateCustomer method and add the generated customer to the queue
    }

    // Method to handle customer checkout
    private void ProcessCheckout()
    {
        // Process the customers at the registers
    }

    // Method to handle statistics calculation
    private void CalculateStatistics()
    {
        // Calculate and display statistics like average waiting time, max queue length, etc.
    }
}

