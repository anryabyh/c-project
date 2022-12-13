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

namespace _3_1
{
    /// <summary>
    /// Логика взаимодействия для eventtt.xaml
    /// </summary>
    public partial class eventtt : Window
    {
        council_of_womenEntities db;
        public eventtt()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            dgevent.ItemsSource = null;
            dgevent.ItemsSource = db.event12.ToList();
        }
    }
}
