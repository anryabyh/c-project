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
    /// Логика взаимодействия для Добавление_фонда.xaml
    /// </summary>
    public partial class Добавление_фонда : Window
    {
        council_of_womenEntities db;
        public Добавление_фонда()
        {
            InitializeComponent();
            Refrech();
        }
        private void Window_loaded_dgfunds(object sender, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            Refrech();
        }
        private void Refrech() 
        {
            db = new council_of_womenEntities();
            dgfunds.ItemsSource = null;
            CB_House.ItemsSource = null;
            dgfunds.ItemsSource = db.funds.ToList();
            CB_House.ItemsSource = db.funds.Distinct().ToList();
        }
        private void Insert_Fund_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                funds f = new funds();
                f.name_fund = name_fundtx.Text;
                f.street_fund = street_fundtx.Text;
                f.house_fund = Convert.ToInt32(house_fundtx.Text);
                f.town_fund = town_fundtx.Text;
                f.phone_fund = Convert.ToDecimal(phone_fundtx.Text);
                f.inn_fund = Convert.ToDecimal(inn_fundtx.Text);
                db.funds.Add(f);
                db.SaveChanges();
                Refrech();
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Update_Fund_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal num = Convert.ToDecimal(inn_fundtx.Text);
                var uRow = db.funds.Where(w => w.inn_fund == num).FirstOrDefault();
                uRow.name_fund = name_fundtx.Text;
                uRow.street_fund = street_fundtx.Text;
                uRow.house_fund = Convert.ToInt32(house_fundtx.Text);
                uRow.town_fund = town_fundtx.Text;
                uRow.phone_fund = Convert.ToDecimal(phone_fundtx.Text);
                uRow.inn_fund = Convert.ToDecimal(inn_fundtx.Text);
                db.SaveChanges();
                Refrech();
                MessageBox.Show("Запись изменена!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
        }
        private void Delete_Fund_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var inn_fund = Convert.ToInt32(dgfunds.SelectedValue);
                var dRow = db.funds.Where(w => w.inn_fund == inn_fund).FirstOrDefault();
                db.funds.Remove(dRow);
                db.SaveChanges();
                Refrech();
                MessageBox.Show("Запись удалена!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgfunds.ItemsSource = null;
            var text = TB_Search.Text;
            dgfunds.ItemsSource = db.funds.Where(n=>n.name_fund.Contains(text)).ToList();
        }

        private void CB_House_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dgfunds.ItemsSource = null;
            var text =Convert.ToInt32(CB_House.SelectedValue);
            dgfunds.ItemsSource = db.funds.Where(n => n.inn_fund == text).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e) => Refrech();
    }
}
