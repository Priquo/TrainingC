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
            string batText = @"..\compiler\bin\gcc.exe -c ../tests/Main.c ../tests/" + programFileName + "Test.c " + programFileName + "/" + programFileName + ".c\n" +
                @"..\compiler\bin\gcc.exe Main.o  " + programFileName + "Test.o " + programFileName + ".o -o " + programFileName +
                "\n" + runOrNot + "\npause";
            bool result = FileEditor.CreateOrOpenFile(path, batText);            
            return result;
        }
        public static bool AddToHeaderMethodSignature(string methodSignature, string headerPath)
        {
            bool result = false;
            try
            {
                List<string> dataHeader = FileEditor.ReadFile(headerPath);
                if (dataHeader.Contains(methodSignature + ";"))
                    return true;
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
        public static bool MakeTestUncommentedInMainFile(string mainFilePath, string testName, bool shoudMakeTextComment)
        {
            bool result = false;
            List<string> contentCode = FileEditor.ReadFile(mainFilePath);          
            try
            {
                if (contentCode.Contains("\t" + testName + ";") && !shoudMakeTextComment)
                    return true;
                else if (contentCode.Contains("\t" + testName + ";") && shoudMakeTextComment)
                {
                    contentCode[contentCode.IndexOf("\t" + testName + ";")] = "\t//" + testName + ";";
                    return true;
                }
                if (contentCode.Contains("\t//" + testName + ";"))
                    contentCode[contentCode.IndexOf("\t//" + testName + ";")] = "\t" + testName + ";";
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
            return result;
        }
    }
}
