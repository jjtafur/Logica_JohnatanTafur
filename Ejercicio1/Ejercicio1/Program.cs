using System;

namespace Ejercicio1.OperacionesAritmeticas
{
public class OperacionesAritmeticas
{
    static void Main(string[] args)
    {
        Console.WriteLine("Operaciones Aritméticas con 2 números");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Ingrese 2 números:");
        int num1, num2, suma, resta, mult;
        double div;


        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        suma = num1 + num2;
        resta = num1 - num2;
        mult = num1 * num2;
        div = num1 / num2;

        Console.WriteLine("El resultado de la suma es:");
        Console.WriteLine(suma);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("El resultado de la resta es:");
        Console.WriteLine(resta);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("El resultado de la multiplicación es:");
        Console.WriteLine(mult);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("El resultado de la división es:");
        Console.WriteLine(div);
    }
}
}
