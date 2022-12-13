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
    /// Логика взаимодействия для pozhertvovanie.xaml
    /// </summary>
    public partial class pozhertvovanie : Window
    {
        council_of_womenEntities db;
        public pozhertvovanie()
        {
            InitializeComponent();
            Refrech();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            DG_donat.ItemsSource = null;
            DG_donat.ItemsSource = db.donat.ToList();
        }
        private void Refrech()
        {
            db = new council_of_womenEntities();
            DG_donat.ItemsSource = null;
            DG_donat.ItemsSource = db.donat.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                donat donat1 = new donat();
                var count = db.donat.Count() + 1;
                donat1.numb_donat = count;
                donat1.date_donat = Convert.ToDateTime(date_eventtx.SelectedDate = DateTime.Now);
                donat1.summ = Convert.ToDecimal(TBsumm.Text);
                donat1.numb_pay = Convert.ToInt32(TBpay.Text);
                donat1.loginn = TBloginn.Text;
                donat1.inn_fund = Convert.ToDecimal(TBinn.Text);
                db.donat.Add(donat1);
                db.SaveChanges();
                Refrech();
                MessageBox.Show("Пожертвование произведено успешно!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void UykassaButton_Click(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://yookassa.ru/integration/simplepay/");
        }
    }
}
