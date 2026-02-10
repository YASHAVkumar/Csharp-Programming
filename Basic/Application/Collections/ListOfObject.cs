using System.Collections;
using Basic.Domain.Model;

public class ListOfObject{
 public void NewMethod(List<int> numbers)
{
    var index = numbers.IndexOf(4, 3);
    Console.WriteLine($"Index of 4 is {index}");
    var ind = numbers.BinarySearch(5);
    Console.WriteLine($"Binary search of 5 is {ind}");
    numbers.OrderBy(n => n > 9);
    numbers.Reverse();
    var evenumbers =
    numbers.FindAll(n => n % 2 != 0); //find all odd
    evenumbers.ForEach(n => Console.WriteLine(n));
    numbers.AsEnumerable();

    numbers.ForEach(n => Console.WriteLine(n));
}
public void DicDemo()
{
    Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
{
    {1, "One" },
    {2, "Two" },
    {3, "Three" }
};

    Dictionary<int, String>.KeyCollection keys = keyValuePairs.Keys;
    Dictionary<int, String>.ValueCollection values = keyValuePairs.Values;
    foreach (var key in keys)
    {
        Console.WriteLine($"Key: {key}");
        if (keyValuePairs.TryGetValue(key, out string? value))
            Console.WriteLine($"Value: {value}");
    }

    SortedList<int, string> sortedList = new SortedList<int, string>()
{
    {3, "Three" },
    {1, "One" },
    {2, "Two" }
};

    foreach (var kvp in sortedList)
    {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }
}
public void HashDemo()
{
    Hashtable hashtable = new Hashtable();
    hashtable.Add(1, "One");
    hashtable.Add(2, "Two");
    hashtable.Add(3, "Three");
    hashtable.Add("four", 4);  //return object

    foreach (DictionaryEntry entry in hashtable)
    {
        Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
    }

    HashSet<string> hashSet = new HashSet<string>();
    hashSet.Add("Apple");
    hashSet.Add("Banana");
    hashSet.Add("Orange jk");
    hashSet.Add("Apple"); //duplicate, will be ignored
                          //remove items based on condition
    hashSet.RemoveWhere(fruit => fruit.Contains("jk"));
    //join two sets
    hashSet.UnionWith(new List<string> { "Grapes", "Mango" });
    //return common items
    hashSet.IntersectWith(new List<string> { "Banana", "Grapes", "Pineapple" });
    Console.WriteLine(hashSet.Contains("Grapes"));
    foreach (var item in hashSet)
    {
        Console.WriteLine(item);
    }
}

public void StackArrayQueue()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(1);
    arrayList.Add("Two");
    arrayList.Add(3.0);
    arrayList.Add(true);
    arrayList.Add(DateTime.Now);
    arrayList.Add(new Emp(2, "Jane Smith") { Salary = 2000M });
    arrayList.Clear();
    foreach (var item in arrayList)
    {
        if (item is Emp empItem)
        {
            Console.WriteLine($"Emp Item - Id: {empItem.Id}, Name: {empItem.Name}, Salary: {empItem.Salary}");
        }
        else
            Console.WriteLine($"Item: {item}, Type: {item.GetType()}");
    }

    Stack stack = new();
    stack.Push(1);
    stack.Push("Two");
    stack.Push(3.0);
    stack.Push(true);

    while (stack.Count > 0)
    {
        var U = stack.Peek();
        Console.WriteLine($"Peek Item: {U}, Type: {U.GetType()}");
        var item = stack.Pop();
        Console.WriteLine($"Popped Item: {item}, Type: {item.GetType()}");
    }
    Console.WriteLine("Stack is empty.");

    Queue<string> queue = new();
    queue.Enqueue("task one");
    queue.Enqueue("task two");
    queue.Enqueue("task three");
    queue.Enqueue("task five");
    queue.Enqueue("task four");
    while (queue.Count > 0)
    {
        var U = queue.Peek();
        Console.WriteLine($"Peek Item: {U}, Type: {U.GetType()}");

        var item = queue.Dequeue();
        Console.WriteLine($"Dequeued Item: {item}");
    }
}

}