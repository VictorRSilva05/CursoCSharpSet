namespace ConsoleApp26
{
    internal class Program
    {
        Program()
        {
            Console.Write("Enter file full path: "); //C:\Windows\Temp\online_users.txt
            string path = Console.ReadLine(); 
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            _ = new Program();
        }
    }
}
