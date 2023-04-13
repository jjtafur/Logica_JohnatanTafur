using Microsoft.VisualBasic;
using System;

namespace Ejercicio24.Seguimiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            int days, months, years, numberdays;
            string back;
            Console.WriteLine("Ingrese número de días");
            days = Convert.ToInt32(Console.ReadLine());

            calculates(days, out years, out months, out numberdays);
            showresult(days, years, months, numberdays);

            Console.WriteLine("Presione Y para ingresar otro número ó N para salir");
            back = Console.ReadLine();

            if (back.ToUpper() != "S")
            {
          
            }
        }

        static void calculates(int days, out int years, out int months, out int numberdays)
        {
            years = days / 365;
            months = (days % 365)/30;
            numberdays = (days % 365);
        }

        static void showresult(int days, int years, int months, int numberdays)
        {
            Console.WriteLine(String.Format("El número {0} contiene Años: {1}, Meses {2} Días {3}", days, years, months, numberdays));
        }

    }
}
