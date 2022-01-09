using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Ternak_Admin.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CowPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new CowPage());
        }

        private void GoathPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new GoathPage());
        }

        private void ChickenPage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new ChickenPage());
        }

        private void Logout_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void ImgHistory_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new DataPembeliPage());
        }
    }
}