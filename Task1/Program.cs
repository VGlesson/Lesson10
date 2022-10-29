using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Angle angle = new Class_Angle();
            Console.WriteLine("Задайте угол с помощью целочисленных значений");
            Console.WriteLine("Введите градус");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите cекунды");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(angle);
            Console.ReadKey();
        }
         double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
