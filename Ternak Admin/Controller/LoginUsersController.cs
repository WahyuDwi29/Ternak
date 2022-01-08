using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class UsersController
    {
        private UsersModel _usersModel;
        private LoginWindow _loginWindow;

        public UsersController(LoginWindow loginWindow)
        {
            _usersModel = new UsersModel();
            _loginWindow = loginWindow;
        }
        

        public void Login()
        {
            _usersModel.nama = _loginWindow.txtUsername.Text;
            _usersModel.password = _loginWindow.txtPassword.Password;
            var result = _usersModel.CheckLogin();

            if (result)
            {
                var main = new MainWindow();
                var confirm = new ConfirmWindow();
                confirm.ImgIcon.Source = new BitmapImage(new Uri("/Img/ic_check_circle.png", UriKind.Relative));
                confirm.Lbl1.Content = "Login Berhasil";
                confirm.Lbl2.Content = "";
                confirm.Lbl3.Content = "";
                confirm.Height = 125;
                confirm.Width = 340;
                confirm.ShowDialog();
                main.LblUser.Content = UsersModel.UserName;
                main.Show();
                _loginWindow.Close();
            }
            else
            {
                var confirm = new ConfirmWindow();
                confirm.ImgIcon.Source = new BitmapImage(new Uri("/Img/ic_cancel.png", UriKind.Relative));
                confirm.Lbl1.Content = "Login Gagal";
                confirm.Lbl2.Content = "pastikan anda memasukan data dengan benar";
                confirm.Lbl3.Content = "";
                confirm.ShowDialog();
                _loginWindow.txtUsername.Text = "";
                _loginWindow.txtPassword.Password = "";
                _loginWindow.txtUsername.Focus();
            }
        }
        
        
    }
}