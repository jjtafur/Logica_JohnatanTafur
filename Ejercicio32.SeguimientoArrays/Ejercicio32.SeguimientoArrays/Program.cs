using System;

namespace Ejercicio32.SeguimientoArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] numeros = LeerNumeros(N);

            int minimo = Numminimo(numeros);
            int maximo = Nummaximo(numeros);

            Console.WriteLine($"El número mínimo es: {minimo}");
            Console.WriteLine($"El número mínimo es: {maximo}");

            Console.ReadLine();
        }

        static int[] LeerNumeros (int N)
        
        {
            int[] numeros = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }

            return numeros;
        }

        static int Numminimo(int[] numeros)

        {
            int minimo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < minimo) minimo= numeros[i];
            }
            return minimo;
        }

        static int Nummaximo(int [] numeros)

        {
            int maximo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo) maximo = numeros[i];
            }
            return maximo;
        }
    }
}
