using System.Windows;
using System.Windows.Input;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class LoginWindow : Window
    {
        private readonly UsersController _usersController;

        public LoginWindow()
        {
            InitializeComponent();
            _usersController = new UsersController(this);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            _usersController.Login();
        }

        private void LblDaftarWindows_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var daftarWindow = new RegisterWindow();
            daftarWindow.Show();
            this.Close();
        }
    }
}