using System;

namespace Project_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double delta;
                Console.WriteLine("Do wyliczenia delty, prosze podać liczbę a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    throw new Exception("Liczba 'a' powinna byc różny od 0");
                }
                Console.WriteLine("Proszę podać liczbę b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Proszę podać liczbe c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                delta = b * b - 4 * a * c;

                Console.WriteLine("Delta wynosi: {0}", delta);

                if (delta > 0)
                {

                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Szukane liczby wynoszą: {0}, {1}", x1, x2);

                }
                else
                {
                    if (delta == 0)
                    {
                        double x1 = (-b / 2 * a);
                        Console.WriteLine("Szukana liczba wynosi: {0}", x1);

                    }
                    else
                        Console.WriteLine("Równanie nie ma pierwiastków");

                }
            }
            catch (Exception wyjatek)
            {
                Console.WriteLine("Nieprawidłowy parametr. {0}", wyjatek.Message);
            }

            Console.ReadLine();