using System;
using System.Windows;
using System.Windows.Controls;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class DataPembeliPage : Page
    {
        private DataPembeliController _controller;

        public DataPembeliPage()
        {
            InitializeComponent();
            _controller = new DataPembeliController(this);
            _controller.DataHistory();
        }

        private void DgHistory_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = DgPembelian.SelectedItem;
            ChangeDataPembeliWindow.nama_pembeli =
                (DgPembelian.SelectedCells[0].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeDataPembeliWindow.no_telp =
                (DgPembelian.SelectedCells[1].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeDataPembeliWindow.alamat_pembeli =
                (DgPembelian.SelectedCells[2].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeDataPembeliWindow.nama_produk =
                (DgPembelian.SelectedCells[3].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeDataPembeliWindow.harga_produk =
                Convert.ToInt32((DgPembelian.SelectedCells[4].Column.GetCellContent(item) as TextBlock)?.Text);
            ChangeDataPembeliWindow.metode_pembayaran =
                (DgPembelian.SelectedCells[5].Column.GetCellContent(item) as TextBlock)?.Text;
        }

        private void BtnUbah_OnClick(object sender, RoutedEventArgs e)
        {
            var ubah = new ChangeDataPembeliWindow();
            ubah.ShowDialog();
        }

        private void BtnHapus_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void BtnTambah_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}