using System.Diagnostics.CodeAnalysis;

internal class Service
{
 public required string Name { get; init; }
 
 [SetsRequiredMembers]
 public Service()
 {
    Name = "Default Service";
 }
 public void DoWork()
  {
    Service2 service2 = new Service2();
    service2.DoWork();
    Console.WriteLine("Doing work...");
  }
}

file class Service2
{
  public void DoWork()
  {
    Console.WriteLine("Doing work in Service2...");
  }
}

internal ref struct PersonStruct
{
  public ref string Name;// { get; set; }
  public ref int Age; // { get; set; }

    public PersonStruct(ref string name, ref int age)
    {
        Name = ref name;
        Age = ref age;
    }
}


class class1(class2 c2)
{
    private readonly class2 _c2= c2;
    public class1(): this(new class2())
    {
        
    }
}

class class2()
{
    
}