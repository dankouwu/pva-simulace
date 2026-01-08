using System;

public class Customer
{
    public int Id { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int Items { get; set; }
    public int ServiceTime { get; set; }

    public int ServiceStartTime { get; set; }
    public int DepartureTime { get; set; }

    public int NumberOfItems
    {
        get => Items;
        set => Items = value;
    }

    public Customer(int id, DateTime arrivalTime, int items)
    {
        Id = id;
        ArrivalTime = arrivalTime;
        Items = items;
        ServiceTime = 0;
        ServiceStartTime = 0;
        DepartureTime = 0;
    }
}
