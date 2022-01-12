using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class ProfileController
    {
        private ProfilePage _view;

        public ProfileController(ProfilePage view)
        {
            _view = view;
        }

        public void ShowData()
        {
            _view.TbUser.Text = UsersModel.UserName;
            _view.TbPassword.Text = UsersModel.Password;
            _view.PbPassword.Password = UsersModel.Password;
        }
    }
}