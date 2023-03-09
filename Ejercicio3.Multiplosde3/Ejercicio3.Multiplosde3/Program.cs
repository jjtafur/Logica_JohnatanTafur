using System;

namespace Ejercicio3.Multiplosde3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Realice un algoritmo en C# que me pida por pantalla N números,validar y mostrar únicamente los números que sean múltiplos de 3.
            //Además, el programa debe estar diseñado para que el usuario pueda volver al inicio e ingrese nuevamente N números o digitar
            //un 0 para finalizar el programa.

            int n;

            do
            {
                Console.WriteLine("Ingrese un número (o 0 para salir): ");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    Console.WriteLine($"Los múltiplos de 3 contenidos en {n} son:");
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 3 == 0)
                        {
                            Console.Write($"{i} ");
                        }
                    }
                    Console.WriteLine();
                }
            } while (n != 0);
        }
    }

}
