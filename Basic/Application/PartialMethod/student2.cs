namespace Basic.Application.PartialMethod;
public partial class Student
{
    internal partial string OnNameChanging(string newName)
    {
        Console.WriteLine($"Name is changing to {newName}");
        return newName;
    }

    partial void OnNameChanged()
    {
        Console.WriteLine($"Name has been changed to {Name}");
    }
}
