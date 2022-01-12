using System.Windows;
using System.Windows.Input;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class RegisterWindow : Window
    {
        private AddUsersController _addUsers;
        public RegisterWindow()
        {
            InitializeComponent();
            _addUsers = new AddUsersController(this);
        }

        private void Btndaftar(object sender, RoutedEventArgs e)
        {
            _addUsers.Register();
        }

        private void LblDaftar_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var login = new LoginWindow();
            login.Show();
            Close();
        }
    }
}