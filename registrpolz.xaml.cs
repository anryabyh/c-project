using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для registrpolz.xaml
    /// </summary>
    public partial class registrpolz : Window
    {
        council_of_womenEntities db;
        public registrpolz()
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
            dgregistrationryk.ItemsSource = null;
            dgregistrationryk.ItemsSource = db.user1.ToList();
        }
        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user1 f = new user1();
                f.loginn = TBloginn.Text;
                f.surname = TBsur.Text;
                f.namee = TBname.Text;
                f.patronymic = TBpatr.Text;
                f.phone_user = Convert.ToDecimal(TBphone.Text);
                f.email = TBemail.Text;
                f.passwordd = GetHash(PB_password.Password);
                f.leader = TBemail.Text;
                db.user1.Add(f);
                db.SaveChanges();
                Refrech();
                MessageBox.Show("Пользователь добавлен!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void null_Click(object sender, RoutedEventArgs e)
        {
            TBloginn.Clear();
            TBemail.Clear();
            TBname.Clear();
            TBpatr.Clear();
            TBphone.Clear();
            TBemail.Clear();
            TBsur.Clear();
            PB_password.Clear();
        }
    }
}
