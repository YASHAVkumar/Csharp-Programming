namespace Basic.Application.Threading.ProducerConsumerUsingMonitor;

class Shared
{
    public static object LockObject = new object();
    public static ManualResetEvent ProducerEvent = new(true);
    public static ManualResetEvent ConsumerEvent = new(false);
    public static Queue<int> Buffer = new Queue<int>();
    public static int BufferSize = 5;
    public static bool IsProducing = true; // Flag to indicate if the producer is still producing items
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
    public void Produce()
    {
        Console.WriteLine("Producer is starting to produce items...");
        for (int i = 1; i <= 10; i++)
        {
            lock (Shared.LockObject)
            {
                if (Shared.Buffer.Count == Shared.BufferSize)
                {
                    Console.WriteLine("Buffer is full. Producer is waiting for items to be consumed...");
                    Monitor.Wait(Shared.LockObject); // Wait until the consumer consumes an item
                }
            }

            Console.WriteLine("Producer is trying to produce an item...");
            Thread.Sleep(7000); // Simulate time taken to produce an item

            lock (Shared.LockObject)
            {
                if (Shared.Buffer.Count < Shared.BufferSize)
                {
                    Shared.Buffer.Enqueue(i);
                    Console.WriteLine($"Producer produced: {i}");
                    Shared.PrintBuffer();

                    Monitor.Pulse(Shared.LockObject); // Notify the consumer that an item has been produced
                }
            }
        }


        Console.WriteLine("Producer has finished producing items.");
    }
    public void ProduceWithManualResetEvent()
    {
        Console.WriteLine("Producer is starting to produce items...");

        for (int i = 1; i <= 15; i++)
        {
            // ✅ WAIT until buffer has space
            Shared.ProducerEvent.WaitOne();

            Console.WriteLine("Producer is trying to produce an item...");
            Thread.Sleep(1500); // Simulate production time

            lock (Shared.LockObject)
            {
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
        }

        Console.WriteLine("Producer has finished producing items.");
    }
}

public class Consumer
{
    public void Consume()
    {

        Console.WriteLine("Consumer is starting to consume items...");
        for (int i = 0; i < 10; i++)
        {
            lock (Shared.LockObject)
            {
                if (Shared.Buffer.Count == 0)
                {
                    Console.WriteLine("Buffer is empty. Consumer is waiting for items to be produced...");
                    Monitor.Wait(Shared.LockObject); // Wait until the producer produces an item
                }
            }

            Console.WriteLine("Consumer is trying to consume an item...");
            Thread.Sleep(1500); // Simulate time taken to consume an item

            lock (Shared.LockObject)
            {
                if (Shared.Buffer.Count > 0)
                {
                    int val = Shared.Buffer.Dequeue();
                    Console.WriteLine($"Consumer consumed: {val}");

                    Monitor.Pulse(Shared.LockObject); // Notify the producer that an item has been consumed
                }
            }
        }
        Console.WriteLine("Consumer has finished consuming all items.");

    }
    public void ConsumeWithManualResetEvent()
    {
        Console.WriteLine("Consumer is starting to consume items...");

        for (int i = 0; i < 15; i++)
        {
            // ✅ WAIT until buffer has data
            Shared.ConsumerEvent.WaitOne();

            Console.WriteLine("Consumer is trying to consume an item...");
            Thread.Sleep(1000); // Simulate consumption time

            lock (Shared.LockObject)
            {
                int val = Shared.Buffer.Dequeue();
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
        }

        Console.WriteLine("Consumer has finished consuming all items.");
    }

}