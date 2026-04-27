public class Test
{
    public static void DoWork()
    {
        codeComments();
    }


    private static void variableNaming()
    {
        char userOption;
        int gameScore;
        float particlesPerMillion;
        bool processedCustomer;
    }


    private static void codeComments()
    {
        string firstName = "Bob";
        int widgetsPurchased = 7;
        //testing
        // int widgetsSold = 7;
        // Console.WriteLine($"{firstName} sold {widgetsSold} widgets");
        Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets");
    }
}