namespace FerryKata;
public class Car 
{
    
    public Car(string pColour, int pPassengerCount)
    {
        colour = pColour;
        passengerCount = pPassengerCount;
    }

    public readonly string colour;
    public readonly int passengerCount;
}