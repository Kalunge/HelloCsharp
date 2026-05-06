namespace ReferenceTypes;

class Program
{
    public static void Main()
    {
        // int firstNum = 35;
        // int secondNum = 77;
        //
        // int sum = Sum(firstNum, secondNum);
        // Console.WriteLine($"firstNum: {firstNum}");
        // Console.WriteLine($"secondNum: {secondNum}");
        // Console.WriteLine($"sum: {sum}");

        Repeat();
    }

    static int Sum(int firstNum, int secondNum)
    {
        firstNum = 22;
        secondNum = 18;

        return firstNum + secondNum;
    }

    static void Repeat()
    {
        string message = "Hello.";
        int times = 5;

        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(message);
        }
    }
}