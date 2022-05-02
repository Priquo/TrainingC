using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrainingC.classes
{
    public static class ProgramMaker
    {
        public static bool MakeBatFile(string path, string programFileName, string runOrNot)
        {
            string isEchoOf = runOrNot == "" ? "echo off\n" : "";
            string isPauseNeeds = runOrNot == "" ? "\npause" : "";
            string batText = isEchoOf + @"compiler\bin\gcc.exe -c ../tests/Main.c " + programFileName + ".c\n" +
                @"compiler\bin\gcc.exe -c ../tests/Main.o " + programFileName + ".o -o " + programFileName +
                "\n" + runOrNot + isPauseNeeds;
            bool result = FileEditor.CreateOrOpenFile(path, batText);            
            return result;
        }
        public static bool AddToHeaderMethodSignature(string methodSignature, string headerPath)
        {
            bool result = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(headerPath, FileMode.Append)))
                {
                    sw.WriteLine(methodSignature + ";");
                }
                result = true;
            }
            catch
            {
            }
            return result;
        }
        public static bool MakeTestUncommentedInMainFile(string mainFilePath, string testName)
        {
            bool result = false;
            List<string> contentCode = FileEditor.ReadFile(mainFilePath);
            if (contentCode.Contains(testName))
            {
                contentCode[contentCode.IndexOf("\t//" + testName + ";")] = "\t" + testName + ";";
                try
                {
                    using (StreamWriter sw = new StreamWriter(mainFilePath, false))
                    {
                        foreach (var str in contentCode)
                            sw.WriteLine(str);
                    }
                    result = true;
                }
                catch
                {
                }
            }
            return result;
        }
    }
}
