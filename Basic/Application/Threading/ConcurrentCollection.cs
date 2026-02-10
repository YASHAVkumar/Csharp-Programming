using System.Collections.Concurrent;

namespace Basic.Application.Threading.ConcurrentCollection;

class Shared
{

    public static ManualResetEvent ProducerEvent = new(true);
    public static ManualResetEvent ConsumerEvent = new(false);
    public static ConcurrentQueue<int> Buffer = new();
    public static int BufferSize = 5;
    public static void PrintBuffer()
    {
        Console.WriteLine("Current Buffer: ");
        foreach (var item in Buffer)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(); // New line after printing all buffer items
    }
}

public class Producer
{
    public void ProduceWithManualResetEvent()
    {
        Console.WriteLine("Producer is starting to produce items...");

        for (int i = 1; i <= 15; i++)
        {
            // ✅ WAIT until buffer has space
            Shared.ProducerEvent.WaitOne();

            Console.WriteLine("Producer is trying to produce an item...");
            Thread.Sleep(1500); // Simulate production time

                Shared.Buffer.Enqueue(i);
                Console.WriteLine($"Producer produced: {i}");
                Shared.PrintBuffer();

                // ✅ Buffer now has data → allow consumer
                Shared.ConsumerEvent.Set();

                // ✅ Buffer full → stop producer
                if (Shared.Buffer.Count == Shared.BufferSize)
                {
                    Console.WriteLine("Buffer is full. Producer is waiting...");
                    Shared.ProducerEvent.Reset();
                }   
        }

        Console.WriteLine("Producer has finished producing items.");
    }
}

public class Consumer
{
    public void ConsumeWithManualResetEvent()
    {
        Console.WriteLine("Consumer is starting to consume items...");

        for (int i = 0; i < 15; i++)
        {
            // ✅ WAIT until buffer has data
            Shared.ConsumerEvent.WaitOne();

            Console.WriteLine("Consumer is trying to consume an item...");
            Thread.Sleep(1000); // Simulate consumption time
                Shared.Buffer.TryPeek(out int val1);
                Console.WriteLine($"Consumer front: {val1}");
                Shared.Buffer.TryDequeue(out int val);
                Console.WriteLine($"Consumer consumed: {val}");

                // ✅ Buffer now has space → allow producer
                Shared.ProducerEvent.Set();

                // ✅ Buffer empty → stop consumer
                if (Shared.Buffer.Count == 0)
                {
                    Console.WriteLine("Buffer is empty. Consumer is waiting...");
                    Shared.ConsumerEvent.Reset();
                }
                
        }

        Console.WriteLine("Consumer has finished consuming all items.");
    }

}