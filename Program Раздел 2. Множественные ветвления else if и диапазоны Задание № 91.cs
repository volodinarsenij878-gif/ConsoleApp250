using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program91
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите влажность воздуха (%): ");
            if (double.TryParse(Console.ReadLine(), out double humidity) && humidity >= 0 && humidity <= 100)
            {
                string status;
                if (humidity < 30)
                {
                    status = "сухой воздух";
                }
                else if (humidity <= 60)
                {
                    status = "комфорт";
                }
                else
                {
                    status = "повышенная влажность";
                }

                Console.WriteLine($"Статус: {status} (влажность: {humidity:F1}%)");
            }
            else
            {
                Console.WriteLine("Ошибка: влажность должна быть от 0 до 100%.");
            }
        }
    }
}