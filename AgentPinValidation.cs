namespace PinValidator
{
    class PinValidator
    {
        public static void Main()
        {
            int correctPin = 1234;
            int numberOfAttempts = 0;
            
            Console.WriteLine("=== KCB Bank Atm ===");
    

            while (numberOfAttempts < 3)
            {
                Console.WriteLine("--- Please enter Your Pin---");
                string pin = Console.ReadLine();
                if (int.TryParse(pin, out int intPin))
                {
                    if (intPin == correctPin)
                    {
                        Console.WriteLine("You Have enetered The correct Pin");
                        break;
                    }
                    else
                    {
                        numberOfAttempts++;
                        Console.WriteLine($"You Have  {3 - numberOfAttempts} Remaining");
                    }
                }
            }

           string output =  numberOfAttempts >= 3 ? 
               "You Have Blocked your card please contact Customer Care" 
               : "Enjoy Your Day";
           Console.WriteLine(output);
            {
                
            }
        }
    }
}

// Store a correct 4-digit PIN as a constant integer (e.g., 1234).
//     Track the number of attempts the user has made, starting from one.
//     Prompt the user for their PIN and safely parse it to ensure it is a valid number.
//     Compare the user's input to the correct PIN.
//     Exit the loop immediately if the PIN is correct and display a success message.
//     If the PIN is incorrect, inform the user how many attempts they have left.
//     If all three attempts are exhausted without a correct entry, display an account lockout message.