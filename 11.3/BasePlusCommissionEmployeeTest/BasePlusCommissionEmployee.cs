public class BasePlusCommissionEmployee
{
    private decimal baseSalary;
    public decimal BaseSalary
    {
        get => baseSalary;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(value), value, $"{nameof(BaseSalary)} must be >= 0");

            baseSalary = value;
        }
    }

    private CommissionEmployee employee;

    
    public BasePlusCommissionEmployee(
        string firstName, string lastName, string socialSecurityNumber,
        decimal grossSales, decimal commissionRate,
        decimal baseSalary)
    {
        employee = new CommissionEmployee(
            firstName, lastName, socialSecurityNumber,
            grossSales, commissionRate);
        BaseSalary = baseSalary;
    }


    public decimal Earnings() => BaseSalary + employee.Earnings();

    public override string ToString() =>
        $"base-salaried {employee.ToString()}\n" +
        $"base salary: {baseSalary:C}";
}