namespace FerryKata;
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Blue", 4);
        Car car2 = new Car("Black",3);
        Car car3 = new Car("Red", 5);
        Car car4 = new Car("Black",3);
        Car car5 = new Car("White", 4);
        Car car6 = new Car("Silver",3);

        Ferry ferry = new Ferry(50, 50);
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.board(car2));
        Console.WriteLine(ferry.board(car3));
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.board(car1));
        Console.WriteLine(ferry.NumOfCarOfColor("Blue"));
    }
}
