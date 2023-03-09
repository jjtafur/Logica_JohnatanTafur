using System;

namespace Ejercicio4.SalarioBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            double salarioBase, subtotal = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese los datos del empleado #" +i);

                Console.Write("Nombre:");
                nombre = Console.ReadLine();

                Console.Write("Edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Salario Base:");
                salarioBase =Convert.ToDouble(Console.ReadLine());

                if (edad > 60)
                {
                    salarioBase = salarioBase + (salarioBase * 0.25);
                }
                else if (edad < 25)
                {
                    salarioBase = salarioBase - (salarioBase * 0.15);
                }
                Console.Clear();    
                Console.WriteLine("********************************");
                Console.WriteLine("Datos del empleado # "+i);
                Console.WriteLine("Nombre: "+nombre);
                Console.WriteLine("Edad: "+edad);
                Console.WriteLine("Salario Base: "+salarioBase);
                Console.WriteLine("********************************");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();  
                Console.Clear();
                subtotal = subtotal+salarioBase;
            }
            Console.WriteLine("El total de la nómina es: " + subtotal);
        }
    }
}
