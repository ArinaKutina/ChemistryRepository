using Chemistry.DB;
using Chemistry.Views;
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

namespace Chemistry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChemistryEntities chemistry = new ChemistryEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Theme1_Click(object sender, RoutedEventArgs e)
        {
            Theme1 theme1 = new Theme1();
            Close();
            theme1.ShowDialog();
        }

        private void Theme2_Click(object sender, RoutedEventArgs e)
        {
            Theme2 theme2 = new Theme2();
            Close();
            theme2.ShowDialog();
        }

        private void Theme3_Click(object sender, RoutedEventArgs e)
        {
            Theme3 theme3 = new Theme3();
            Close();
            theme3.ShowDialog();
        }

        private void MendeleevTable_Click(object sender, RoutedEventArgs e)
        {
            TableofMendeleev tableofMendeleev = new TableofMendeleev();
            tableofMendeleev.ShowDialog();
        }

        private void MyThemes_Click(object sender, RoutedEventArgs e)
        {
            MyThemes myThemes = new MyThemes();
            Close();
            myThemes.ShowDialog();
        }

        private void NewTheme_Click(object sender, RoutedEventArgs e)
        {
            AddTheme addTheme = new AddTheme();
            Close();
            addTheme.ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
