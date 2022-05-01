using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace TrainingC.pages
{
    /// <summary>
    /// Логика взаимодействия для ExerciceCode.xaml
    /// </summary>
    public partial class ExerciceCode : Page
    {
        int selectionIndexInCode = 0;
        string startTemplateCode;
        string pathToProgram = "../../exercicePrograms/programs/";
        Exercices exercice;
        public ExerciceCode(Exercices exercice)
        {
            InitializeComponent();
            this.exercice = exercice;
            startTemplateCode = "#include <stdio.h>\n#include \"../test/MainHeader.h\"\n\n" + exercice.MethodSignature + "\t" + @"// после типа укажите наименование аргумента - это ваши проверяемые параметры" + "\n{\n\n}";
            textBoxProgramCode.Text = startTemplateCode;
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

        private void buttonSaveCode_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;            
            if (FileEditor.CreateFolder(pathToProgram + exercice.NameMethod))
            {
                if (FileEditor.CreateOrOpenFile(exercice.NameMethod + ".c", pathToProgram + exercice.NameMethod + "/" + exercice.NameMethod + ".c", textBoxProgramCode.Text))
                {
                    MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    flag = true;
                }
            }
            if(!flag)
                MessageBox.Show("Файл не сохранен :(", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
