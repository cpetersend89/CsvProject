using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<string>> str = new List<List<string>>();
            List<string> list1 = new List<string>();
            //list1.Add("This is string one in the first list.");
            //list1.Add("this is string two in the first list.");

            List<string> list2 = new List<string>();
            //list2.Add("This is string three in the second list");
            //list2.Add("This is string four in the second list");

            str.Add(list1);
            str.Add(list2);

            FileWriter fw = new FileWriter(@"../../Strings.csv");
            fw.WriteToFile(str);


            Queries queries = new Queries();
            queries.FindKeyWord("one");

            Console.ReadKey();

        }
    }
}
