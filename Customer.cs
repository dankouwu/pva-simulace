using System;

public class Customer
{
    public int Id { get; set; }
    public int ArrivalTimeSeconds { get; set; }
    public int Items { get; set; }
    public int ServiceTime { get; set; }

    public int ServiceStartTime { get; set; }
    public int DepartureTime { get; set; }

    public int NumberOfItems
    {
        get => Items;
        set => Items = value;
    }

    public Customer(int id, int arrivalTimeSeconds, int items)
    {
        Id = id;
        Items = items;
        ServiceTime = 0;
        ServiceStartTime = 0;
        DepartureTime = 0;
        ArrivalTimeSeconds = arrivalTimeSeconds;
    }
}
