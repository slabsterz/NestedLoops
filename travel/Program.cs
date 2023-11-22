namespace travel
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }
                
                double neededBudget = double.Parse(Console.ReadLine());
                double totalSaved = 0;

                while (neededBudget > totalSaved)
                {
                    int income = int.Parse(Console.ReadLine());
                    totalSaved += income;
                    Console.WriteLine($"Collected: {totalSaved:f2}");

                    if (neededBudget <= totalSaved)
                    {                       
                       Console.WriteLine($"Going to {destination}!");
                    }
                }
            }
        }
    }
}