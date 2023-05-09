using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.EmployeePOO
{
    public class HourlyEmployee:Employee
    {
        public double Hours { get; set; }
        public decimal ValueHours { get; set; }

        public override decimal CalculateIncome()
        {
            return (decimal)Hours * ValueHours;
        }

        public void ShowEmployeeInformation()
        {
            Console.WriteLine(String.Format("Datos empleado por horas:\n" +
             "Id: {0}\n" +
             "Nombre: {1}\n" +
             "Apellido: {2}\n" +
             "Fechas de nacimiento: {3}\n" +
             "Fecha de contratación: {4}\n" +
             "¿Está activo?: {5}\n" +
             "Horas laboradas {6}\n" +
             "Valor hora: {7:C2}\n" +
             "Ingresos: {8:C2}\n", Id, FirstName, LastName, BirthDate, HiringDate, IsActive, Hours, ValueHours, CalculateIncome()));

        }
    }
 
}
