using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgEng_Lab06
{
    /// <summary>
    /// Логика взаимодействия для Task.xaml
    /// </summary>
    public partial class Task : Window
    {
        public MainWindow main;
        public Task()
        {
            InitializeComponent();
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Task1RB.IsChecked == true)
            {
                int maxSpecies = main.zoo_list.Max(t => t.Species);
                List<Zoo> filtered = main.zoo_list.FindAll(e => e.Species == maxSpecies);
                ZooData.ItemsSource = filtered;
                ZooData.Items.Refresh();
            }
            else if (Task2RB.IsChecked == true) { 
                float minArea = main.zoo_list.Min(t => t.Area / t.Species);
                List<Zoo> filtered = main.zoo_list.FindAll(e => (e.Area / e.Species) == minArea);
                ZooData.ItemsSource = filtered;
                ZooData.Items.Refresh();
            }
            

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            main.TaskMenuItem.IsEnabled = true;
        }
    }
}
