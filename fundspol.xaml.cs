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
    /// Логика взаимодействия для fundspol.xaml
    /// </summary>
    public partial class fundspol : Window
    {
        council_of_womenEntities db;
        public fundspol()
        {
            InitializeComponent();
            Refrech();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            Refrech();
        }
        private void Refrech()
        {
            db = new council_of_womenEntities();
            dgfunds.ItemsSource = null;
            dgfunds.ItemsSource = db.funds.ToList();
        }
        public void TextBox_TextChanged(object s, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            dgfunds.ItemsSource = null;
            var text = TB_Search.Text;
            dgfunds.ItemsSource = db.funds.Where(n => n.name_fund.Contains(text)).ToList(); 
        }
    }
}
