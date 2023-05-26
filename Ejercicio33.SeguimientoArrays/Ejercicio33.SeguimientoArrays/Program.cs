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

            Console.WriteLine("Ingrese los elementos del vector 1");
            LeerVector(vector1);

            Console.WriteLine("Ingrese los elementos del vector 2");
            LeerVector(vector2);

            CalcularSuma(vector1, vector2, vector3);
        }

        static void LeerVector(int[] vector)
        {
            for (int i=0; i< vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el elemento {i+1}");
                vector[i]=Convert.ToInt32(Console.ReadLine());
            }

        }

        static void CalcularSuma(int[] vector1, int[] vector2, int[] vector3)
        {

            for (int i = 0; i < vector1.Length; i++)
            {
                vector3 = vector1 + vector2;
            }
        }

        static void MostrarVector()
        {
        
        }
    }
}
