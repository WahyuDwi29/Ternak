using System.Windows;
using Final_Project_Pemrograman_Lanjut.controller;

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
    }
}