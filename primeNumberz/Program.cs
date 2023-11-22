namespace primeNumberz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {                   
                    if (i % j == 0)
                    {
                        counter++;
                    }                                  
                }
                if (counter == 2)
                {
                    Console.Write(i + " ");                    
                }
                counter = 0;
            }
        }
    }
}

