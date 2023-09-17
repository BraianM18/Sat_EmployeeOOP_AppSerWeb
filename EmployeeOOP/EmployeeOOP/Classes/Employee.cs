using System.Runtime.CompilerServices;

namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; } //123
        public string? FirstName { get; set; } // Nombre completos
        public string? LastName { get; set; } // Apellidos 
        public Date? BirthDate { get; set; } // 15/05/2000
        public Date? HiringDate { get; set; } // 14/09/2023
        public bool? IsActive { get; set; } // true
        #endregion

        #region Methods

        public Employee()
        {
            
        }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"INFORMACIÓN EMPLEADO \n\t " +
                $"ID: {Id}\n\t" +
                $"Nombres: {FirstName}\n\t" +
                $"Apellidos: {LastName}\n\t" +
                $"Fecha de Cumpleaños: {BirthDate}\n\t" +
                $"Fecha de Contratación: {HiringDate}\n\t" +
                $"¿Empleado activo?: {IsActive}\n\t";
        }

        #endregion
    }
}
