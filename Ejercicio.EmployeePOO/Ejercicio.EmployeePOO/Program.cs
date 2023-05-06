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

            //Instancio las clases
            SalaryEmployee salaryEmployee = new SalaryEmployee();
     
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

            Console.WriteLine("Salario del empleado:");
            salary = Convert.ToDecimal(Console.ReadLine());

            salaryEmployee.Id = id;
            salaryEmployee.FirstName = firstName;
            salaryEmployee.LastName = lastName;
            salaryEmployee.BirthDate = birthDate;
            salaryEmployee.HiringDate = hiringDate;
            salaryEmployee.IsActive = isActive;
            salaryEmployee.Salary = salary;

            Console.Clear();
            salaryEmployee.ShowEmployeeInformation();

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


            Console.Clear();
            salaryEmployee.ShowEmployeeInformation();

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

            Console.WriteLine("Ventas realizadas:");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Porcentaje de ventas:");
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
    }
}
