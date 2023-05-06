using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.EmployeePOO
{
    public class CommissionEmplyee : Employee
    {
        public double CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        public decimal GetValueToPay()
        {
            return Sales * ((decimal) CommissionPercentage/100);
        }

        public void ShowEmployeeInformation()
        {
            Console.WriteLine(String.Format("Datos empleado por comisión\n" +
             "Id: {0}\n" +
             "Nombre: {1}\n" +
             "Apellido: {2}\n" +
             "Fechas de nacimiento: {3}\n" +
             "Fecha de contratación: {4}\n" +
             "¿Está activo?: {5}\n" +
             "Ventas: {6:C2}\n" +
             "Porcentaje de venta: {7:P2}\n" +
             "Ingresos: {8:C2}\n" + Id, FirstName, LastName, BirthDate, HiringDate, IsActive, Sales, CommissionPercentage/100, GetValueToPay()));
        }
    }

 
}
