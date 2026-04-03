using System;
namespace CompositeDesignPattern
{
    // The Leaf class represents the end objects. 
    // A leaf can't have any children.
    // The Leaf object is the Object which does the actual work
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"\tComponent Name: {Name} and Price: {Price}");
        }
    }

}