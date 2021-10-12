using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstname = Console.ReadLine().ToUpper();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastname = Console.ReadLine().ToUpper();

            Console.WriteLine($"Tere, {firstname[0]}. {lastname[0]}.");
        }
    }
}
