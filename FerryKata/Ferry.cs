namespace FerryKata;
public class Ferry
{
    private List<Car> lstCars = new List<Car>();
    public Ferry(int pCarsAllowed, int pPeopleAllowed)
    {
       cars_Allowed = pCarsAllowed;
       people_Allowed = pPeopleAllowed;
    }
    
    public readonly int cars_Allowed;
    public readonly int people_Allowed;
    public  int car_count {get; private set;}
    public int people_count {get; private set;}
    public string board(Car car)
    {
        car_count++;
        people_count += car.passengerCount;
        if(people_count <=  people_Allowed && car_count <= cars_Allowed)
        {
            lstCars.Add(car);
            int count = lstCars.Count(o => o == car);
            if(count == 4)
            {
                return "half price";
            }
            if(count == 8)
            {
                return "you go free";
            }
            return "Accepted";
        }
        car_count--;
        people_count -= car.passengerCount; 
        return "Rejected";
    }
    public int NumOfCarOfColor(string color)
    {
        return lstCars.Count(o => o.colour == color);
    }

    public void  leaveFerry( Car car)
    {
        car_count--;
        people_count -= car.passengerCount;
    }
}