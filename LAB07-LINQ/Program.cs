using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LAB07_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadingFile();
        }

        static void ReadingFile()
        {
            try
            {
                String nyData = File.ReadAllText("C:/Users/Matthew/source/repos/LAB07-LINQ/LAB07-LINQ/data.json");
                Console.WriteLine(nyData);
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error reading your file");
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }
}
