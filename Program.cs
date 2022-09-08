using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double m;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите переменную >0 и не = 2/3");
                    m = Convert.ToDouble(Console.ReadLine());

                    if(m <= 0.0 || m == (2.0 / 3.0))
                    {
                        Console.WriteLine("Не выполнено ОДЗ");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный формат числа");
                }
            }
            Console.Write("z1 = ");
            Console.WriteLine("{0:0.#######}", z1(m));
            Console.Write("z2 = ");
            Console.WriteLine("{0:0.#######}", z2(m));
            Console.ReadKey();

        }

        private static double z1(double m)
        {
            double z1;
            
            z1 = Math.Sqrt((3*m+2)* (3 * m + 2)-24*m)/ (3 * Math.Sqrt(m) - 2 / Math.Sqrt(m));
            return z1;
        }
        private static double z2(double m)
        {
            double z2;
            
            z2 = Math.Sqrt(m);
            return z2;
        }
    }
}
