namespace Basic.Domain.Model;

public class Emp(int id, string name):ICloneable
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    
    public decimal Salary { get; set; }

    public object Clone()
    {
       return new Emp(this.Id, this.Name) { Salary = this.Salary };
    }


    public Emp CreateNewEmp()
    {
       return new Emp(this.Id, this.Name) { Salary = this.Salary };
    }

   public override string ToString()
      {
         return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
      }
}
