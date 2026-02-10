using Basic.Application;
using Basic.Domain.Model;

public class Subscriber
{
    public decimal CalculateSalary(Emp emp, ref decimal totalCompensation)
    {
        // For demonstration, let's assume a fixed salary
        totalCompensation += emp.Salary * 3.5M;
        return emp.Salary * 3.5M;
    }
    public decimal CalculateBonus(Emp emp, ref decimal totalCompensation)
    {
        // For demonstration, let's assume a fixed bonus
        totalCompensation += emp.Salary * 0.5M;
        return emp.Salary * 0.5M;
    }
    public decimal CalculateStockOptions(Emp emp, ref decimal totalCompensation)
    {
        // For demonstration, let's assume a fixed stock options value
        totalCompensation += emp.Salary * 0.2M;
        return emp.Salary * 0.2M;
    }
    public void Dowork(Emp emp, decimal totalCompensation)
    {
        DelegatesBasic delegatesBasic = new();
        delegatesBasic.SalaryCalculated += (sender, e) =>
        {
            Console.WriteLine($"Event Received: Salary calculated for {e.Employee.Name}, Total Compensation: {e.TotalCompensation}");
        };
        delegatesBasic.OnSalaryCalculated(this, emp, totalCompensation);
    }
}