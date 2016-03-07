using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileProject
{
    public class Queries
    {
        FileReader fr = new FileReader(@"../../Strings.csv");
        public void FindKeyWord(string keyWord)
        {
            List<List<string>> temp = fr.ReadFromFile();
            foreach (List<string> t in temp)
            {
                foreach (string s in t)
                {
                    if (s.Contains(keyWord))
                    {
                        Console.WriteLine(s);
                    }
                }

            }
        }
    }
}
