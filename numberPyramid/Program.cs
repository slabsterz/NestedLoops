namespace numberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int row = 1; row <= input; row++) 
            {
                for (int i = 1; i <= row; i++)
                {
                    if (sum > input)
                    {
                        break;
                    }

                    Console.Write(sum + " ");                   
                    sum++;
                }                

                if (sum > input)
                {
                    break;
                }

                Console.WriteLine();
            }            
        }
    }
}
