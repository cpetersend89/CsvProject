using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileProject
{
    public class FileReader
    {
        private readonly string _fileName;

        public FileReader(string fileName)
        {
            _fileName = fileName;
        }

        public List<List<string>> ReadFromFile()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<List<string>> listOfString = new List<List<string>>();
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        string[] parseString = str.Split(',');
                        List<string> stringList = parseString.ToList();
                        listOfString.Add(stringList);
                    }
                    return listOfString;
                }
            }
        }

    }
}
