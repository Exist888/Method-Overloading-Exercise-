namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(5, 3);
            Add(5.2, 3.3);
            Add(4, 7, true);
            Add(0, 1, true);
            Add(5, -8, true);
            Add(5, 3, false);
        }

        static int Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine(sum);
            return sum;
        }

        static double Add(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
            return sum;
        }

        static string Add(int x, int y, bool isDebit)
        {
            int sum = x + y;
            if (isDebit == true && sum > 1)
            {
                Console.WriteLine($"{sum} dollars");
                return $"{sum} dollars";
            }
            else if (isDebit == true && sum == 1)
            {
                Console.WriteLine($"{sum} dollar");
                return $"{sum} dollar";
            }
            else if (isDebit == true && sum < 1)
            {
                Console.WriteLine($"{sum} dollars");
                return $"{sum} dollars";
            }
            else
            {
                Console.WriteLine($"{sum}");
                return sum.ToString();
            }
        }
    }
}