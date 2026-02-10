namespace Basic.Application.Employee;
using Domain.Model;
public class Employee:IEmployee
{
    public void DisplayEmployee(Emp emp)
    {
        Console.WriteLine($"Displaying Employee Information for {emp.Name} with ID {emp.Id}");
    }

    public decimal CalculateSalary(Emp emp, ref decimal totalCompensation)
    {
        // For demonstration, let's assume a fixed salary
        totalCompensation += emp.Salary*0.5M;
        return emp.Salary*0.5M;
    }
    public decimal CalculateBonus(Emp emp , ref decimal totalCompensation)
    {
        // For demonstration, let's assume a fixed bonus
        totalCompensation += emp.Salary * 0.1M;
        return emp.Salary * 0.1M;
    }
}
