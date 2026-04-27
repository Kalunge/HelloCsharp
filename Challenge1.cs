public class Test
{
    public static void DoWork()
    {
        // codeComments();
        // checkOrders();
        formatCodeChallenge();
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

    private static void checkOrders()
    {
        Random random = new Random();
        string[] orderIds = new string[5];
        
        for (int i = 0; i < orderIds.Length; i++)
        {
            int prefixValue = random.Next(65, 70);

            string prefix = Convert.ToChar(prefixValue).ToString();

            string suffix = random.Next(1, 1000).ToString("000");

            orderIds[i] = prefix + suffix;
        }

        foreach (var orderId in orderIds)
        {
            Console.WriteLine(orderId);
        }
    }

    private static void formatCodeChallenge()
    {
        string sentence = "The quick brown fox jumps over the lazy dog.";

        char[] charMessage = sentence.ToCharArray();

        Array.Reverse(charMessage);
        int charCount = 0;

        foreach (var letter in charMessage)
        {
            if (letter == 'o')
            {
                charCount++;
            }
        }

        string newMessage = new string(charMessage);

        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {charCount} times.");
    }

}