using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Step 1: Collect simulation parameters
        SimulationParameters parameters = new SimulationParameters();
        parameters.GetUserInput();

        // Step 2: Start the simulation
        CheckoutSimulator simulator = new CheckoutSimulator(parameters);
        simulator.RunSimulation();

        // Step 3: Display results
        Statistics stats = new Statistics();
        stats.DisplayStatistics();
    }
}

