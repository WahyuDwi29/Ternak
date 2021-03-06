using System;
using System.Windows;
using System.Windows.Controls;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class DataProdukPage : Page
    {
        private DataProdukController _controller;
        
        public static string nama_produk;
        public static int harga_produk;
        public static string jenis;
        public static string gambar;

        public DataProdukPage()
        {
            InitializeComponent();
            _controller = new DataProdukController(this);
            _controller.ShowDataProduk();
        }

        private void F2_UpdateEventHandler(object sender, AddProductWindow.UpdateEventArgs args)
        {
            _controller.ShowDataProduk();
        }

        private void BtnTambah_OnClick(object sender, RoutedEventArgs e)
        {
            var add = new AddProductWindow();
            add.UpdateEventHandler += F2_UpdateEventHandler;
            add.ShowDialog();
        }

        private void DgProduk_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = DgProduk.SelectedItem;
            ChangeProductWindow.nama_produk = (DgProduk.SelectedCells[0].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.harga_produk = Convert.ToInt32((DgProduk.SelectedCells[1].Column.GetCellContent(item) as TextBlock)?.Text);
            ChangeProductWindow.gambar = (DgProduk.SelectedCells[2].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeProductWindow.jenis = (DgProduk.SelectedCells[3].Column.GetCellContent(item) as TextBlock)?.Text;
            
        }

        private void BtnUbah_OnClick(object sender, RoutedEventArgs e)
        {
            var change = new ChangeProductWindow();
            change.ShowDialog();
        }
        
        private void SetStaticVar()
    }
}