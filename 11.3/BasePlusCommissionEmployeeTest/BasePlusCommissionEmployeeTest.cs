using System;
using System.Runtime.InteropServices;

public class BasePlusCommissionEmployeeTest
{
    private static string firstName = "";
    private static string lastName = "";
    private static string socialSecurityNumber = "";
    private static decimal grossSales;
    private static decimal commissionRate;
    private static decimal baseSalary;

    private static BasePlusCommissionEmployee? employee;

    static void Main(string[] args)
    {
        firstName = Prompt("First Name: ");    
        lastName = Prompt("Last Name: ");
        socialSecurityNumber = Prompt("Social Security Number: ");

        while (!decimal.TryParse(Prompt("Gross Sales: $"), out grossSales))
            Console.WriteLine("Gross sales must be a number!");
        
        while (!decimal.TryParse(Prompt("Commission Rate: "), out commissionRate))
            Console.WriteLine("Commission rate must be a number!");

        while (!decimal.TryParse(Prompt("Base Salary: $"), out baseSalary))
            Console.WriteLine("Base salary must be a number!");

        try
        {

            employee = new BasePlusCommissionEmployee(
                firstName, lastName, socialSecurityNumber,
                grossSales, commissionRate, baseSalary);

            Console.WriteLine(employee.ToString());
            Console.WriteLine($"earnings: {employee.Earnings():C}");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

    public static string Prompt(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? "";
    }
}
