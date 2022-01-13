using System.Windows;
using System.Windows.Input;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class RegisterWindow : Window
    {
        private RegisterController _register;
        public RegisterWindow()
        {
            InitializeComponent();
            _register = new RegisterController(this);
        }

        private void Btndaftar(object sender, RoutedEventArgs e)
        {
            _register.Register();
        }

        private void LblDaftar_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var login = new LoginWindow();
            login.Show();
            Close();
        }
    }
}