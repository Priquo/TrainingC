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
using TrainingC.pages;

namespace TrainingC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frameMain.Navigate(new TrainLevel1());
            PageLoader.MainFrame = frameMain;
        }

        private void buttonShowStudyMaterials_Click(object sender, RoutedEventArgs e)
        {
            StudyMaterials materials = new StudyMaterials();
            materials.Show();
        }

        private void buttonShowDocs_Click(object sender, RoutedEventArgs e)
        {
            string text = FileEditor.ReadFileToLine("docs/docs.hel");
            TaskDescription description = new TaskDescription(text);
            description.Title = "Руководство";
            description.MinHeight = 700;
            description.textblockDescription.FontSize = 18;
            description.Show();
        }
    }
}
