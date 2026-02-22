namespace Basic.Application.TasksClass
{
    public class FileOperation
    {
        public  Task FileWriter(string fileName,string data)
        {
            StreamWriter streamWriter=new(fileName);
            Task writerTask=streamWriter.WriteLineAsync(data);
            streamWriter.Close();
            Console.WriteLine("File write task, "+writerTask.Status);
           return writerTask;
        }
        public  Task<string> FileReader(string fileName)
        {
            StreamReader streamReaders=new(fileName);
            Task<string> streamReader=streamReaders.ReadToEndAsync();     
           // Console.WriteLine("File reads task, "+streamReader.Status+" content: "+streamReader);
            //streamReaders.Close();
           return streamReader;
        }
    }
    public class FileOperationAsync
    {
        public async Task FileWriterAsync(string fileName,string data)
        {
           using StreamWriter streamWriter=new(fileName);
            await streamWriter.WriteLineAsync(data);  
            //streamWriter.Close();
            //Console.WriteLine("File write task, "+writerTask.Status);
           
           //return writerTask;
        }
        public async Task<string> FileReaderAsync(string fileName)
        {
            using StreamReader streamReaders = new(fileName);
            //     Task<string> streamReader=streamReaders.ReadToEndAsync();     
            //    // Console.WriteLine("File reads task, "+streamReader.Status+" content: "+streamReader);
            //     string result=await streamReader;  or
            string result = await streamReaders.ReadToEndAsync();
            //streamReaders.Close();
            return result;
        }
    }


}