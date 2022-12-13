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
    /// Логика взаимодействия для Пользователь.xaml
    /// </summary>
    public partial class Пользователь : Window
    {
        public Пользователь()
        {
            InitializeComponent();
        }

        private void MapButton_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map();
            map.Owner = this;
            map.Show();
        }

        private void DonatButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://yookassa.ru/integration/simplepay/");
        }

        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            addentry12 addentry = new addentry12();
            addentry.Owner = this;
            addentry.Show();
        }


        private void FundsButton_Click(object sender, RoutedEventArgs e)
        {
            fundspol fundspol = new fundspol();
            fundspol.Owner = this;
            fundspol.Show();
        }

        private void Donat2Button_Click(object sender, RoutedEventArgs e)
        {
            pozhertvovanie pozhertvovanie = new pozhertvovanie();
            pozhertvovanie.Owner = this;
            pozhertvovanie.Show();
        }
        private void EventButton_Click(object sender, RoutedEventArgs e)
        {
            addentry12 addentry = new addentry12();
            addentry.Owner = this;
            addentry.Show();
        }
    }
}
