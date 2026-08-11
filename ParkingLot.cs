/*
1.Parking Lot
2.Type of Vehicle
3.parking space
4.price
*/
using System.Net.Security;

enum VehicleType
{
    CAR,
    BUS,
    BIKE
}
enum SpotType
{
    SMALL,
    LARGE,
    MEDIUM
}

abstract class Vehicle
{
    public string LicenseNo
    {
        get;
        set;
    }
    public VehicleType Type
    {
        get;
        set;
    }
    protected Vehicle(string licenseNo, VehicleType type)
    {
        LicenseNo = licenseNo;
        Type = type;


    }


}
class Car : Vehicle
{
    public Car(string license) : base(licenseNo, VehicleType.CAR)
    {

    }

}
class Bike : Vehicle
{
    public Bike(string license) : base(licenseNo, VehicleType.BIKE)
    {

    }

}
class Bus
{
    public Bus(string license) : base(license, VehicleType.BUS)
    {

    }

}
public abstract class ParkingSpot
{
    public int SpotNumber
    {
        get;
        set;
    }
    public bool IsFree
    {
        get;
        set;
    } = true;
    public Vehicle CurrentVehicle
    {
        get;
        private set;

    }
    public SpotType SpotType
    {
        get;
        set;
    }
    public void AssignVehicle(Vehicle vehicle)
    {
        CurrentVehicle = vehicle;
        IsFree = false;

    }
    public void RemoveVehicle()
    {
        CurrentVehicle = null;
        IsFree = true;
    }
}
public class BikeSpot : ParkingSpot
{
    public BikeSpot(int number)
    {
        SpotNumber = number;
        SpotType = SpotType.SMALL;
    }


}
public class CarSpot : ParkingSpot
{
    public CarSpot(int number)
    {
        SpotNumber = number;
        SpotType = SpotType.MEDIUM;

    }

}
public class BusSpot : ParkingSpot
{
    public BusSpot(int number)
    {
        SpotNumber = number;
        SpotType = SpotType.LARGE;

    }

}
public class ParkingFloor()
{
    public int FloorNumber
    {
        get;
        set;
    }
    public List<ParkingSpot> Spots
    {
        get;
        set;

    } = new List<ParkingSpot>();
    public ParkingFloor(int floor)
    {
        FloorNumber = floor;
    }


}
public class Ticket
{
    public string TicketNumber
    {
        get;
        set;

    }
    public DateTime EntryTime
    {
        get;
        set;
    }
    public Vehicle Vehicle
    {
        get;
        set;

    }
    public ParkingSpot Spot
    {
        get;
        set;
    }
}

class ParkingLot
{
    private List<ParkingFloor> floors = new();
    public void AddFloor(ParkingFloor floor)
    {
        floors.Add(floor);


    }
    private ParkingSpot FindAvailableSpot(Vehicle vehicle)
    {
        foreach (var floor in floors)
        {
            foreach (var spot in floor.Spots)
            {
                if (spot.IsFree && CanFitVehicle(vehicle, spot))
                {
                    return spot;
                }
            }
        }
        return null;

    }
    private bool CanFitVehicle(Vehicle vehicle, ParkingSpot spot)
    {
        return vehicle.Type switch
        {
            VehicleType.BIKE => spot.SpotType == SpotType.SMALL,
            VehicleType.CAR => spot.SpotType == SpotType.MEDIUM,
            VehicleType.BUS => spot.SpotType == SpotType.LARGE,
            _ => false

        };


    }
    public Ticket ParkVehicle(Vehicle vehicle)
    {
        ParkingSpot spot = FindAvailableSpot(vehicle);
        if (spot == null)
        {
            Console.WriteLine("No Spot Available");
            return null;
        }
        spot.AssignVehicle(vehicle);
        return new Ticket
        {
            TicketNumber = Guid.NewGuid().ToString(),
            EntryTime = DateTime.Now,
            Vehicle = vehicle,
            Spot = spot
        };

    }
    public void RemoveVehicle(Ticket ticket)
    {
        ticket.Spot.RemoveVehicle();

    }


}
public class PaymentService
{
    public decimal CalculateFee(Ticket ticket)
    {
        double hours = (DateTime.Now - ticket.EntryTime).TotalHours;
        return (decimal)Math.Ceiling(hours) * 20;

    }
}
