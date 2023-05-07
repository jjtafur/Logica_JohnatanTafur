using Microsoft.VisualBasic;
using System;

namespace Ejercicio.EmployeePOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            int id;
            string firstName, lastName, isActive;
            DateTime birthDate, hiringDate;
            decimal salary, sales, valuehours;
            double comissionpercentage, hours;

            AskData(out id, out firstName, out lastName, out birthDate, out hiringDate, out isActive);

            Console.WriteLine("Salario del empleado:");
            salary = Convert.ToDecimal(Console.ReadLine());

            //Instancio las clases
            SalaryEmployee salaryEmployee = new SalaryEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                HiringDate = hiringDate,
                IsActive = isActive,
                Salary = salary,
            };

            Console.Clear();
            salaryEmployee.ShowEmployeeInformation();

            AskData(out id, out firstName, out lastName, out birthDate, out hiringDate, out isActive);
      
            Console.WriteLine("Ventas realizadas:");
            sales = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Porcentaje de ventas:");
            comissionpercentage = Convert.ToDouble(Console.ReadLine());

            CommissionEmplyee commissionEmplyee = new CommissionEmplyee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                HiringDate = hiringDate,
                IsActive = isActive,
                Sales = sales,
                CommissionPercentage = comissionpercentage,
            };

            Console.Clear();
            commissionEmplyee.ShowEmployeeInformation();


            AskData(out id, out firstName, out lastName, out birthDate, out hiringDate, out isActive);

            Console.WriteLine("Horas trabajadas:");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor de la hora:");
            valuehours = Convert.ToDecimal(Console.ReadLine());

            HourlyEmployee hourlyEmployee = new HourlyEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                HiringDate = hiringDate,
                IsActive = isActive,
                Hours = hours,
                ValueHours = valuehours,
            };

            Console.Clear();
            hourlyEmployee.ShowEmployeeInformation();

        }

        public static void AskData(out int id, out string firstName, out string lastName, out DateTime birthDate, out DateTime hiringDate, out string isActive)

        {
         Console.WriteLine("Ingrese ID:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Nombres:");
            firstName = Console.ReadLine();

            Console.WriteLine("Ingrese Apellidos:");
            lastName = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de cumpleaños:");
            birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese fecha de contratación:");
            hiringDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("¿El empleado esta activo?:");
            isActive = Console.ReadLine();
        }
    }
}
