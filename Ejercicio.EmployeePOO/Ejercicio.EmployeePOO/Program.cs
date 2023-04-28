using System;

namespace Ejercicio.EmployeePOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Id;
            string FirstName, LastName, IsActive;
            DateTime BirthDate, HiringDate;
            decimal Salary;
           
            //Instancio la clase 
            SalaryEmployee salaryEmployee = new SalaryEmployee();
            CommissionEmplyee commissionEmplyee = new CommissionEmplyee();
            HourlyEmployee hourlyEmployee = new HourlyEmployee();

            Console.WriteLine("Ingrese ID:");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Nombres:");
            FirstName = Console.ReadLine();

            Console.WriteLine("Ingrese Apellidos:");
            LastName = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de cumpleaños:");
            BirthDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese fecha de contratación:");
            HiringDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("¿El empleado esta activo?:");
            IsActive = Console.ReadLine();

            Console.WriteLine("Salario del empleado:");
            Salary = Convert.ToDecimal(Console.ReadLine());

            salaryEmployee.Id= Id;
            salaryEmployee.FirstName= FirstName;
            salaryEmployee.LastName= LastName;
            salaryEmployee.BirthDate= BirthDate;
            salaryEmployee.HiringDate= HiringDate;
            salaryEmployee.IsActive= IsActive;
            salaryEmployee.Salary = Salary;

            Console.Clear();
            salaryEmployee.ShowEmployeeInformation();
        }
    }
}
