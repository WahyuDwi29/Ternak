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
            ChangeHistoryWindow.nama_pembeli =
                (DgPembelian.SelectedCells[0].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeHistoryWindow.no_telp = (DgPembelian.SelectedCells[1].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeHistoryWindow.alamat_pembeli =
                (DgPembelian.SelectedCells[2].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeHistoryWindow.nama_produk =
                (DgPembelian.SelectedCells[3].Column.GetCellContent(item) as TextBlock)?.Text;
            ChangeHistoryWindow.harga_produk =
                Convert.ToInt32((DgPembelian.SelectedCells[4].Column.GetCellContent(item) as TextBlock)?.Text);
        }

        private void BtnUbah_OnClick(object sender, RoutedEventArgs e)
        {
            var ubah = new ChangeHistoryWindow();
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