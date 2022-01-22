using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
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
    /// Логика взаимодействия для FirstListEdit.xaml
    /// </summary>
    public partial class FirstListEdit : Window
    {
        public MainWindow main;
        public FirstListEdit()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Zoo currentZoo = new Zoo();
            currentZoo.Name = ZooNameEdit.Text;
            currentZoo.Species = int.Parse(SpeciesEdit.Text);
            currentZoo.Area = Single.Parse(AreaEdit.Text);
            main.zoo_list.Add(currentZoo);
            ZooNameEdit.Text = "";
            SpeciesEdit.Text = "";
            AreaEdit.Text = "";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            main.CreateListMenuItem.IsEnabled = true;
        }
    }
}
