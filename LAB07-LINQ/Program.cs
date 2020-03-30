using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using LAB07_LINQ.Classes;
using System.Linq;


namespace LAB07_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCombined();
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

        static void PrintNoSpacNeighborhoods()
        {
            try
            {
                String nyData = File.ReadAllText("C:/Users/Matthew/source/repos/LAB07-LINQ/LAB07-LINQ/data.json");
                // first parse the data and then for each item in the features collection we want to print out the "neighborhoods" string
                RootObject parsedNyData = JsonConvert.DeserializeObject<RootObject>(nyData);

                NoSpace(parsedNyData);

            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error reading your file");
                Console.WriteLine(e.Message);
            }
        }

        static void NoSpace(RootObject data)
        {
            var x = from neighborhood in data.features select neighborhood;
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            var y = x.Where(z => z.properties.neighborhood != "")
            .Select(z => z.properties.neighborhood);

            foreach (var item in y)
            {
                Console.WriteLine(item);
            }


        }

        static void PrintOnlyDistinct()
        {
            try
            {
                String nyData = File.ReadAllText("C:/Users/Matthew/source/repos/LAB07-LINQ/LAB07-LINQ/data.json");
                // first parse the data and then for each item in the features collection we want to print out the "neighborhoods" string
                RootObject parsedNyData = JsonConvert.DeserializeObject<RootObject>(nyData);

                Combined(parsedNyData);

            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error reading your file");
                Console.WriteLine(e.Message);
            }
        }

        static void PrintCombined()
        {
            try
            {
                String nyData = File.ReadAllText("C:/Users/Matthew/source/repos/LAB07-LINQ/LAB07-LINQ/data.json");
                // first parse the data and then for each item in the features collection we want to print out the "neighborhoods" string
                RootObject parsedNyData = JsonConvert.DeserializeObject<RootObject>(nyData);

                Combined(parsedNyData);

            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error reading your file");
                Console.WriteLine(e.Message);
            }
        }

        static void Combined(RootObject data)
        {
            var x = from neighborhood in data.features select neighborhood;
            foreach(var item in x)
            {
                Console.WriteLine(item.properties.neighborhood);
            }

            var y = x.Where(z => z.properties.neighborhood != "")
            .Select(z => z.properties.neighborhood);

            foreach(var item in y)
            {
                Console.WriteLine(item);
            }

            foreach (var item in y.Distinct())
            {
                Console.WriteLine(item);
            }
            
        }

        static void Combined2(RootObject data)
        {
            var x = data.features.Select(x =>x);
          

            var y = x.Where(z => z.properties.neighborhood != "")
            .Select(z => z.properties.neighborhood);

          

            foreach (var item in y.Distinct())
            {
                Console.WriteLine(item);
            }

        }
    }
}
