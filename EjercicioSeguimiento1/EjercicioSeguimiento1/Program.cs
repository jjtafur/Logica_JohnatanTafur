using System;

namespace EjercicioSeguimiento1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Construya un programa en C# que solicita 5 números al usuario y haga la suma de todos ellos.
            //El algoritmo debe solicitar números siempre y cuando el número ingresado sea positivo, si el usuario
            //ingresa un número no positivo el algoritmo debe terminar e imprimir la suma de los números positivos.

            int num, i, suma = 0;
            Console.WriteLine("Suma de 5 números enteros");

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Por favor ingrese un número entero");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                {
                    suma = suma + num;
                }
                else
                {
                    i = 5;
                    Console.Write("El último numero ingresado no es entero. ");
                }               
            }
            Console.WriteLine("La suma de los números enteros ingresados es " + suma);
            Console.Write("Pulse cualquier tecla para terminar");
            Console.ReadKey();
        }
    }   
}
