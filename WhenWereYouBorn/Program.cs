using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on Teie nimi?");

            string FirstName = Console.ReadLine();

            Console.WriteLine($"Tere, mis on teie sünni aasta {FirstName}?");

            int SünniAasta = Convert.ToInt32(Console.ReadLine());



            int Age = 2021 - SünniAasta;

            Console.WriteLine("Teie vanus on " + Age);



            //programm kysib kasutaja sünni aasta
            //Progtamm arvutab kasutaja vanustr
            //programm kuvabkasutaja vanust
        }
    }
}
