using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class MainWindow : Window
    {
        private DataPembeliController _pembeliController;

        public MainWindow()
        {
            InitializeComponent();
            _pembeliController = new DataPembeliController(new DataPembeliPage());
        }

        private void HomePage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new HomePage());
        }

        private void DataPembeli_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new DataPembeliPage());
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

        private void DataProduk_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrmMain.Navigate(new DataProdukPage());
        }

        private void Logout_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }
    }
}