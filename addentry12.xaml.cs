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
    /// Логика взаимодействия для addentry12.xaml
    /// </summary>
    public partial class addentry12 : Window
    {
        council_of_womenEntities db;
        public addentry12()
        {
            InitializeComponent();
        }
        private void Refrech()
        {
            db = new council_of_womenEntities();
            dgentry.ItemsSource = null;
            dgentry.ItemsSource = db.entry1.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refrech();
        }

        private void EventButton_Click(object sender, RoutedEventArgs e)
        {
            eventtt eventtt = new eventtt();
            eventtt.Owner = this;
            eventtt.Show();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                entry1 entry = new entry1();
            var count = db.entry1.Count() + 1;
            entry.numb_entry = count;
            entry.date_entry = Convert.ToDateTime(date_eventtx.SelectedDate = DateTime.Now);
            entry.loginn = TBloginn.Text;
            entry.numb_event = Convert.ToInt32(TBnumbev.Text);
            db.entry1.Add(entry);
            db.SaveChanges();
            dgentry.ItemsSource = db.entry1.ToList();
                MessageBox.Show("Вы записаны!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
