using System.Runtime.CompilerServices;

public class Person
{
    private readonly string _id;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Id
    {
        get { return _id; }
        init => _id = value;
    }

    public DatetimeInfo DateInfo { get; set; } = new DatetimeInfo();

    //[ModuleInitializer]
    public static void DisplayPersonInfo()
    {
        Console.WriteLine("Person Info Displayed");
    } 

    public void Deconstruct(out string firstName,out int age, out string gender)
    {
        firstName = this.FirstName;
        age = this.Age;
        gender = this.Gender;

        //(firstName, age, gender) = (this.FirstName, this.Age, this.Gender);
    }
    public Person()
    {
        _id = Guid.NewGuid().ToString();
        FirstName = string.Empty;
        LastName = string.Empty;
        Gender = string.Empty;
    }
   
   public string GetIdofPerson()
   {
        return Id;
   }
}

public class DatetimeInfo
{
    public DateTime CurrentDateTime { get; set; } = DateTime.Now;
}

public class Program1
{
    //  [ModuleInitializer]
    // public static void Main()
    // {
    //     Console.WriteLine("Press Enter to exit...1");

    // }

}