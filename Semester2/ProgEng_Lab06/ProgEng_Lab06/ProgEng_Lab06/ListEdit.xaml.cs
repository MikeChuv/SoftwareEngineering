using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
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
    /// Логика взаимодействия для ListEdit.xaml
    /// </summary>
    public partial class ListEdit : Window
    {
        public MainWindow main;
        public ListEdit()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            main.zoo_list.Add(new Zoo());
            ZooData.Items.Refresh();
        }


        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Zoo zooItem = (Zoo)ZooData.SelectedItem;
            main.zoo_list.Remove(zooItem);
            ZooData.Items.Refresh();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            main.EditListMenuItem.IsEnabled = true;
        }

    }
}
