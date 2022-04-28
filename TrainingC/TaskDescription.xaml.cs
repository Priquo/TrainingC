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
using System.Windows.Shapes;
using TrainingC.classes;

namespace TrainingC
{
    /// <summary>
    /// Логика взаимодействия для TaskDescription.xaml
    /// </summary>
    public partial class TaskDescription : Window
    {
        Exercices exercice;
        public TaskDescription(Exercices exercice)
        {
            InitializeComponent();
            this.exercice = exercice;
            textblockDescription.Text ="Тема:\n" + exercice.Theme + "\nОписание:\n" + exercice.Description +
                "\n\nВаша программа должна быть написана в функции с сигнатурой " + exercice.MethodSignature +
                ". Это необходимо для реализации проверки вашего кода. ВАЖНО: после типа каждого аргумента перед запятой напишите название аргумента, иначе проверку произвести не выйдет." +
                "\nПроверка производится следующим образом: в вашу функцию передаются данные по аргументам, она возвращает результат с заданным типом. Он проверяется и возвращает вам результат";
        }
    }
}
