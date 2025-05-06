using System;

namespace Laba1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Лабораторна робота №1");
            Console.WriteLine("Студент: Перловська Анна");
            Console.WriteLine("Група: ІПЗ 42");
            Console.WriteLine();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nОберіть обчислення:");
                Console.WriteLine("1 - Площа паралелограма");
                Console.WriteLine("2 - Площа трикутника (формула Герона)");
                Console.WriteLine("3 - Площа бічної поверхні піраміди");
                Console.WriteLine("4 - Об’єм піраміди");
                Console.WriteLine("5 - Об’єм сфери");
                Console.WriteLine("0 - Вихід з програми");

                Console.Write("\nВаш вибір: ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    exit = true;
                    Console.WriteLine("До побачення!");
                }
                else
                {
                    switch (input)
                    {
                        case "1":
                            CalculateParallelogramArea();
                            break;
                        case "2":
                            CalculateTriangleAreaHeron();
                            break;
                        case "3":
                            CalculatePyramidLateralArea();
                            break;
                        case "4":
                            CalculatePyramidVolume();
                            break;
                        case "5":
                            CalculateSphereVolume();
                            break;
                        default:
                            Console.WriteLine("Невірний вибір! Спробуйте ще раз.");
                            break;
                    }
                }

                if (!exit)
                {
                    Console.WriteLine("\nНатисніть будь-яку клавішу, щоб продовжити...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        //площа паралелограма
        static void CalculateParallelogramArea()
        {
            Console.Write("\nВведіть основу паралелограма - довжина однієї зі сторін (a): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть висоту паралелограма (h): ");
            double h = double.Parse(Console.ReadLine());

            double area = a * h;
            Console.WriteLine($"Площа паралелограма: {area}");
        }

        //площа трикутника за формулою Герона
        static void CalculateTriangleAreaHeron()
        {
            Console.Write("\nВведіть сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine($"Площа трикутника за формулою Герона: {area}");
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не існує!");
            }

        }

        //площа бічної поверхні піраміди
        static void CalculatePyramidLateralArea()
        {
            Console.Write("\nВведіть периметр основи піраміди - сума всіх сторін (P): ");
            double P = double.Parse(Console.ReadLine());
            Console.Write("Введіть апофему піраміди - висота бічної грані (l): ");
            double l = double.Parse(Console.ReadLine());

            double area = 0.5 * P * l;
            Console.WriteLine($"Площа бічної поверхні піраміди: {area}");
        }

        //об’єм піраміди
        static void CalculatePyramidVolume()
        {
            Console.Write("\nВведіть площу основи піраміди (S): ");
            double S = double.Parse(Console.ReadLine());
            Console.Write("Введіть висоту піраміди (h): ");
            double h = double.Parse(Console.ReadLine());

            double volume = (1.0 / 3) * S * h;
            Console.WriteLine($"Об’єм піраміди: {volume}");
        }

        //об’єм сфери
        static void CalculateSphereVolume()
        {
            Console.Write("\nВведіть радіус сфери (r): ");
            double r = double.Parse(Console.ReadLine());

            double volume = (4.0 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Об’єм сфери: {volume}");
        }
    }
}
