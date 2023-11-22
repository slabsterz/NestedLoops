namespace building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int estatesCount = int.Parse(Console.ReadLine());           
            string type = "";

           for (int floors = floorsCount; floors >= 1; floors--)
            {
                
                for (int estates = 0; estates < estatesCount; estates++)
                {
                    if (floors == floorsCount)
                    {
                        type = "L";
                    }
                    else if (floors % 2 != 0)
                    {
                        type = "A";
                    }
                    else if (floors % 2 == 0)
                    {
                        type = "O";
                    }
                    Console.Write($"{type}{floors}{estates} "); 

                }
                Console.WriteLine();
            }
        }
    }
}