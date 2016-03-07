using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileProject
{
    public class FileWriter
    {
        private readonly string _fileName;

        public FileWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteToFile(List<List<string>> str )
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (List<string> strs in str)
                    {
                        foreach (string s in strs)
                        {
                            sw.WriteLine(s + ",");
                        }
                    }
                    
                }
            }
        }
    }
}
