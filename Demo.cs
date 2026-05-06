using Enums;
using Propperties;
using Structs;

class Demo
{
public static void Main()
{
    // Console.WriteLine("Welcome to the Demo Class");
    // WeekDay currentDay = WeekDay.Friday;
    // Console.WriteLine($"Today is {currentDay}");
    //
    // PrintMessageOfTheDay(WeekDay.Monday);
    // Point point = new Point { x = 23.33, y = 23.33 };
    // Point point = new Point (23.33, 23.33);
    // point.x = 23.33;
    // point.y = 234.33;
    // point.DisplayCoordinates();

    Car car = new();
    car.Model = "Lexus, Lx570";
    car.Price = 15000000;
    
    Console.WriteLine($"{car.Model} costs KES: {car.Price}");
}



static void PrintMessageOfTheDay(WeekDay weekDay)
{
    switch (weekDay)
    {
        case WeekDay.Monday:
            Console.WriteLine("Thank God it is Monday Again");
            break;
        default:
            Console.WriteLine("We wait for Monday");
            break;
    }
}
}