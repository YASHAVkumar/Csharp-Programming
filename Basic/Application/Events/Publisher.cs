
using Basic.Domain.Model;

namespace Basic.Application.Events;
public delegate decimal SalaryDelegateType(Emp emp,ref decimal totalCompensation);
public class Publisher
{
    public SalaryDelegateType? SalaryDelegateType;
    // Event based on the delegate
    public event SalaryDelegateType? OnCalculateSalaryEvent
    {
        add { SalaryDelegateType += value; }
        remove { SalaryDelegateType -= value; }
    }

    public void RaiseCalculateSalaryEvent(Emp emp)
    {
        decimal totalCompensation = 0M;
        if (SalaryDelegateType != null)
        {
            // foreach (SalaryDelegateType del in SalaryDelegateType.GetInvocationList().Cast<SalaryDelegateType>())
            // {
            //     totalCompensation += del.Invoke(emp, ref totalCompensation);
            // }
            this.SalaryDelegateType.Invoke(emp, ref totalCompensation);
        }
        Console.WriteLine($"Total Compensation from Event (Salary + Bonus): {totalCompensation}");
    }
}