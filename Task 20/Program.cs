using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    class Program
    {
        delegate double CircleDeligate(double r);

        static void Main(string[] args)
        {
            CircleDeligate circleDeligate = Circumference;
            Console.WriteLine("Ввдите радиус:\t");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double le = circleDeligate(r);
            Console.WriteLine("Длина окружности равна: " + le + "\t");
            Console.WriteLine();

            circleDeligate = CircleArea;
            double ar = circleDeligate(r);
            Console.WriteLine("Площадь круга равна: " + ar + "\t");
            Console.WriteLine();

            circleDeligate = SphereVolume;
            double sp = circleDeligate(r);
            Console.WriteLine("Объем сферы равен: " + sp + "\t");
            Console.WriteLine();



            Console.ReadKey();
        }

        static double Circumference(double r) =>  2 * Math.PI * r;
        static double CircleArea(double r) => Math.PI * Math.Pow(r, 2);
        static double SphereVolume(double r) => 4  * Math.PI * (Math.Pow(r, 3)) / 3;


    }
}
