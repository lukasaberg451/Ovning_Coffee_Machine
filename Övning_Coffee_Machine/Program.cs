namespace Övning_Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallPrice = 10;
            int mediumPrice = 20;
            int largePrice = 30;
            int totalPrice = 0;
            string buyMore = "";

            do
            {
                Console.WriteLine("Please select your coffee size: 1 - Small 2 - Medium 3 - Large");
                if (!int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    Console.WriteLine("Invalid input, please enter a number");
                    continue;
                }
                    
                

                if (userChoice == 1)
                {
                    totalPrice = totalPrice + smallPrice;
                }
                else if (userChoice == 2)
                {
                    totalPrice = totalPrice + mediumPrice;
                }
                else if (userChoice == 3)
                {
                    totalPrice = totalPrice + largePrice;
                }
                else
                {
                    Console.WriteLine($"{userChoice} is not a valid option");
                    continue;
                }

                Console.WriteLine("Do you want to buy more coffee? Yes or No");
                buyMore = Console.ReadLine();
            }
            while (!buyMore.Equals("No", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Total to pay: {totalPrice}");
        }
    }
}
