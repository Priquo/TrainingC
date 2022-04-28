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

namespace TrainingC.pages
{
    /// <summary>
    /// Логика взаимодействия для TrainLevel1.xaml
    /// </summary>
    public partial class TrainLevel1 : Page
    {
        TrainLoader trainLoader = new TrainLoader();
        public TrainLevel1()
        {
            InitializeComponent();
            DataContext = trainLoader;
            foreach (var listbox in trainLoader.ListBoxes)
            {
                listbox.ItemTemplate = (DataTemplate)this.Resources["itemsTemplate"];
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            PageLoader.MainFrame.Navigate(new ExerciceCode(trainLoader.ListExercices.FirstOrDefault(x => x.ID == Convert.ToInt32(button.Uid))));
        }
    }
}
