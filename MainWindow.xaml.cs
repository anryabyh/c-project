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

namespace _3_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        council_of_womenEntities db;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_loaded_dg(object sender, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            dgevent12.ItemsSource = db.event12.ToList();
        }
        private void Insert_Button_Click(object sender, RoutedEventArgs e)
        {
            var count = db.event12.Count() + 1;
            event12 ev = new event12();
            ev.numb_event = count;
            ev.date_event = date_eventtx.SelectedDate.Value;
            ev.locationn = locationntx.Text;
            ev.name_event = name_eventtx.Text;
            ev.street_event = street_eventtx.Text;
            ev.house_event = Convert.ToInt32(house_eventtx.Text);
            db.event12.Add(ev);
            db.SaveChanges();
            dgevent12.ItemsSource = db.event12.ToList();
        }
        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(numb_eventtx.Text);
            var uRow = db.event12.Where(w => w.numb_event == num).FirstOrDefault();
            uRow.numb_event = Convert.ToInt32(numb_eventtx.Text);
            uRow.date_event = date_eventtx.SelectedDate.Value;
            uRow.locationn = locationntx.Text;
            uRow.street_event = street_eventtx.Text;
            uRow.house_event = Convert.ToInt32(house_eventtx.Text);
            db.SaveChanges();
            dgevent12.ItemsSource = db.event12.ToList();
        }
        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (dgevent12.SelectedValue != null)
            {
                var numb_event = Convert.ToInt32(dgevent12.SelectedValue);
                var dRow = db.event12.FirstOrDefault(w => w.numb_event == numb_event);
                db.event12.Remove(dRow);
                db.SaveChanges();
                dgevent12.ItemsSource = db.event12.ToList();
            }
        }
    }
}

