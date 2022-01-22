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

namespace ProgEng_Lab06
{

    /// <summary>
    /// Class, that describes a zoo (Name, Species, Area)
    /// </summary>
    public class Zoo {
        public string Name { get; set; }

        public int Species { get; set; }

        public float Area { get; set; }

    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Zoo> zoo_list;
        public MainWindow()
        {
            InitializeComponent();
            zoo_list = new List<Zoo>();
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CreateListMenuItem_Click(object sender, RoutedEventArgs e)
        {
            FirstListEdit firstListEdit = new FirstListEdit();
            firstListEdit.main = this;
            CreateListMenuItem.IsEnabled = false;
            firstListEdit.Show();
        }

        private void EditListMenuItem_Click(object sender, RoutedEventArgs e)
        {

            ListEdit listEdit = new ListEdit();
            listEdit.main = this;
            listEdit.ZooData.ItemsSource = zoo_list;
            EditListMenuItem.IsEnabled = false;
            listEdit.Show();
        }

        private void TaskMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task();
            task.main = this;
            task.Task1RB.IsChecked = true;
            task.Task2RB.IsChecked = false;
            TaskMenuItem.IsEnabled = false;
            task.Show();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
