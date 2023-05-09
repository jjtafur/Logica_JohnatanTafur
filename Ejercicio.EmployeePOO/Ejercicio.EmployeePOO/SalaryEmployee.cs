using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.EmployeePOO
{
    public class SalaryEmployee : Employee //Aquí se genera la herencia, desde padre Employee a hija SalaryEmployee
    {
     public decimal Salary { get; set; }
     
     public override decimal CalculateIncome()
        {
            return Salary;
        }
     public void ShowEmployeeInformation()
        {
            Console.WriteLine(String.Format("Datos empleado asalariado:\n" +
                "Id: {0}\n" +
                "Nombre: {1}\n" +
                "Apellido: {2}\n" +
                "Fechas de nacimiento: {3}\n" +
                "Fecha de contratación: {4}\n" +
                "¿Está activo?: {5}\n" +
                "Salario: {6:C2}\n", Id, FirstName, LastName, BirthDate, HiringDate, IsActive, Salary));
        }
    }
}
