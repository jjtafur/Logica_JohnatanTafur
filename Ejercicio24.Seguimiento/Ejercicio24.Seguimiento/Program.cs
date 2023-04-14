using Microsoft.VisualBasic;
using System;

namespace Ejercicio24.Seguimiento
{
    public class Program
    {
        static void Main(string[] args)

        {
            do
            {
                int days, months, years, numberdays;
                Console.WriteLine("Ingrese número a evaluar");
                days = Convert.ToInt32(Console.ReadLine());

                calculates(days, out years, out months, out numberdays);
                showresult(days, years, months, numberdays);

                
                Console.WriteLine("Presione S para ingresar otro número ó N para salir");
                string back = Console.ReadLine();
                Console.Clear();

                if (back.ToUpper() != "S")
                {
                    break;
                }

            } while (true);
        }

        static void calculates(int days, out int years, out int months, out int numberdays)
        {
            years = days / 365;
            months = (days % 365)/30;
            numberdays = (days % 365);
        }

        static void showresult(int days, int years, int months, int numberdays)
        {
            Console.WriteLine(String.Format("El número {0} contiene\n Años: {1}\n Meses: {2}\n Días: {3}", days, years, months, numberdays));  
        }

    }
}
