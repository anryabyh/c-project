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
    /// Логика взаимодействия для Главная_Руководитель.xaml
    /// </summary>
    public partial class Главная_Руководитель : Window
    {
        public Главная_Руководитель()
        {
            InitializeComponent();
        }
        private void AddEvent_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow af = new MainWindow();
            af.Owner = this;
            af.Show();
        }
        private void AddFund_Button_Click(object sender, RoutedEventArgs e)
        {
            Добавление_фонда af = new Добавление_фонда();
            af.Owner = this;
            af.Show();
        }
        private void EntryAndEvent_Button_Click(object sender, RoutedEventArgs e)
        {
            ЗаписьНаСобытиесФондом af = new ЗаписьНаСобытиесФондом();
            af.Owner = this;
            af.Show();
        }

        private void Exit_button_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void registration_Button_Click(object sender, RoutedEventArgs e)
        {
            registrationryk af = new registrationryk();
            af.Owner = this;
            af.Show();
        }

    }
}
