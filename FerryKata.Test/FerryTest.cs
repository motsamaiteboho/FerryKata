namespace FerryKata.Test;
using FerryKata;
public class FerryTest
{
    [Fact]
    public void ShoudReturnAccepted()
    {
        Car car1 = new Car("Blue", 4);
        Ferry ferry = new Ferry(2, 6);
        Assert.Equal("Accepted", ferry.board(car1));
    }
    [Fact]
    public void ShoudReturnRejectedDueToExceddingMaxNumberOfPeople()
    {
        Car car1 = new Car("Blue", 4);
        Ferry ferry = new Ferry(2, 1);
        Assert.Equal("Rejected", ferry.board(car1));
    }
    [Fact]
    public void ShoudReturnRejectedDueToExceddingMaxNumberOfCars()
    {
        Car car1 = new Car("Blue", 4);
        Car car2 = new Car("Black",3);
        Car car3 = new Car("Red", 5);
        Ferry ferry = new Ferry(2, 1);
        ferry.board(car1);
        ferry.board(car2);
        Assert.Equal("Rejected", ferry.board(car3));
    }
    [Fact]
    public void ShoudReturnHalfPriceAfter3Trips()
    {
        Car car1 = new Car("Blue", 4);
        Car car2 = new Car("Black",4);
        Car car3 = new Car("Red", 5);
        Ferry ferry = new Ferry(6, 50);
        ferry.board(car1); //first trip
        ferry.board(car1); //second trip
        ferry.board(car1); // third trip
        Assert.Equal("half price", ferry.board(car1)); //forth trip
    }

    [Fact]
    public void ShoudReturnFreefter7Trips()
    {
        Car car1 = new Car("Blue", 4);
        Car car2 = new Car("Black",4);
        Car car3 = new Car("Red", 5);
        Ferry ferry = new Ferry(10, 100);
        ferry.board(car1); //first trip
        ferry.board(car1); //second trip
        ferry.board(car1); // third trip
        ferry.board(car1); // forth trip
        ferry.board(car1); // fifth trip
        ferry.board(car1); // sixth trip
        ferry.board(car1); // seventh trip
        Assert.Equal("you go free", ferry.board(car1)); //eighth trip
    }
    [Fact]
    public void ShoudReturnNumberCarsOfColor()
    {
        Car car1 = new Car("Blue", 4);
        Car car2 = new Car("Black",4);
        Car car3 = new Car("Red", 5);
        Ferry ferry = new Ferry(7, 40);
        ferry.board(car1); 
        ferry.board(car1); 
        ferry.board(car2); 
        ferry.board(car3);
        ferry.board(car2); 
        ferry.board(car1);
        Assert.Equal(3, ferry.NumOfCarOfColor("Blue"));
    }
    [Fact]
    public void ShoudUpdateCarCountWhenCarLeaveFerry()
    {
        Car car1 = new Car("Blue", 4);
        Car car2 = new Car("Black",4);
        Car car3 = new Car("Red", 5);
        Ferry ferry = new Ferry(4, 30);
        ferry.board(car1); 
        ferry.board(car2); 
        ferry.board(car3);
        ferry.leaveFerry(car1);
        Assert.Equal(2, ferry.car_count);
    }
     [Fact]
    public void ShoudUpdatePeopleCountWhenCarLeaveFerry()
    {
        Car car1 = new Car("Blue", 4);
        Car car2 = new Car("Black",6);
        Car car3 = new Car("Red", 5);
        Ferry ferry = new Ferry(4, 23);
        ferry.board(car1); 
        ferry.board(car2); 
        ferry.board(car3);
        ferry.leaveFerry(car1);
        Assert.Equal(11, ferry.people_count);
    }
}