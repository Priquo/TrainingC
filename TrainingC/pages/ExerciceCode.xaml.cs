using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrainingC.classes;
using TrainingC.windows;

namespace TrainingC.pages
{
    /// <summary>
    /// Логика взаимодействия для ExerciceCode.xaml
    /// </summary>
    public partial class ExerciceCode : Page
    {
        int selectionIndexInCode = 0;
        string startTemplateCode;
        string pathToProgram = "exercicePrograms/programs/";
        string pathToTests = "exercicePrograms/tests/";
        
        Exercices exercice, localExercice;
        readonly Regex maskFunction = new Regex(@"(\b(void|int|double|float|char|struct|\*)(\s*\*)*\s*[a-zA-Z]{1,}\.*\(.*\))");
        readonly Regex maskArguments = new Regex(@"(\s*((void|int|double|float|char|struct|\*)(\s*\*)*)\s*)*[^a-zA-Z\[\]*]{1,}[\(\)\,]*");
        readonly Regex maskNameMethod = new Regex(@"[^voidintdoublefloatcharstruct][^\s\*\s][a-zA-Z]+");
        public ExerciceCode(Exercices exercice)
        {
            InitializeComponent();
            this.exercice = exercice;
            localExercice = exercice;
            string path = pathToProgram + exercice.NameMethod + "/" + exercice.NameMethod + ".c";
            startTemplateCode = "#include <stdio.h>\n#include \"../../tests/MainHeader.h\"\n\n" + exercice.MethodSignature + "\n" + @"//ПОСЛЕ НАЗВАНИЯ ФУНКЦИИ после типа укажите наименование аргумента - это ваши проверяемые параметры" + "\n{\n\n}";
            if (FileEditor.IsFileExists(path))
            {
                textBoxProgramCode.Text = FileEditor.ReadFileToLine(path);
            }
            else
            {                
                textBoxProgramCode.Text = startTemplateCode;
            }
            GetLocalMethodSignature();
        }
        void GetLocalMethodSignature()
        {
            var functionString = maskFunction.Match(textBoxProgramCode.Text).Value;
            if (exercice.Theme != "Упражнения на массивы")
            {
                var tempStr = "";
                foreach (var arg in maskArguments.Matches(functionString.Split('(')[1]))
                {
                    tempStr += arg;
                }
                functionString = functionString.Remove(functionString.IndexOf('(') + 1, functionString.Split('(')[1].Length);
                functionString += tempStr;
            }
            localExercice.MethodSignature = functionString;
            localExercice.NameMethod = maskNameMethod.Match(functionString.Split('(')[0]).Value.ToString().Replace(" ", "");
        }
        private void buttonShowDescription_Click(object sender, RoutedEventArgs e)
        {
            TaskDescription description = new TaskDescription(exercice);
            description.Show();
        }
        private void buttonCasesTemplates_Click(object sender, RoutedEventArgs e)
        {
            if (selectionIndexInCode != 0)
            {
                Button buttonClicked = (Button)sender;
                string template = "";
                switch (buttonClicked.Name)
                {
                    case "buttonTemplateIF":
                        template = "if ()\n{\n\n}\nelse if ()\n{\n\n}\nelse\n{\n\n}\n";
                        break;
                    case "buttonTemplateFOR":
                        template = "for (int i; i < n; i++)\n{\n\n}\n";
                        break;
                    case "buttonTemplateDOWHILE":
                        template = "do\n{\n\n}\nwhile ()\n";
                        break;
                    case "buttonTemplateWHILE":
                        template = "while ()\n{\n\n}\n";
                        break;
                }
                textBoxProgramCode.Text = textBoxProgramCode.Text.Insert(selectionIndexInCode, template);
            }
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxProgramCode.Text = startTemplateCode;
        }

        private void textBoxProgramCode_SelectionChanged(object sender, RoutedEventArgs e)
        {
            selectionIndexInCode = textBoxProgramCode.SelectionStart;
        }
        private bool SaveFileFromTextBox()
        {
            bool flag = false;
            GetLocalMethodSignature();
            if (localExercice.NameMethod.Contains(exercice.NameMethod + "Test"))
            {
                MessageBox.Show("Название функции не может совпадать с названием метода-теста. Переименуйте метод", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return flag;
            }
            FileEditor.DeleteFile(pathToProgram + exercice.NameMethod + "/" + exercice.NameMethod + ".c");
            if (FileEditor.CreateFolder(pathToProgram + exercice.NameMethod))
            {
                if (FileEditor.CreateOrOpenFile(pathToProgram + exercice.NameMethod + "/" + exercice.NameMethod + ".c", textBoxProgramCode.Text))
                {
                    flag = true;
                }
            }
            return flag;
        }
        private void buttonSaveCode_Click(object sender, RoutedEventArgs e)
        {            
            if (SaveFileFromTextBox())
            {
               MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else
                MessageBox.Show("Файл не сохранен :(", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void buttonGoBack_Click(object sender, RoutedEventArgs e)
        {
            PageLoader.MainFrame.GoBack();
        }

        private string OutputProgramText(string source)
        {
            string result = "";
            List<string> data = source.Split('\n').ToList();
            foreach (var str in data)
            {
                if (str.Contains("error"))
                {
                    if (str.Contains(exercice.NameMethod + "Test"))
                    {
                        result += "Ошибка при тестировании программы!\n";
                        result += source;
                        break;
                    }
                    else
                    {
                        result += "Ошибка при компиляции программы\n";
                        result += source;
                        break;
                    }
                }
                if (str.Contains(localExercice.NameMethod) && !str.Contains("Main.") && !str.Contains("\\"))
                {
                    for (int i = data.IndexOf(str) + 1; i < data.Count; i++)
                    {                        
                        result += data[i];
                        if (!data[i].Contains("\n"))
                            result += "\n";
                    }
                    break;
                }
            }            
            return result;
        }

        private void ChangeFontSize(object sender, RoutedEventArgs e)
        {
            Button butt = (Button)sender;
            switch (butt.Name)
            {
                case "buttonMinusFont":
                    textBoxProgramCode.FontSize++;
                break;
                case "buttonPlusFont":
                    textBoxProgramCode.FontSize--;
                    break;
            }
        }

        private void CompileOrRunProgram(object sender, RoutedEventArgs e)
        {
            string runProgramCommand = exercice.NameMethod;
            Button buttonClicked = (Button)sender;
            
            if (buttonClicked.Name == "buttonCompileCode")
                runProgramCommand = "";

            if (SaveFileFromTextBox())
            {
                if (ProgramMaker.AddToHeaderMethodSignature(localExercice.MethodSignature, pathToTests + "MainHeader.h", localExercice.NameMethod) &&
                    ProgramMaker.MakeTestUncommentedInMainFile(pathToTests + "Main.c", exercice.NameMethod + "Test()", false))
                {
                    if (ProgramMaker.MakeBatFile(pathToProgram + "autorun.bat", exercice.NameMethod, runProgramCommand))
                    {
                        try
                        {
                            string message = CommandLineHelper.Run(FileEditor.GetFullPath(pathToProgram + "autorun.bat"), "", FileEditor.GetFullPath(pathToProgram + "autorun.bat").Replace("\\autorun.bat", ""));
                            OutputProgram messageBox = new OutputProgram(message);
                            messageBox.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            OutputProgram messageBox = new OutputProgram(ex.Message);
                            messageBox.ShowDialog();
                        }
                        FileEditor.DeleteFile(pathToProgram + "autorun.bat");
                        ProgramMaker.MakeTestUncommentedInMainFile(pathToTests + "Main.c", exercice.NameMethod + "Test()", true);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка при подготовке программы к запуску", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
