using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.EmployeePOO
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HiringDate { get; set; }
        public string IsActive { get; set; }

    }
}