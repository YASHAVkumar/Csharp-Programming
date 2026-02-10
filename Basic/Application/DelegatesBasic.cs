using Basic.Domain.Model;
using Employees=Basic.Application.Employee;

namespace Basic.Application;

public delegate void EmployeeDelegate();
public delegate decimal SalaryDelegate(Emp emp,ref decimal totalCompensation);
public delegate decimal SalaryDelegateMulti(Emp emp,ref decimal totalCompensation);


public class DelegatesBasic
{
    public void ShowEmployeeInfo(EmployeeDelegate employeeDelegate)
    {
        employeeDelegate();
       
    }
    public decimal GetSalary(Emp emp)
    {  decimal totalCompensation = 0M;
        SalaryDelegate salaryDelegate = new(new Employees.Employee().CalculateSalary);
        return salaryDelegate.Invoke(emp, ref totalCompensation);
    }

    public void GetSalaryWithBonus(Emp emp)
    {  
        decimal totalCompensation = 0M;
        SalaryDelegate salaryDelegate = new(new Employees.Employee().CalculateSalary);
        SalaryDelegate bonusDelegate = new(new Employees.Employee().CalculateBonus);
         totalCompensation = salaryDelegate.Invoke(emp, ref totalCompensation) + bonusDelegate.Invoke(emp, ref totalCompensation );
        Console.WriteLine($"Total Compensation (Salary + Bonus): {totalCompensation}");
    }

    public void GetSalaryWithBonusMulti(Emp emp)
    {
        decimal totalCompensation = 0M;
        SalaryDelegateMulti salaryDelegate = new(new Employees.Employee().CalculateSalary);       
        salaryDelegate += new Employees.Employee().CalculateBonus;
         salaryDelegate.Invoke(emp,ref totalCompensation);
        Console.WriteLine($"Using Multicast Delegate: {salaryDelegate.GetInvocationList().Length} methods invoked.");
        Console.WriteLine($"Total Compensation (Salary + Bonus): {totalCompensation}");
    }

    // Func type delegate example
    public decimal GetSalaryUsingFunc(Emp emp)
    {
        decimal totalCompensation = 0M;
        Func<Emp, decimal> salaryFunc = e => e.Salary * 6.0M; // Example calculation
        decimal salary = salaryFunc(emp);
        totalCompensation += salary;
        Console.WriteLine($"Total Compensation using Func Delegate: {totalCompensation}");
        return totalCompensation;
    }
    
    public void GetBonusNotifictionUsingAction(Emp emp)
    {
        decimal totalCompensation = 0M;
        Action<Emp> bonusFunc = (e) => totalCompensation = e.Salary * 0.2M; // Example calculation
        bonusFunc.Invoke(emp);
        Console.WriteLine($"Total Bonus Added in Every year: {totalCompensation}");
        
    }

    //predicate type delegate example
    public bool IsSalaryGreaterThan(Emp emp, decimal threshold)
    {
        Predicate<decimal> isGreaterThan = salary => salary > threshold;
        return isGreaterThan(emp.Salary);
    }

    public event EventHandler<CustomEventArgs>? SalaryCalculated;

    public void OnSalaryCalculated(object sender,Emp emp, decimal totalCompensation)
    {
        CustomEventArgs args = new(emp, totalCompensation);
         this.SalaryCalculated?.Invoke(sender, args);

        //SalaryCalculated?.Invoke(this, new CustomEventArgs(emp, totalCompensation));
    }


}



public class CustomEventArgs(Emp emp, decimal totalCompensation) : EventArgs
{
    public Emp Employee { get; set; } = emp;
    public decimal TotalCompensation { get; set; } = totalCompensation;
}