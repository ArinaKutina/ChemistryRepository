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

namespace Chemistry.Views
{
    /// <summary>
    /// Логика взаимодействия для TableofMendeleev.xaml
    /// </summary>
    public partial class TableofMendeleev : Window
    {
        public TableofMendeleev()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchElements searchElements = new SearchElements(); 
            searchElements.Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
