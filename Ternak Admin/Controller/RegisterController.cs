using System.Windows;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class RegisterController
    {
        private RegisterWindow _view;
        private UsersModel _model;

        public RegisterController(RegisterWindow view)
        {
            _view = view;
            _model = new UsersModel();
        }

        public void Register()
        {
            _model.nama = _view.txtUsername.Text;
            _model.password = _view.txtPassword.Password;
            var result = _model.AddUsers();
            if (result)
            {
                MessageBox.Show("pembuatan akun berhasil silahkan Login");
                var loginWindow = new LoginWindow();
                loginWindow.Show();
                _view.Close();
            }
            else
            {
                MessageBox.Show("Registrasi Gagal!");
            }
        }
    }
}