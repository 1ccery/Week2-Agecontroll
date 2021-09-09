using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on Teie nimi?");

            string FirstName = Console.ReadLine();

            Console.WriteLine($"Palun sisestage oma vanus {FirstName}");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Oled piisavalt vana.");
            }
            else if (age < 18)
            {
                Console.WriteLine("Oled liiga noor.");

            }
            else
            {
                Console.WriteLine("Oledki 18.");
            }



            //programm küsib kasutaja vanust
            //programm kasutaja on vanem ku i18, siis kuvatakse "sa oled piisavalt vana"
            // kui kasutaja on nooorem ki 18 siis konsool kuvab et "oled liiga noor"
            //kui kasutaja on 18 siis Kuvatakse "oledki 18 "

        }
    }
}
