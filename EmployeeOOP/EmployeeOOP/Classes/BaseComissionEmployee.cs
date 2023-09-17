namespace EmployeeOOP.Classes
{
    public class BaseComissionEmployee : ComissionEmployee
    {
        #region Properties

        public decimal Base { get; set; }

        #endregion

        #region Methods

        public BaseComissionEmployee() 
        {
            
        }

        public override decimal GetValueToPay()
        {
            return ((ComissionPercentaje / 100) * Sales) + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Base a pagar: {Base:C2}\n\t";
        }

        #endregion
    }
}
