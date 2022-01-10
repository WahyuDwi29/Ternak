using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Ternak_Admin.View
{
    public partial class ChangeProductWindow : Window
    {
        public ChangeProductWindow()
        {
            InitializeComponent();

            TbNameProduk.Text = nama_produk;
            TbHarga.Text = harga_produk.ToString();
            if (jenis == "Sapi")
            {
                RdbSapi.IsChecked = true;
            }

            else if (jenis == "Kambing")
            {
                RdbKambing.IsChecked = true;
            }

            else
            {
                RdbAyam.IsChecked = true;
            }

            var path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                       "\\img\\" + gambar;
            var bitMap = new BitmapImage();
            bitMap.BeginInit();
            bitMap.UriSource = new Uri(path);
            bitMap.EndInit();
            Image.Source = bitMap;
        }
    }
}