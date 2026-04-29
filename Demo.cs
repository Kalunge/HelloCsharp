using Enums;

class Demo
{
public static void Main()
{
    Console.WriteLine("Welcome to the Demo Class");
    WeekDay currentDay = WeekDay.Friday;
    Console.WriteLine($"Today is {currentDay}");
    
    PrintMessageOfTheDay(WeekDay.Monday);
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