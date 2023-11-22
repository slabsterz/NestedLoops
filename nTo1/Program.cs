namespace nTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i > 0; i--)
            {
                Console.Write(i);
                for (int j = i; j == i; j--)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}