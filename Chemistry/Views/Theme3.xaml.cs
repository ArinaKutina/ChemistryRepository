using Chemistry.DB;
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
    /// Логика взаимодействия для Theme3.xaml
    /// </summary>
    public partial class Theme3 : Window
    {
        ChemistryEntities chemistry = new ChemistryEntities();
        public int idTheme { get; set; }
        public Theme3()
        {
            InitializeComponent();
            Theme3Grid.ItemsSource = chemistry.Theme.Where(p => p.idTheme == 3).ToList();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }
    }
}
