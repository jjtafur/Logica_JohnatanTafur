using System;

namespace EjercicioSeguimiento
{
    internal class Program
    {
        internal class Ecuacioncuadratica
        {
            static void Main(string[] args)
            {

                double a, b, c, dis, x1;
                double x2;
                Console.WriteLine("Ecuación cudrática para resolver la ecuación 2X^2+9b+10=0:");
                Console.WriteLine("Ingresa los valores 2, 9 y 10 para las variables a, b y c respectivamente:");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                dis = b * b - 4 * a * c;
         
                 if (a != 0)
                 {
                    x1 = (-b + Math.Sqrt(dis)) / 2 / a;
                    x2 = (-b - Math.Sqrt(dis)) / 2 / a;

                    Console.WriteLine("Los resultados son");
                    Console.WriteLine("Valor de x1: " + x1);
                    Console.WriteLine("Valor de x2: " + x2);
                    Console.WriteLine();
                 }

            }
        }
    }
}