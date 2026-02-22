namespace Basic.Application.PartialMethod;
public partial class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    internal partial string OnNameChanging(string newName); // private by default
                                                 // so no access modifier needed
                                                 //not return type needed void only
    partial void OnNameChanged();

    public void UpdateName(string newName)
    {
        OnNameChanging(newName);
        Name = newName;
        OnNameChanged();
    }
   

   public partial string ParentName{get; set;}
   public partial string this[int index] { get;}
    
}