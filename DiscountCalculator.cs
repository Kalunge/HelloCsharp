namespace DiscountCalculator
{
    class Discount
    {
        public static void Main()
        {
            Console.WriteLine("== Retail Discount Calculator==");
            Console.Write("Please Enter Amount: ");
            string strAmount = Console.ReadLine();
            double discountRate = 0.15;

            if (double.TryParse(strAmount, out double amount))
            {
                if (amount >= 100)
                {
                    amount = (1 - discountRate) * amount;
                    Console.WriteLine($"Your final price is {amount}");
                }
                else
                {
                    Console.WriteLine($"Your final price is {amount}"); 
                }
            }
            else
            {
                Console.WriteLine("Invalid Input please try again");
            }
        }
    }
}

// Prompt the user to enter the original price of an item.
//
// Safely parse the input string into a numeric format.
//
// Determine if the price qualifies for a 15% discount (price >= 100).
//
// Calculate the final amount after the potential discount.
//
// Print the final price to the console, formatted clearly for the cashier.
//
// Display an error message if the user enters invalid text.