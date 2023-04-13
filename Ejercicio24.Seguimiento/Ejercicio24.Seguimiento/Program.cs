using Microsoft.VisualBasic;
using System;

namespace Ejercicio24.Seguimiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            int days, months, years;
            string back;
            Console.WriteLine("Ingrese número de días");
            days = Convert.ToInt32(Console.ReadLine());

            calculates(days);

            Console.WriteLine("Presione Y para ingresar otro número ó N para salir");
            back = Console.ReadLine();

            if (back.ToUpper() != "S")
            {
          
            }
        }

        static void calculates(int days)
        {
            
        }
    }
}
