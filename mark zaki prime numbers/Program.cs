internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first num:");
        int first_num = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the secound num:");
        int secound_num = int.Parse(Console.ReadLine());

        Console.WriteLine("The prime numbers between {0} and {1} are:", first_num, secound_num);
        for (int i = first_num; i <= secound_num; i++)
        {
            if (prime_tester(i))
            {
                Console.Write(i + " ");
            }
        }
        }

        static bool prime_tester(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }