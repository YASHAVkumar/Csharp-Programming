namespace Basic.Application.Threading;
class NumberCounter
{
    //public int Count { get; private set; }

    public void Increment(object? count)
    {
        try{
        Console.WriteLine("Starting incrementing...");
        Thread.Sleep(1000);
        int initialCount = count is int c ? c : 0;
        for (int i = 0; i <= initialCount; i++)
        {
            //Count++;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Thread {Thread.CurrentThread.ManagedThreadId} - Count increment: {i}");
            Thread.Sleep(1000);
        }
        Thread.Sleep(1000);
        Console.WriteLine("Finished incrementing...");
        }
        catch (ThreadInterruptedException ex)
        {
            Console.WriteLine($"Thread was interrupted: {ex.Message}");
        }
    }

    public void Decrement(int count)
    {
        Console.WriteLine("Starting decrementing...");
        Thread.Sleep(1000);
        for (int i = count; i > 0; i--)
        {
            //Count--;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"Thread {Thread.CurrentThread.ManagedThreadId} - Count decrement: {i}");
        
            Thread.Sleep(1000);
        }
        Thread.Sleep(1000);
        Console.WriteLine("Finished decrementing...");
    }
}


class DesiredSum
{
    public void CalculateSumOfN(Action<long> callback,int count)
    {
        long sum = 0;
        Console.WriteLine($"Starting calculating sum... of N,By Thread: {Thread.CurrentThread.Name}");
        try
        {
            for (int i = 0; i <= count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                sum += i;
                //Thread.Sleep(500);
                //Console.Write($"Thread {Thread.CurrentThread.ThreadState} - Current Sum: {sum}");
            }
        }
        catch (ThreadInterruptedException ex)
        {
            Console.WriteLine($"Thread was interrupted: {ex.Message}");
        }
        finally
        {
            callback(sum);
            Console.WriteLine("Finished calculating sum...");
        }
    }

    public void PrintSum(long sumn, int count)
    {
        Console.WriteLine($"The calculated sum is: {sumn} of N: {count}");
    }
}