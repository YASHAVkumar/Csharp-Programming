public class CounterUpTask
{
   public void CounterMethodUp(CancellationToken token)
    { 
        Console.WriteLine("Counter up start");
        for(int i=0;i<100;i++)
          {
            token.ThrowIfCancellationRequested();

            Console.WriteLine($"print i: {i}"); 
            Task.Delay(200).Wait();
          }        
        Console.WriteLine("Counter up end");
    }
}

public class CounterDownTask
{
   public void CounterMethodDown()
    {
        Console.WriteLine("Counter down start");
        for(int j=100;j>0;j--)
          Console.WriteLine($"print j: {j}");         
        Console.WriteLine("Counter down end");
    }
}