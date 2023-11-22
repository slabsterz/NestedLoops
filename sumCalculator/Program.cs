namespace sumCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

                int numberInput = int.Parse(input);

                string numberString = numberInput.ToString();
                int sumDigits = 0;

                for (int i = 0; i < numberString.Length; i++)
                {
                    int digit = int.Parse(numberString[i].ToString());
                    sumDigits += digit;

                    if (i == numberString.Length-1)
                    {
                        Console.WriteLine($"Sum of digits = {sumDigits}");
                    }
                }
            }
        }
    }
}