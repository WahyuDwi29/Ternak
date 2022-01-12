using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            var controller = new ProfileController(this);
            controller.ShowData();
            
        }

        private void ImgShow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            PbPassword.Visibility = Visibility.Collapsed;
            TbPassword.Visibility = Visibility.Visible;
        }

        private void ImgShow_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            PbPassword.Visibility = Visibility.Visible;
            TbPassword.Visibility = Visibility.Collapsed;
        }
    }
}