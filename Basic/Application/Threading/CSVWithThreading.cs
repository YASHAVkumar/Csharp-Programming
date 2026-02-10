namespace Basic.Application.Threading;
public class SharedData
{
    public static object lockObject = new();
    public static string FilePath = "data.csv";
    public static int chunkSize = 100; // Number of lines to read/write at a time
    public static int MaxConcurrentThread = 3; // Maximum number of concurrent threads
    public static Mutex mutex = new(); // Mutex to control access to shared resources no longer need of lockObject

    public static CountdownEvent countdownEvent; // CountdownEvent to wait for all threads to complete
}


public class CSVWithThreading
{
  public string ChunkName { get; set; }
  public List<string> Data { get; set; }
  public Dictionary<string, int> GenderCount =[];
   public void DataProcessing()
    {
        foreach (var line in Data)
        {
            if(string.IsNullOrWhiteSpace(line) || line.StartsWith("Id")) continue; // Skip empty lines and header
            var columns = line.Split(',');
            if(columns.Length>=5)
            {  
                string gender = columns[4].Trim().ToLower();
                if(GenderCount.ContainsKey(gender))
                {
                    GenderCount[gender]++;
                }
                else
                {
                    GenderCount[gender] = 1;
                }
            }

          Random rnd = new();
          Thread.Sleep(100*rnd.Next(2, 5)); // Simulate processing time

        }

    }
}