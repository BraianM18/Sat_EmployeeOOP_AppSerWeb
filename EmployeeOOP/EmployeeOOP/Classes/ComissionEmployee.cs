namespace EmployeeOOP.Classes
{
    public class ComissionEmployee : Employee
    {
        #region Properties

        public decimal ComissionPercentaje { get; set; }

        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public ComissionEmployee() 
        {
        
        }

        public override decimal GetValueToPay()
        {
            return (ComissionPercentaje / 100) * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Valor a Pagar Comision: {(ComissionPercentaje / 100) * Sales:C}\n\t";
        }

        #endregion
    }
}
