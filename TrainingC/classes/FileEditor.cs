using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrainingC.classes
{
    static public class FileEditor
    {
        static public string[] GetAllFilesPath(string pathToFolder)
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
        static public string ReadFileToLine(string path)
        {
            string str = "";
            using (StreamReader sr = new StreamReader(path))
            {
                str = sr.ReadToEnd();
            }
            return str;
        }
        static public bool CreateFolder(string directoryName)
        {
            bool result = false;
            try
            {
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
                result = true;
            }
            catch
            { }
            return result;
        }
        static public bool CreateOrOpenFile(string path, string fileContent)
        {
            bool result = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    sw.Write(fileContent);
                }
                result = true;
            }
            catch
            {
            }
            return result;
        }
        static public bool DeleteFile(string path)
        {
            bool result = false;
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    result = true;
                }
                catch { }
            }
            return result;
        }
        static public bool IsFileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
