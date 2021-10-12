using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;

            while (i < 3)
            {
                Console.WriteLine("Login: ");
                string Login = Console.ReadLine();
                Console.WriteLine("Password: ");
                string Password = Console.ReadLine();
                Console.WriteLine("PIN-kood: ");
                string PIN = Console.ReadLine();


                if (PIN == "1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

                else if ((Login == "user1") && (Password == "password1") && (PIN == "1234"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((Login != "user1") && (Password == "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else if ((Login == "user1") && (Password != "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti! {3 - i} katset on jäänud.");
                }

            }
        }
    }
}
