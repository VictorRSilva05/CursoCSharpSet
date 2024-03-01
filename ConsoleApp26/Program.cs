using ConsoleApp26.Entities;
using System.Globalization;
using System.Text;
namespace ConsoleApp26
{
    internal class Program
    {
        Program()
        {
            Console.Write("Enter file full path: ");        //C:\Windows\Temp\online_users.txt
            string path = Console.ReadLine(); 

            HashSet<Users> users = new HashSet<Users>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(' ');
                        DateTime date = DateTime.ParseExact(data[1], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                        string username = data[0];
                        users.Add(new Users(username, date));
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\nTotal users: " + users.Count);
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
