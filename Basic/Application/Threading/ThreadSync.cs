public class ThreadSync
{
    private static readonly object _lock = new object();
    private static int _counter = 0;

    public static int Counter => _counter;
    public  void IncrementCounter()
    {
       // lock (_lock)
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} is waiting to increment the counter...");
            //Monitor.Enter(_lock); // wait for the lock to be available
            lock (_lock){
            _counter++;
            Console.WriteLine($"Counter: {_counter} in Thread: {Thread.CurrentThread.Name}");
            //Monitor.Exit(_lock); // release the lock
            }
        }
    }
    public  void DecrementCounter()
    {
        //lock (_lock)
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} is waiting to decrement the counter...");
            lock (_lock)
            {
                _counter--;
                Console.WriteLine($"Counter: {_counter} in Thread: {Thread.CurrentThread.Name}");
            }
        }
    }
}