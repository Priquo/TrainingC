using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrainingC.classes
{
    static class FileEditor
    {
        static public string[] GetAllFilesPath (string pathToFolder)
        {
            return Directory.GetFiles(pathToFolder);
        }
        static public string[] GetAllSubFolders(string pathToMainFolder)
        {
            return Directory.GetDirectories(pathToMainFolder);
        }
        static public List<string> ReadFile(string path)
        {
            List<string> str = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    str.Add(sr.ReadLine());
                }
            }
            return str;
        }
    }
}
