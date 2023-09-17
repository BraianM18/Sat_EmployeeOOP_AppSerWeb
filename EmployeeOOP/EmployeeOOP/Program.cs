// See https://aka.ms/new-console-template for more information

using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year, hours;
    string firstName, lastName;
    decimal salary, hourValue, comission, sales, baseValue, salarye;

    Console.WriteLine("=================");
    Console.WriteLine(" OOP Application");
    Console.WriteLine("=================\n");

    Console.WriteLine("Fecha \n");

    Console.Write("Ingresa el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresa el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresa el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicializacion de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());
    Console.WriteLine("\n");


    Console.Write("Ingresa el nombre: " );
    firstName = Console.ReadLine();

    Console.Write("Ingresa los apellidos: ");
    lastName = Console.ReadLine();

    //Salary Employee

    Console.Write("Ingresa el salario Devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
        
    };
    Console.WriteLine("\n");
    Console.WriteLine(salaryEmployee.ToString());
 
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
