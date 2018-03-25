using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathletics
{
    public class SimpleFileIO
    {
        private string _path;
        public SimpleFileIO(string filePath)
        {
            _path = filePath;
        }
        public string Read()
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                return sr.ReadToEnd();
            }
        }
        public void Write(string text)
        {
            File.WriteAllText(_path,text);
        }
    }
}
