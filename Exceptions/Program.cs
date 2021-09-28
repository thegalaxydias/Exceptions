using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = "files.txt";
                string path = Path.GetFullPath(file);
                string a = File.ReadAllText(path);
                Console.WriteLine(a);
            }

            catch
            {
                Console.WriteLine("Please create file!");
            }

            finally
            {
                Console.WriteLine("Operation is finished");
            }
        }
    }
}
