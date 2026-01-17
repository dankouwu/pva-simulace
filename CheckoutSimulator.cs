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
        int currentTimeSeconds = 0;
        int maxQueueLength = 0;
        var stats = new Statistics();

        Console.WriteLine("Simulace běží...\n");

        while (currentTimeSeconds < _parameters.SimulationDuration)
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
            {
                break;
            }

            _customerGenerator.GenerateCustomersOverTime(1, currentTimeSeconds);
            _queueManager.ProcessCustomers(1, currentTimeSeconds);

            int currentMax = _queueManager.Registers.Any() ? _queueManager.Registers.Max(r => r.Count) : 0;
            if (currentMax > maxQueueLength) maxQueueLength = currentMax;

            double liveAvgWait = CalculateLiveAverageWaitingTime(currentTimeSeconds);
            int totalProcessed = _queueManager.ProcessedCustomers.Count;

            Console.Clear();
            Console.WriteLine("Simulace běží...\n");
            Console.WriteLine($"Čas: {currentTimeSeconds + 1} s");
            for (int i = 0; i < _queueManager.Registers.Count; i++)
            {
                int count = _queueManager.Registers[i].Count;
                string bar = new string('#', count);
                Console.WriteLine($"Pokladna {i + 1}: {bar} ({count} zákazníků)");
            }
            Console.WriteLine($"Průměrná doba čekání: {liveAvgWait:F1} s");
            Console.WriteLine($"Maximální délka fronty: {maxQueueLength}");
            Console.WriteLine($"Celkově obslouženo: {totalProcessed} zákazníků");

            Thread.Sleep(1000);
            currentTimeSeconds++;
        }

        stats.CalculateStatistics(_queueManager.ProcessedCustomers, maxQueueLength);
        stats.DisplayStatistics();
    }

    private double CalculateLiveAverageWaitingTime(int currentTimeSeconds)
    {
        double totalWait = 0;
        int count = 0;

        foreach (var c in _queueManager.ProcessedCustomers)
        {
            totalWait += Math.Max(0, c.ServiceStartTime - c.ArrivalTimeSeconds);
            count++;
        }

        foreach (var register in _queueManager.Registers)
        {
            foreach (var c in register)
            {
                if (c.ServiceStartTime > 0)
                    totalWait += Math.Max(0, c.ServiceStartTime - c.ArrivalTimeSeconds);
                else
                    totalWait += Math.Max(0, currentTimeSeconds - c.ArrivalTimeSeconds);

                count++;
            }
        }

        return count == 0 ? 0 : totalWait / count;
    }
}

