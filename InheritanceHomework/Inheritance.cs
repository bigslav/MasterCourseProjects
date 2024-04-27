namespace InheritanceHomework;

public class Vehicle
{
    public int passengersCount { get; set; }

    public void Move()
    {
    }

    public void Stop()
    {
    }
}

public class Car : Vehicle
{
    public int wheelsCount { get; set; }
    public bool hasRoof { get; set; }

    public void FastenSeatBelt()
    {
    }
}

public class Boat : Vehicle
{
    public bool isMechanical;
    public bool isUnderwater;

    public void DropAnchor()
    {
    }
}

public class Motorcycle : Vehicle
{
    public bool isMountain;

    public void RideOnBackWheel()
    {
    }
}