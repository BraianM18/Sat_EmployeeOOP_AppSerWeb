// See https://aka.ms/new-console-template for more information

using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year, hours;
    string firstName, lastName;
    decimal salary, hourValue, comission, sales, baseValue;

    Console.WriteLine("OOP Application");
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

    // Class Salary Employee

    Console.Write("Ingresa el salario: ");
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

    Console.WriteLine("\n");

    // Class Hourly Employee

    Console.Write("Ingresar horas trabajadas: ");
    hours = Int32.Parse(Console.ReadLine());

    Console.Write("Ingresar valor por hora: ");
    hourValue = Decimal.Parse(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        HourValue = hourValue,
        Hours = hours,
    };

    Console.WriteLine("\n");
    Console.WriteLine(hourlyEmployee.ToString());

    Console.WriteLine("\n");

    // Class Comission Employee

    Console.Write("Ingresar porcentaje de comision: ");
    comission = Decimal.Parse(Console.ReadLine());

    Console.Write("Ingresar valor de ventas: ");
    sales = Decimal.Parse(Console.ReadLine());

    ComissionEmployee comissionEmployee = new ComissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        ComissionPercentaje = comission,
    };

    Console.WriteLine("\n");
    Console.WriteLine(comissionEmployee.ToString());

    Console.WriteLine("\n");

    // Class Base Comission Employee

    Console.Write("Ingresar pago base: ");
    baseValue = Decimal.Parse(Console.ReadLine());

    BaseComissionEmployee baseComissionEmployee = new BaseComissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        ComissionPercentaje = comission,
        Base = baseValue,
    };

    Console.WriteLine("\n");
    Console.WriteLine(baseComissionEmployee.ToString());

    Console.WriteLine("\n");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
