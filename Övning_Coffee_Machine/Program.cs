namespace Övning_Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallPrice = 10;
            int mediumPrice = 20;
            int largePrice = 30;

            Console.WriteLine("Please select your coffee size:");
            int userchoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you want to buy more coffee? Yes or No");
            string buyMore = Console.ReadLine();

        }
    }
}
