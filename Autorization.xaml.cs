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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        council_of_womenEntities db;
        public Autorization()
        {
            InitializeComponent();
        }
        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
        private void Autorization_Click(object sender, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            var login = TB_Login.Text;
            var password =GetHash(PB_Password.Password);
            var aut = db.user1.FirstOrDefault(a => a.loginn == login && a.passwordd == password);
            if (aut != null)
            {
                if (aut.leader == "да")
                {
                    (new Главная_Руководитель()).Show();
                    this.Close();
                }
                else
                {
                    (new Пользователь()).Show();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            registrpolz registrpolz = new registrpolz();
            registrpolz.Owner=this;
            registrpolz.Show();

        }
    }
}
