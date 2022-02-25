using System;

namespace KoordinatSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = -5; i <= 5; i++)
            {
                for (int j = -5; j <= 5; j++)
                {
                    if (i >= 0)
                    {
                        Console.Write($" ( {i},{j}) ");
                    }
                    else
                    {
                        Console.Write($" ({i},{j}) ");
                    }
                }
                Console.WriteLine(); Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
