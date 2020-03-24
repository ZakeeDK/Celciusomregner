using System;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double UserInput = 0;

            // User input Fahrenheir/Reaumur.
            Console.WriteLine("Vælg\n1. Reaumur\n2. Fahrenheit");
            string Chose = Console.ReadLine();

            Console.Write("Indtast Celcius: ");
         
            //User input
            UserInput = Convert.ToDouble(Console.ReadLine());


            switch (Chose)
            {
                case "1":
                    Console.WriteLine("Det er så mange Reaumur: " + Reaumur(UserInput));
                    break;
                case "2":
                    Console.WriteLine("Det er så mange Fahrenheit: " + Fahrenheit(UserInput));
                    break;
            }

        }

        static double Reaumur(double UserInput)
        {
            //Nedenfor prøvede jeg at opratte en varibale det holdet udregning en som ikke virkede.. 
            //double R = 0.08;
            double Rasultat = UserInput * 0.8;
            return Rasultat;
        }
        static double Fahrenheit(double UserInput)
        {
            //Nedenfor prøvede jeg at opratte en varibale det holdet udregning en som ikke virkede.. 
            //double F = 1.8 + 32;
            double Rasultat = UserInput * 1.8 + 32;
            return Rasultat;
        }
    }
}
