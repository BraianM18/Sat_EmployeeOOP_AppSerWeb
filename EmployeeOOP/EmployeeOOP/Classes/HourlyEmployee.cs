namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public int Hours { get; set; }

        public decimal HourValue { get; set; }

        public decimal SalaryE { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee() { }

        public override decimal GetValueToPay()
        {
            SalaryE = Hours * HourValue;

            return SalaryE;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario a Pagar: {SalaryE:C}\n\t";
        }

        #endregion
    }
}
