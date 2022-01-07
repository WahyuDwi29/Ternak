using System.Windows;
using System.Windows.Controls;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class DataProdukPage : Page
    {
        private DataProdukController _controller;

        public DataProdukPage()
        {
            InitializeComponent();
            _controller = new DataProdukController(this);
            _controller.ShowDataProduk();
        }

        private void BtnTambah_OnClick(object sender, RoutedEventArgs e)
        {
            var add = new AddProductWindow();
            add.ShowDialog();
        }
    }
}