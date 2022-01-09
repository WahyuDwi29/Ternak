using System;
using System.Windows.Media.Imaging;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class BuyProductController
    {
        private BuyProductModel _model;
        private BuyProductWindow _view;
        private AddPembeliWindow _viewPembeliWindow;

        public BuyProductController(BuyProductWindow view)
        {
            _model = new BuyProductModel();
            _view = view;
        }
        
        public BuyProductController(AddPembeliWindow pembeliWindow)
        {
            _model = new BuyProductModel();
            _viewPembeliWindow = pembeliWindow;
        }

        //     public DataSet ShowData()
        //     {
        //         var ds = _model.ShowData();
        //         return ds;
        //     }

        public void Purchase()
        {
            _model.nama_produk = _view.LblProduct.Content.ToString();
            _model.nama_pembeli = _view.TbName.Text;
            _model.no_telp = _view.TbNomor.Text;
            _model.alamat_pembeli = _view.TbAlamat.Text;
            _model.harga_produk = Convert.ToInt32(_view.TbHarga.Text);
            var metode = "";
            if (_view.RdbCod.IsChecked == true)
            {
                metode = "COD";
            }

            else if (_view.RdbBca.IsChecked == true)
            {
                metode = "BCA";
            }

            else if (_view.RdbBni.IsChecked == true)
            {
                metode = "BNI";
            }

            else if (_view.RdbMandiri.IsChecked == true)
            {
                metode = "MANDIRI";
            }

            _model.metode_pembayaran = metode;

            var result = _model.AddPurchase();
            if (result)
            {
                var confirm = new ConfirmWindow();
                confirm.ShowDialog();
                _view.Close();
            }
            else
            {
                var confirm = new ConfirmWindow();
                confirm.ImgIcon.Source = new BitmapImage(new Uri("/Img/ic_cancel.png", UriKind.Relative));
                confirm.Lbl1.Content = "Maaf Pembelian Gagal :(";
                confirm.Lbl2.Content = "Pastikan anda mengisi data dengan benar";
                confirm.Lbl3.Content = "Jika anda Mengalami kesulitan hubungi kami";
                confirm.ShowDialog();
                _view.Close();
            }
        }

        public void AddPembeli()
        {
            _model.nama_produk = _viewPembeliWindow.TbNameProduct.Text;
            _model.harga_produk = Convert.ToInt32(_viewPembeliWindow.TbHarga.Text);
            _model.nama_pembeli = _viewPembeliWindow.TbNameCustomer.Text;
            _model.no_telp = _viewPembeliWindow.TbNomor.Text;
            _model.alamat_pembeli = _viewPembeliWindow.TbAlamat.Text;
            var metode = "";
            if (_viewPembeliWindow.RdbCod.IsChecked == true)
            {
                metode = "COD";
            }

            else if (_viewPembeliWindow.RdbBca.IsChecked == true)
            {
                metode = "BCA";
            }

            else if (_viewPembeliWindow.RdbBni.IsChecked == true)
            {
                metode = "BNI";
            }

            else if (_viewPembeliWindow.RdbMandiri.IsChecked == true)
            {
                metode = "MANDIRI";
            }

            _model.metode_pembayaran = metode;

            var result = _model.AddPurchase();
            if (result)
            {
                var confirm = new ConfirmWindow();
                confirm.ImgIcon.Source = new BitmapImage(new Uri("/Img/ic_check_circle.png", UriKind.Relative));
                confirm.Lbl1.Content = "Data Berhasil di tambahkan";
                confirm.Lbl2.Content = "";
                confirm.Lbl3.Content = "";
                confirm.Height = 125;
                confirm.Width = 380;
                confirm.ShowDialog();
                _viewPembeliWindow.Close();
            }
            else
            {
                var confirm = new ConfirmWindow();
                confirm.ImgIcon.Source = new BitmapImage(new Uri("/Img/ic_cancel.png", UriKind.Relative));
                confirm.Lbl1.Content = "Data Gagal di tambahkan";
                confirm.Lbl2.Content = "pastikan anda memasukan data dengan lengkap";
                confirm.Lbl3.Content = "";
                confirm.ShowDialog();
            }
        }
    }
}