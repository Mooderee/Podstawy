using System;

namespace Program1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 liczby dodatnie");
            int liczba1 = int.Parse(Console.ReadLine());
            int liczba2 = int.Parse(Console.ReadLine());


            while (liczba1 < 0 || liczba2 < 0)
            {
                if (liczba1 < 0)
                {
                    Console.WriteLine("Zła liczba, podaj pirerwszą liczbę dodatnią:");
                    liczba1 = int.Parse(Console.ReadLine());
                }
                else if (liczba2 < 0)
                {
                    Console.WriteLine("Zła liczba, podaj drugą liczbę dodatnią:");
                    liczba2 = int.Parse(Console.ReadLine());
                }
            }

            // Obliczenie średniej arytmetycznej:
                    double srednia = (liczba1 + liczba2) / 2.0;

            // Wyświetlenie wyniku:
            Console.WriteLine("Średnia arytmetyczna to: " + srednia);
        }
    }
}
