
namespace Basic.Application.ConstructorChain;
public class EmployeeApp
{
  private string _name;
    private int _age;
    private decimal _salary;
    private DateTime _joiningDate;
    //Master constructor calling all
   public EmployeeApp(string name, int age, decimal salary, DateTime joiningDate)
    {
        _name = name;
        _age = age;
        _salary = salary;
        _joiningDate = joiningDate;

        if(_age <18 || _age >65)
        {
            this._age = 18; //default age
        }
        if(_salary <30000M)
        {
            this._salary = 30000M; //default salary
        }
    } 
    //Constructor chaining - calling master constructor
    public EmployeeApp(string name, int age):this(name, age,30000M,DateTime.Now)
    {
        Console.WriteLine("2nd Constructor called");
    } 
    //Constructor chaining - calling 2nd constructor
    public EmployeeApp(string name):this(name,50)
    {
        Console.WriteLine("3rd Constructor called");
    }

    public void DisplayEmployee()
    {
        Console.WriteLine($"Name: {_name}, Age: {_age}, Salary: {_salary}, Joining Date: {_joiningDate.ToShortDateString()}");
    }
}


public class ScoreManager
{
    private static ScoreManager _instance;
    private static readonly object _lock = new();

    public int Score { get; private set; }

    private ScoreManager()
    {
        Score = 0;
    }

    public static ScoreManager GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    Console.WriteLine("Creating new instance of ScoreManager");
                    _instance = new ScoreManager();
                }

                //_instance ??= new ScoreManager();
            }
        }
        return _instance;
    }

    public void AddScore(int points)
    {
        Score += points;
    }
    public void ResetScore()
    {
        Score = 0;
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {Score}");
    }
}