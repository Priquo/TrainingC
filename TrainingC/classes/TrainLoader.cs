using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TrainingC.classes
{
    class TrainLoader
    {
        public string path = "exercices";
        List<Exercices> listExercices = new List<Exercices>();
        List<GroupBox> listTitles = new List<GroupBox>();
        List<ListBox> listBoxes = new List<ListBox>();
        public List<Exercices> ListExercices { get => listExercices; set => listExercices = value; }
        public List<GroupBox> ListTitles { get => listTitles; set => listTitles = value; }
        public List<ListBox> ListBoxes { get => listBoxes; set => listBoxes = value; }
        
        public TrainLoader()
        {
            var folders = FileEditor.GetAllSubFolders(path);
            int exercicesCounter = 1;
            foreach (var folder in folders)
            {
                if (folder != "")
                {
                    var files = FileEditor.GetAllFilesPath(folder);
                    foreach (var file in files)
                    {                        
                        List<string> tempData = FileEditor.ReadFile(file);
                        for (int i = 1; i < tempData.Count; i++)
                        {
                            listExercices.Add(new Exercices()
                            {
                                ID = exercicesCounter,
                                Theme = tempData[0],
                                Level = file.Substring(file.Length - 5, 1),
                                Description = tempData[i].Split('#')[0],
                                NameMethod = tempData[i].Split('#')[1],
                                InputTypes = tempData[i].Split('#')[2],
                                OutputTypes = tempData[i].Split('#')[3],
                                MethodSignature = MakeMethodSignture(tempData[i])
                            });
                            exercicesCounter++;
                        }
                    }
                    if (listExercices.Count != 0 && files.Length != 0)
                    {
                        listTitles.Add(new GroupBox() { Header = listExercices.Last().Theme });
                        listBoxes.Add(new ListBox() { ItemsSource = listExercices.Where(x => x.Theme == listTitles.Last().Header.ToString()) });
                        listTitles.Last().Content = listBoxes.Last();
                    }
                }
            }
        }
        string MakeMethodSignture(string data)
        {
            List<string> str = new List<string>();
            str.Add(data.Split('#')[1]);
            str.Add(data.Split('#')[2]);
            str.Add(data.Split('#')[3]);            
            return str[2] + " " + str[0] + MakeTypesString(str[1]);
        }
        string MakeTypesString(string data)
        {
            string[] str = data.Split('_');
            string result = "(";
            int countTypes = 1;
            foreach (var s in str)
            {                
                try
                {
                    countTypes = Convert.ToInt32(s);
                }
                catch
                {
                    for (int i = 0; i < countTypes; i++)
                        result += s + ", ";
                }
            }
            result = result.Remove(result.Length - 2, 2);
            result += ")"; 
            return result;
        }
    }
}
