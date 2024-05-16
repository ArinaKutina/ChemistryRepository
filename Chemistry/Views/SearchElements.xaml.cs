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
    /// Логика взаимодействия для SearchElements.xaml
    /// </summary>
    public partial class SearchElements : Window
    {
        ChemistryEntities chemistry = new ChemistryEntities();
        public int idElement {  get; set; }
        public SearchElements()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var id = Convert.ToInt32(SearchElement.Text);
            if (id <= 118 && id >= 1)
            {
                ElementGrid.ItemsSource = chemistry.MendeleevTable.Where(p=>p.idElement == id).ToList();
            }
            else
            {
                MessageBox.Show("Нет элемента с таким номером!");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
