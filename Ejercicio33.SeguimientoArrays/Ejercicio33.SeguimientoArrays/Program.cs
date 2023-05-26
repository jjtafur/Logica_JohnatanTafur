using System;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace Ejercicio33.SeguimientoArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];

            Console.WriteLine("Ingrese los numeros del vector 1");
            LeerVector(vector1);

            Console.WriteLine("Ingrese los numeros del vector 2");
            LeerVector(vector2);

            CalcularSuma(vector1, vector2, vector3);

            Console.WriteLine("El vector 3 es:"); MostrarVector(vector3);
            Console.ReadLine();

        }

        static void LeerVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese la cifra {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        static void CalcularSuma(int[] vector1, int[] vector2, int[] vector3)
        {

            for (int i = 0; i < vector1.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
        }

        static void MostrarVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.WriteLine();
        }
    }
}
