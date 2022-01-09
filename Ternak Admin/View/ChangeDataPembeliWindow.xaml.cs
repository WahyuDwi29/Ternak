using System.Windows;

namespace Ternak_Admin.View
{
    public partial class ChangeDataPembeliWindow : Window
    {
        public static string nama_pembeli;
        public static string no_telp;
        public static string alamat_pembeli;
        public static string nama_produk;
        public static int harga_produk;
        public static string metode_pembayaran;

        public ChangeDataPembeliWindow()
        {
            InitializeComponent();
            TbNameCustomer.Text = nama_pembeli;
            TbNomor.Text = no_telp;
            TbAlamat.Text = alamat_pembeli;
            TbNameProduct.Text = nama_produk;
            TbHarga.Text = harga_produk.ToString();
            if (metode_pembayaran == "COD")
            {
                RdbCod.IsChecked = true;
            }
            
            if (metode_pembayaran == "BCA")
            {
                RdbBca.IsChecked = true;
            }
            
            if (metode_pembayaran == "BNI")
            {
                RdbBni.IsChecked = true;
            }
            
            if (metode_pembayaran == "MANDIRI")
            {
                RdbMandiri.IsChecked = true;
            }
        }

        private void Btncancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnChange_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}