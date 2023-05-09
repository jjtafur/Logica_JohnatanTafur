using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Ejercicio.EmployeePOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            int id;
            string firstName, lastName;
            bool isActive;
            DateTime birthDate, hiringDate;
            decimal salary, sales, valuehours;
            double comissionpercentage, hours;

            List<Employee> employees = new List<Employee>(); // creamos una lista para almacenar los empleados

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

            employees.Add(salaryEmployee); // agregamos el empleado a la lista

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

            employees.Add(commissionEmplyee); // agregamos el empleado a la lista

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

            employees.Add(hourlyEmployee); // agregamos el empleado a la lista

            Console.Clear();
            hourlyEmployee.ShowEmployeeInformation();

            ShowActiveEmployeesAndIncomes(employees); // llamamos al método para mostrar los empleados activos y la suma de sus ingresos

        }

        public static void AskData(out int id, out string firstName, out string lastName, out DateTime birthDate, out DateTime hiringDate, out bool isActive)

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

            Console.WriteLine("¿El empleado está activo? (true/false):");
            isActive = Convert.ToBoolean(Console.ReadLine());
        }

        public static void ShowActiveEmployeesAndIncomes(List<Employee> employees)
        {
            decimal totalIncome = 0;

            Console.WriteLine("Empleados activos y sus ingresos:");

            foreach (Employee employee in employees)
            {
                if (employee.IsActive)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.CalculateIncome()}");
                    totalIncome += employee.CalculateIncome();
                }
            }

            Console.WriteLine($"Total de ingresos: {totalIncome}");
        }
    }
}