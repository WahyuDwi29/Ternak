using System.Windows;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class UsersController
    {
        private UsersModel _model;
        private LoginWindow _view;

        public UsersController(LoginWindow view)
        {
            _model = new UsersModel();
            _view = view;
        }
        

        public void Login()
        {
            _model.nama = _view.txtUsername.Text;
            _model.password = _view.PbPassword.Password;
            var result = _model.CheckLogin();

            if (result)
            {
                var main = new MainWindow();
                main.LblUser.Content = UsersModel.UserName;
                main.Show();
                _view.Close();
            }
            else
            {
                MessageBox.Show("Your username/password is wrong");
                _view.txtUsername.Text = "";
                _view.PbPassword.Password = "";
                _view.txtUsername.Focus();
            }
        }
        
        
    }
}