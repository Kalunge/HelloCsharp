public class Test
{
    public static void DoWork()
    {
        // codeComments();
        // checkOrders();
        //formatCodeChallenge();
        // getUserInput();
        // SwitchCase();
        // Ternary();
        DoWHile();

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

    private static void getUserInput()
    {
        Console.WriteLine("Enter you age--------");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age >= 18)
            Console.WriteLine("You Are an adult");
        else
            Console.WriteLine("You are a minor");
    }

    private static void SwitchCase()
    {
        Console.WriteLine("Enter a 5 or a 10: ");
        int input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case <= 5:
                Console.WriteLine("You have entered a 5 or less");
                break;
            case >= 10:
                Console.WriteLine("You have entered a 10 or more");
                break;
            default:
                Console.WriteLine("You have neither entered a 5 or a 10");
                break;
                
        }
    }

    private static void Ternary()
    {
        Console.WriteLine("Please Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Youhave entered age {age}");


        string output = age >= 18 ? "You are an adult" : "You are a minor";
        Console.WriteLine(output);
    }

    private static void DoWHile()
    {
        int i = 10;

        do
        {
            Console.WriteLine($"I is {i}");
            Console.WriteLine("I am printed though i am less than 10");
        } while (i < 10);
    }
}