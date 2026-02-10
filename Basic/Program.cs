
// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using Basic.Application;
using Basic.Application.ArrayObj;
using Basic.Application.ConstructorChain;
using Basic.Application.Employee;
using Basic.Application.Events;
 using Basic.Application.LinQ;
using Basic.Application.PartialMethod;
using Basic.Application.StructureDemo;
using Basic.Application.Threading;

//using Basic.Application.Threading;
using Basic.Domain.Model;

Console.WriteLine("Hello, World!");
/*
Emp emp = new(1,"John Doe" );
emp.Salary = 1000M;
var employee = new Employee();

employee.DisplayEmployee(emp);
var delegatesBasic = new DelegatesBasic();
delegatesBasic.ShowEmployeeInfo(() => employee.DisplayEmployee(emp));
decimal salary = delegatesBasic.GetSalary(emp);
Console.WriteLine($"Calculated Salary: {salary}");

delegatesBasic.GetSalaryWithBonus(emp);
delegatesBasic.GetSalaryWithBonusMulti(emp);

//Console.Clear();

Publisher publisher = new();
Subscriber subscriber = new ();
publisher.OnCalculateSalaryEvent += subscriber.CalculateSalary;
publisher.OnCalculateSalaryEvent += subscriber.CalculateBonus; 
publisher.OnCalculateSalaryEvent += subscriber.CalculateStockOptions; 
publisher.OnCalculateSalaryEvent += delegate(Emp emp, ref decimal totalCompensation)  //HRA allowance
{
    // Anonymous method for additional calculation
    totalCompensation += emp.Salary * 0.3M;
    return emp.Salary * 0.3M;
};


//lambda expression
publisher.OnCalculateSalaryEvent += (Emp emp, ref decimal totalCompensation) => 
{
    // Lambda expression for additional calculation
    totalCompensation += emp.Salary * 0.1M;
    return emp.Salary * 0.1M;
};

//Inline lambda expression
publisher.OnCalculateSalaryEvent += (Emp emp, ref decimal totalCompensation) => emp.Salary * 0.9M;
emp.Salary=100M;

publisher.RaiseCalculateSalaryEvent(emp);

delegatesBasic.GetSalaryUsingFunc(emp);

delegatesBasic.GetBonusNotifictionUsingAction(emp);
delegatesBasic.IsSalaryGreaterThan(emp,500M);
subscriber.Dowork(emp,1000M);

//Console.Clear();

var multiDimenionArr = new MultiDimenionArr();
//multiDimenionArr.Demo();
//multiDimenionArr.jaggedArrayDemo();
//multiDimenionArr.higherDimensionalArrayDemo();

var arrayObj = new ArrayObj();
//arrayObj.CopyArray();
arrayObj.EmpArray();
*/

/**collections**/

List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

// numbers.Add(6); 
// numbers.Insert(0, 9);
// numbers.Remove(3);
// numbers.RemoveAt(2);
// numbers.RemoveRange(0,2);
// numbers.RemoveAll(n=> n % 2 == 0); //remove even numbers
// numbers.Clear();
ListOfObject listObj = new();

//listObj.NewMethod(numbers);
//listObj.DicDemo();
//listObj.HashDemo();
//listObj.StackArrayQueue();

// var list = new List<int> { 10, 20, 30 };

// var enumerator = AsEnumerator(list);

// while (enumerator.MoveNext())
// {
//     Console.WriteLine(enumerator.Current);
// }
//calling constructor chaining
// EmployeeApp empApp = new ("Alice", 28, 50000M, new DateTime(2020, 5, 1));
// empApp.DisplayEmployee();
// EmployeeApp empApp2 = new ("Bob", 35);
// empApp2.DisplayEmployee();
// EmployeeApp empApp3 = new ("Charlie");
// empApp3.DisplayEmployee();

// ScoreManager scoreManager = ScoreManager.GetInstance();
// scoreManager.AddScore(10);
// scoreManager.DisplayScore();
// //Console.WriteLine($"Score after first addition: {scoreManager.Score}");
// ScoreManager anotherInstance = ScoreManager.GetInstance();
// anotherInstance.AddScore(20);
// scoreManager.DisplayScore();
// anotherInstance.ResetScore();
// ScoreManager thirdInstance = ScoreManager.GetInstance();
// thirdInstance.DisplayScore();
// if(ReferenceEquals(scoreManager, anotherInstance) && ReferenceEquals(anotherInstance, thirdInstance))
// Console.WriteLine(  "Are all instances the same? " + (scoreManager == anotherInstance && anotherInstance == thirdInstance));

// var person =new{ FirstName="John", LastName="Doe", Age=30,Gender="Male"};
// var person1 =new{ FirstName="Myra", LastName="Doe", Age=40,Gender="Female"};

// var family = new
// {
//     id=1,
//     Parents=person,
//     Children=new { FirstName="Jim", LastName="Doe", Age=5 }
// };
// var family2 = new
// {
//     id=2,
//     Parents=person1,
//     Children=new { FirstName="Mri", LastName="yash", Age=5 }
// };

// var village= new[]
// {
//     family,
//     family2
// };

// village.ToList().ForEach(f=>
// {
//     Console.WriteLine($"Family Id: {f.id}");
//     Console.WriteLine($"Parent: {f.Parents.FirstName} {f.Parents.LastName}, Age: {f.Parents.Age}");
//     Console.WriteLine($"Child: {f.Children.FirstName} {f.Children.LastName}, Age: {f.Children.Age}");
// });

//Console.WriteLine($"Person: {person.FirstName} {person.LastName}, Age: {person.Age}");

// var person =new Tuple<string, string, int, string>("John", "Doe", 30, "Male");
// Console.WriteLine($"Person: {person.Item1} {person.Item2}, Age: {person.Item3}, Gender: {person.Item4}");   

// (string FirstName, string LastName, int Age, string Gender) personTuple = ("John", "Doe", 30, "Male");
// personTuple.FirstName="Jane"; //Tuple items are normally mutable
// Console.WriteLine($"Person: {personTuple.FirstName} {personTuple.LastName}, Age: {personTuple.Age}, Gender: {personTuple.Gender}");

// (string FirstName, string LastName, int Age, string Gender)  = personTuple;
// Console.WriteLine($"Deconstructed Person: {FirstName} {LastName}, Age: {Age}, Gender: {Gender}"); 
// (string FirstName, _, int Age, string Gender)  = personTuple;
// Console.WriteLine($"Person: {FirstName}, Age: {Age}, Gender: {Gender}");

//Console.Clear();

Example? linqExample = new();
//linqExample=null;

//linqExample!.Run();

Person person = new() { FirstName = "Bob", LastName = "Johnson", Age = 30, Gender = "Male",
                        DateInfo = new DatetimeInfo { CurrentDateTime = DateTime.Now.AddDays(1) } };

string result = person switch {
Person  {Age: < 30 and >= 15,Gender: "Female" }  p=> $"{p.FirstName} is Adult female",
Person {Age: < 10 and >= 2 } p=> $"{p.FirstName} is child",
Person {Age: >= 60 and not(100 or 200 )} p => $"{p.FirstName} is senior",
Person {Age: >=30 and < 60, Gender: "Male"} p => $"{p.FirstName} is Adult male",
_ => "Age not categorized" 
} ; 

//Console.WriteLine(result);
 //tuple pattern matching
 var str= (person.FirstName, person.Age,person.Gender)  switch {
    ("Alice", < 30, "Female") => "Alice is a young female",
    ("Bob", >= 30, "Male") => "Bob is an adult male",
    (_, >=60 and < 100, _) => $"{person.FirstName} is a senior citizen",
    ("Charlie",not (65 or 55), "Male") => "Charlie is a male",
    _ => "Person not categorized"
 };




 var str1= person switch {
    ("Alice", < 30, "Female") => "Alice is a young female",
    ("Bob", >= 30, "Male") => "Bob is an adult male",
    (_, >=60 and < 100, _) o => $"{o.FirstName} is a senior citizen",
    ("Charlie",not (65 or 55), "Male") => "Charlie is a male",
    _ => "Person not categorized"
 };

//Console.WriteLine(str1);

 var str2= (person.FirstName, person.Age,person.Gender, person.DateInfo.CurrentDateTime)  switch {
    ("Alice", < 30, "Female", _) => "Alice is a young female",
    ("Bob", > 30, "Male", _) => "Bob is an adult male",
    (_, >=60 and < 100, _, _) => $"{person.FirstName} is a senior citizen",
    ("Charlie",not (65 or 55), "Male", _) => "Charlie is a male",
    (_, _, _, DateTime dt) when dt.DayOfWeek == DayOfWeek.Sunday => $"{person.FirstName}'s info recorded on Sunday",
    _ => "Person not categorized"
 };
var tomorrow = DateTime.Today.AddDays(1);

string result1 = person switch
{
    Person { Age: < 30 and >= 15, Gender: "Female" } p
        => $"{p.FirstName} is Adult female",

    Person { Age: < 10 and >= 2 } p
        => $"{p.FirstName} is child",

    Person { Age: >= 60 and not (100 or 200) } p
        => $"{p.FirstName} is senior",

    Person { Age: >= 30 and < 60, Gender: "Male" } p
        when p.DateInfo?.CurrentDateTime.Date >= tomorrow
        => $"{p.FirstName} is Adult male",

    _ => "Age not categorized"
};



//Console.WriteLine(str2);

// Person person3=new(){Id="34533"};
// //person3.Id= "12345"; // This line will cause a compilation error since Id has no setter
// Console.WriteLine($"Person ID: {person3.GetIdofPerson()}");

//Structure structDemo = new(){ X = 10, Y = 20};
//structDemo.X=78; // This line will cause a compilation error since X has init-only setter

//Console.WriteLine($"Structure X: {structDemo.X}, Y: {structDemo.Y}");

// RecordStruct recordStruct = new(5, 10);
// //recordStruct.A=15; // This line will cause a compilation error since A is readonly
// recordStruct.Info="Sample Record Struct";
// Console.WriteLine($"RecordStruct A: {recordStruct.A}, B: {recordStruct.B}");

RecordStruct recordStruct = new(5, 10)
{   
    Info = "Sample Record Struct"
};
//refrence copy modifies both
RecordStruct recordStruct2 = recordStruct;
// // shlallow copy not affect original
// RecordStruct recordStruct3 = recordStruct with { Info= "Modified Record Struct 3" };
// //deep copy not affect original
// RecordStruct recordStruct4 = new (recordStruct.A, recordStruct.B)
// { Info= "Modified Record Struct 4" };

// (int a,int b)=recordStruct;
// var (x,y)= recordStruct;
// Console.WriteLine($"Deconstructed Structure X: {x}, Y: {y}");
// Console.WriteLine($"Deconstructed RecordStruct A: {a}, B: {b}");

//Console.WriteLine($"RecordStruct A: {recordStruct.A}, B: {recordStruct.B}, Info: {recordStruct.Info}");
// Console.WriteLine($"RecordStruct2 A: {recordStruct2.A}, B: {recordStruct2.B}, Info: {recordStruct2.Info}");
// Console.WriteLine($"RecordStruct3 A: {recordStruct3.A}, B: {recordStruct3.B}, Info: {recordStruct3.Info}");
// Console.WriteLine($"RecordStruct4 A: {recordStruct4.A}, B: {recordStruct4.B}, Info: {recordStruct4.Info}");


//Console.WriteLine($"{recordStruct}");

RecordStruct r=new(5);
//Console.WriteLine($"{r}");

ReadOnlyRecordStruct readOnlyRecord = new(15, 25);
// readOnlyRecord.A=20; // This line will cause a compilation error since A is
//Console.WriteLine($"ReadOnlyRecordStruct A: {readOnlyRecord.A}, B: {readOnlyRecord.B}");


// Student student = new Student();
// student.Id = 1;
// student.Name = "Initial Name";  
// student.UpdateName("Updated Name");


var getMessage = new Func<string>(() => "Hello from Func delegate!");
//Console.WriteLine(getMessage());

//action delegate
var displayMessage = new Action<string>(msg => Console.WriteLine(msg));

Func<int,object> getSquare = object(num) =>
{
    if(num < 0)
        throw new ArgumentException("Number must be non-negative");
    if(num == 0)
        return "Zero has no square";
    return num * num;
}; 


//Console.WriteLine(getMessage());
int[] nums = [1, 2, 3, 4, 5];
Index index = ^2;
//Console.WriteLine($"{nums[index]}"); // using index operator
//Console.WriteLine($"{nums[^1]}");// using index from end operator
// Equal to nums[nums.Length -1]


Range range = 1..4; // from index 1 to index 3
int[] subArray = nums[range]; // using range operator   
//Console.WriteLine("SubArray: " + string.Join(", ", subArray));

// Range opreator in list
List<string> fruits = ["Apple", "Banana", "Cherry", "Date", "Elderberry"];
Range fruitRange = 1..4; // from index 1 to index 3
List<string> subList = fruits[fruitRange]; // using range operator
//Console.WriteLine("SubList: " + string.Join(", ", subList));


/* Threading and async programming */
Thread mainThread = Thread.CurrentThread;
mainThread.Name = "Main Thread";

// write all properties of the main thread
 Console.WriteLine($"Main Thread ID: {mainThread.Name}");
// Console.WriteLine($"Main Thread IsBackground: {mainThread.IsBackground}");
// Console.WriteLine($"Main Thread Priority: {mainThread.Priority}");
// Console.WriteLine($"Main Thread ThreadState: {mainThread.ThreadState}");
NumberCounter counter = new();
// Thread incrementThread = new(counter.Increment)
// {
//     Name = "Increment Thread",
//     Priority=ThreadPriority.AboveNormal
// };

// incrementThread.Start();
// Console.WriteLine($"Main Thread ID: {incrementThread.Name} is doing other work...");

Thread decrementThread = new(()=>counter.Decrement(100))
{
    Name = "Decrement Thread",
    Priority=ThreadPriority.BelowNormal
};
//decrementThread.Start();
//Console.WriteLine($"Main Thread ID: {decrementThread.Name} is doing other work...");

// Wait for both threads to finish
// incrementThread.Join();

// decrementThread.Join();
// Console.WriteLine("Both threads have completed their work.");


//Interrupting a thread
// Thread.Sleep(2000); // Main thread sleeps for 5 seconds
// if (incrementThread.IsAlive)
// {
//     Console.WriteLine("Interrupting Increment Thread...");
//     incrementThread.Interrupt();
// }


ParameterizedThreadStart parameterizedThreadStart = new(counter.Increment);

Thread incrementThread = new(parameterizedThreadStart)
{
    Name = "Increment Thread",
    Priority=ThreadPriority.AboveNormal
};

//incrementThread.Start(1000); // Pass initial count as parameter
//Console.WriteLine($"Main Thread ID: {incrementThread.Name} is doing other work...");

// DesiredSum desiredSum = new();
// long gSum = 0;
// int count = 100;
// Action<long> callback = sum => {Console.WriteLine($"Sum calculated Now invoking print thread"); gSum = sum; };
// ThreadStart calculateSumThreadStart = new(() => desiredSum.CalculateSumOfN(callback, count));
// Thread calculateSumThread = new(calculateSumThreadStart)
// {
//     Name = "Calculate Sum Thread",
//     Priority = ThreadPriority.AboveNormal
// };

// calculateSumThread.Start();

// ThreadStart printSumThreadStart = new(()=>desiredSum.PrintSum(gSum, count));
// Thread printSumThread = new(printSumThreadStart)
// {
//     Name = "Print Sum Thread",
//     Priority = ThreadPriority.BelowNormal
// };
// calculateSumThread.Join(); // Wait for the sum calculation thread to finish
// Console.WriteLine($"Main Thread ID: {calculateSumThread.Name} has finished calculating sum. Now starting print thread...");
// printSumThread.Start(); // Start the print thread after calculation is done
// printSumThread.Join(); // Wait for the print thread to finish
// Console.WriteLine($"Main Thread ID: {calculateSumThread.Name} is doing other work...{calculateSumThread.ThreadState}");


ThreadSync threadSync = new();
ThreadStart incrementThreadStart = new(threadSync.IncrementCounter);
Thread incrementThread1 = new(incrementThreadStart)
{
    Name = "Increment Thread 1",
    //Priority = ThreadPriority.AboveNormal
};

ThreadStart decrementThreadStart = new(threadSync.DecrementCounter);
Thread decrementThread1 = new(decrementThreadStart)
{
    Name = "Decrement Thread 1",
    //Priority = ThreadPriority.BelowNormal
};

// Start both threads
//  incrementThread1.Start();
//  decrementThread1.Start();

// incrementThread1.Join();
// decrementThread1.Join();



// Console.WriteLine($"Main Thread ID: {incrementThread1.Name} and {decrementThread1.Name} are doing other work...");
// Console.WriteLine($"Counter value after both threads completed: {ThreadSync.Counter}");



//Producer and Consumer
Producer producer = new();
Consumer consumer = new();
ThreadStart producerThreadStart = new(producer.ProduceWithAutoReset);
Thread producerThread = new(producerThreadStart)
{
  Name="Producer Thread",  
};

ThreadStart consumerThreadStart = new(consumer.ConsumeWithAutoReset);
Thread consumerThread = new(consumerThreadStart)
{
    Name="Consumer Thread",
};

// Start both threads
//  producerThread.Start();
// consumerThread.Start();

// producerThread.Join();
// consumerThread.Join();

Basic.Application.Threading.ConcurrentCollection.Producer producerMonitor = new();
Thread threadProducerMonitor = new(producerMonitor.ProduceWithManualResetEvent)
{
    Name="Producer Monitor Thread"
};


Basic.Application.Threading.ConcurrentCollection.Consumer consumerMonitor = new();
Thread threadConsumerMonitor = new(consumerMonitor.ConsumeWithManualResetEvent)
{
    Name="Consumer Monitor Thread"
};

// threadProducerMonitor.Start();
// threadConsumerMonitor.Start();

// threadProducerMonitor.Join();
// threadConsumerMonitor.Join();
// Console.WriteLine($"Main Thread ID: {threadProducerMonitor.Name} and {threadConsumerMonitor.Name} have completed their work...");


// CSV with threading
#region CSV with threading
string csv =
    "id,first_name,last_name,email,gender\n" +
    string.Join("\n",
        Enumerable.Range(1, 1001).Select(i =>
            $"{i},First{i},Last{i},user{i}@example.com,{(i % 2 == 0 ? "Female" : "Male")}"
        )
    );


 File.WriteAllText(SharedData.FilePath, csv); // Initialize CSV file with headers
#endregion

//Read data from CSV file
using(StreamReader reader = new(SharedData.FilePath))
{
    string headerLine = reader.ReadLine()??""; // Read header line
    string? line;
    int lineNumber = 0;

    //Create a chunk
    List<string> chunk = new();
    
    //create collection of threads to process chunks
    List<Thread> processingThreads = new();
    int ThreadCount = 0;

    // Create semaphore to limit the number of concurrent threads
    SemaphoreSlim semaphore = new(SharedData.MaxConcurrentThread, SharedData.MaxConcurrentThread);

    while ((line = reader.ReadLine()) != null)
    {
        if(string.IsNullOrWhiteSpace(line))
            continue;

        // Process each line of CSV data
        //Console.WriteLine(line);
        chunk.Add(line);
        lineNumber++;

        // If chunk size is reached, process the chunk in a separate thread
        if(lineNumber % SharedData.chunkSize == 0)
        {
            List<string> chunkToProcess = new(chunk); // Create a copy of the chunk for processing
            string chunkName = $"Chunk {ThreadCount + 1}"; // Name for the chunk being processed
            ThreadPool.QueueUserWorkItem((object? state) =>
            //Thread processingThread = new(() =>
            {
                // Wait for the semaphore to allow processing
                semaphore.Wait();
                try
                {
                    InvokeDataProcessingWithMutex(chunkToProcess, state?.ToString()??"Unknown Chunk");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error processing {chunkName}: {ex.Message}");
                }
                finally
                {
                    semaphore.Release(); // Release the semaphore when processing is complete
                }
            
            },chunkName);

            ThreadCount++;

            // processingThread.Name = $"Processing Thread {ThreadCount}";
            // processingThreads.Add(processingThread);
            // processingThread.Start();
            
            chunk.Clear(); // Clear the chunk for the next set of lines
         }
    }

    //process any remaining lines in the last chunk
    if(chunk.Count > 0)
    {  
        ThreadCount++;
        string chunkName = $"Chunk {ThreadCount}"; // Name for the last chunk being processed
        Thread processingThread = new(() =>
        { // Wait for the semaphore to allow processing
                semaphore.Wait();
                try
                {
                InvokeDataProcessing(chunk, chunkName);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error processing {chunkName}: {ex.Message}");
                }
                finally
                {
                    semaphore.Release(); // Release the semaphore when processing is complete
                }
        });
        processingThread.Name = $"Processing Thread {ThreadCount + 1}";
        processingThreads.Add(processingThread);
        processingThread.Start();
    }

    SharedData.countdownEvent = new CountdownEvent(ThreadCount - 1); // Initialize CountdownEvent with the number of processing threads //10
                                                                     //initialize CountdownEvent with the number of processing threads                                                                   //current count of processing threads is ThreadCount-1 because the last chunk is being processed in the main thread and not added to the processingThreads list
    SharedData.countdownEvent.Wait(); // Wait for all processing threads to complete

    foreach (var thread in processingThreads)
    {
        thread.Join();
    }
}

Console.WriteLine("All chunks have been processed. from csv file");
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();

static void InvokeDataProcessing(List<string> chunk, string chunkName)
{
   
    Console.WriteLine($"{chunkName} is being processing by {Thread.CurrentThread.Name}...");
   CSVWithThreading csvProcessor = new() { ChunkName = chunkName, Data = chunk };
   csvProcessor.DataProcessing();
   
   // Display
   lock(SharedData.lockObject){
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"{chunkName} processed of size {chunk.Count} by {Thread.CurrentThread.Name}");
    
    foreach(var kvp in csvProcessor.GenderCount)
    {
        Console.WriteLine($"{chunkName} - {kvp.Key}: {kvp.Value}");
    }

   }  
}

static void InvokeDataProcessingWithMutex(List<string> chunk, string chunkName)
{
   
    Console.WriteLine($"{chunkName} is being processing by {Thread.CurrentThread.Name}...");
   CSVWithThreading csvProcessor = new() { ChunkName = chunkName, Data = chunk };
   csvProcessor.DataProcessing();

    // Display
    try{
    SharedData.mutex.WaitOne(); // Acquire the mutex before accessing shared resources 
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"{chunkName} processed of size {chunk.Count} by {Thread.CurrentThread.Name}");

        foreach (var kvp in csvProcessor.GenderCount)
        {
            Console.WriteLine($"{chunkName} - {kvp.Key}: {kvp.Value}");
        }

    }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Error in {chunkName} while acquiring mutex: {ex.Message}");
    }
    finally
    {
       if(SharedData.countdownEvent.CurrentCount > 0)
        SharedData.countdownEvent.Signal(); // Signal that this thread has completed processing
       else 
         SharedData.countdownEvent.Reset(); // Reset the CountdownEvent if the count has already reached zero to avoid exceptions in case of extra signals
         
           //decrement the count of the CountdownEvent to indicate that this thread has completed processing
        SharedData.mutex.ReleaseMutex(); // Release the mutex after accessing shared resources
    }
}


// static IEnumerator<int> AsEnumerator(List<int> list)
// {
//     for (int i = 0; i < list.Count; i++)
//     {
//         yield return list[i];
//     }
// }

  