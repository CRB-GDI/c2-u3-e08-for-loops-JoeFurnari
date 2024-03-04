namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int maxNumber = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < maxNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(maxNumber);

            Console.WriteLine("Enter number:");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i < number)
                {
                    Console.Write("*");
                }
            }
        }
    }
}