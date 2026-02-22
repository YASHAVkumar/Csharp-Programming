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
    
    private string _parentName;
    public partial string ParentName { 
        get=>_parentName; 
        set
         {
            Console.WriteLine("Setting ParentName");
            _parentName = value;
         } 
    }
    private string[] _subjects = ["Math", "Science", "History"];

    public partial string this[int index] 
    { 
        get
        {
            if(index < 0 || index >= _subjects.Length)
                throw new IndexOutOfRangeException();
            return _subjects[index];
        } 
    }

}
