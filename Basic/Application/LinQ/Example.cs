
namespace Basic.Application.LinQ
{
    public class Example
    {
        // LinQ Example methods would go here
        public void Run()
        {
            // Implementation of LinQ examples
            List<Person> people = [
            
                new Person { FirstName = "John", LastName = "Doe", Age = 30, Gender = "Male" },
                new Person { FirstName = "Jane", LastName = "Smith", Age = 25, Gender = "Female" },
                new Person { FirstName = "Sam", LastName = "Brown", Age = 40, Gender = "Male" } 
       
            ];
            // new list of people not actually valid syntax, just for illustration
            var adults = people.Where(person => person.Age >= 18 && person.Age < 30);
            var adults1 = from person in people
                         where person.Age >= 18 && person.Age < 30
                         select person;

            foreach (var adult in adults)
            {
                Console.WriteLine($"You are Young Guns {adult.FirstName} {adult.LastName}, Age: {adult.Age}, Gender: {adult.Gender}");
            }

            //Min, Max, Sum, Average
            var minAge = people.Min(p => p.Age);
            var maxAge = people.Max(p => p.Age);
            var totalAge = people.Sum(p => p.Age);
            var averageAge = people.Average(p => p.Age);
            Console.WriteLine($"Min Age: {minAge}, Max Age: {maxAge}, Total Age: {totalAge}, Average Age: {averageAge}");
        }
    }
}