public class CustomerGenerator
{
    private Random _random = new Random();
    private SimulationParameters _parameters;
    private QueueManager _queueManager;
    private int _customerIdCounter = 0;

    public CustomerGenerator(SimulationParameters parameters, QueueManager queueManager)
    {
        _parameters = parameters;
        _queueManager = queueManager;
    }

    // Method to simulate customer arrivals
    public Customer GenerateCustomer()
    {
        int items = _random.Next(_parameters.ItemRange.MinItems, _parameters.ItemRange.MaxItems + 1);
        DateTime arrivalTime = DateTime.Now.AddSeconds(_random.NextDouble() * 10);  // Random arrival within 10 seconds
        return new Customer(_customerIdCounter++, arrivalTime, items);
    }

    // Method to simulate Poisson arrival distribution for customers
    public void GenerateCustomersOverTime(double timeInterval)
    {
        double lambda = _parameters.CustomerArrivalRate * timeInterval; // Average number of arrivals in the interval
        int numberOfArrivals = PoissonRandom(lambda);

        for (int i = 0; i < numberOfArrivals; i++)
        {
            Customer newCustomer = GenerateCustomer();
            _queueManager.AddCustomerToShortestQueue(newCustomer);
        }}
    
        private int PoissonRandom(double lambda)
        {
            double l = Math.Exp(-lambda);
            int k = 0;
            double p = 1.0;
            do
            {
                k++;
                p *= _random.NextDouble();
            } while (p > l);
            return k - 1;
        }
    }
