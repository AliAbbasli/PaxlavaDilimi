using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Paxlava Dilimi");
        Console.WriteLine("Ölçünü daxil edin: ");
        int size = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= size; i++)
        {
            for (int k = size; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");

            }
            Console.WriteLine();
        }
        for (int i = size; i >= 1; i--)
        {
            for (int k = (size - 1); k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");

            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}