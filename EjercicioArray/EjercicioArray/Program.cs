using System;

namespace EjercicioArray
{
    //Realizar un algoritmo que solicite a un docente de clase ingresar las
    //notas de los parciales de sus 5 estudiantes, que pueden ser valores
    //enteros o con decimales. Adicional sacar el promedio general de las 5 notas
    //y mostrar tanto las notas como el promedio en pantalla.
    internal class Program
    {
        static double[] notes;
        static double sum;
        static double avg;

        static void Main(string[] args)
        {
            AskData();
            CalculateAverage();
            ShowResults();
        }

        static void AskData()
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            int count = Convert.ToInt32(Console.ReadLine());

            notes = new double[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Por favor, ingrese la nota del estudiante {i + 1}:");
                notes[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        static void CalculateAverage()
        {
            sum = 0;

            for (int i = 0; i < notes.Length; i++)
            {
                sum += notes[i];
            }

            avg = sum / notes.Length;
        }

        static void ShowResults()
        {
            Console.Clear();
            Console.WriteLine("NOTAS DE LOS ESTUDIANTES");

            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}: Nota {notes[i]}");
            }

            Console.WriteLine($"\nEl promedio general del grupo es de {avg}");
        }
    }
}