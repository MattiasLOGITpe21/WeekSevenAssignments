using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage eesnimi:");
            string eesnimi = Console.ReadLine();

            if (eesnimi.Length > 5)
            {
                for (int i = eesnimi.Length - 1; i >= 0; i--)
                {
                    Console.Write(eesnimi[i]);
                }
            }
            else 
            {
                Console.WriteLine(eesnimi);
            }

        }
    }
}
