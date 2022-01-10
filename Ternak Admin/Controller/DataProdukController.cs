using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class DataProdukController
    {
        private DataProdukModel _model;
        private DataProdukPage _view;
        private AddProductWindow _viewAddProduct;
        private ChangeProductWindow _viewChangeProduct;

        public DataProdukController(DataProdukPage view)
        {
            _model = new DataProdukModel();
            _view = view;
        }

        public DataProdukController(AddProductWindow viewAddProduct)
        {
            _model = new DataProdukModel();
            _viewAddProduct = viewAddProduct;
        }
        
        public DataProdukController(ChangeProductWindow change)
        {
            _model = new DataProdukModel();
            _viewChangeProduct = change;
        }

        public void ShowDataProduk()
        {
            var ds = _model.ShowData();
            _view.DgProduk.ItemsSource = ds.Tables[0].DefaultView;
        }

        // add data 
        public void InsertData()
        {
            _model.nama = _viewAddProduct.TbNameProduk.Text;
            _model.harga = Convert.ToInt32(_viewAddProduct.TbHarga.Text);
            _model.gambar = _viewAddProduct.TbNameProduk.Text + ".jpg";
            var jenis = "";
            if (_viewAddProduct.RdbSapi.IsChecked == true)
            {
                jenis = "sapi";
            }
            else if (_viewAddProduct.RdbKambing.IsChecked == true)
            {
                jenis = "kambing";
            }
            else
            {
                jenis = "ayam";
            }

            _model.jenis = jenis;
            var result = _model.InsertData();
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
                _viewAddProduct.Close();
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

        // updata data
        public void Update()
        {
            _model.nama = _viewChangeProduct.TbNameProduk.Text;
            _model.harga = Convert.ToInt32(_viewChangeProduct.TbHarga.Text);
            _model.gambar = _viewChangeProduct.TbNameProduk.Text + ".jpg";
            var jenis = "";
            if (_viewChangeProduct.RdbSapi.IsChecked == true)
            {
                jenis = "sapi";
            }
            else if (_viewChangeProduct.RdbKambing.IsChecked == true)
            {
                jenis = "kambing";
            }
            else
            {
                jenis = "ayam";
            }

            _model.jenis = jenis;
            var result = _model.InsertData();
            if (result)
            {
                var confirm = new ConfirmWindow();
                confirm.ImgIcon.Source = new BitmapImage(new Uri("/Img/ic_check_circle.png", UriKind.Relative));
                confirm.Lbl1.Content = "Data Berhasil Di Ubah";
                confirm.Lbl2.Content = "";
                confirm.Lbl3.Content = "";
                confirm.Height = 125;
                confirm.Width = 380;
                confirm.ShowDialog();
                _viewAddProduct.Close();
            }
            else
            {
                var confirm = new ConfirmWindow();
                confirm.ImgIcon.Source = new BitmapImage(new Uri("/Img/ic_cancel.png", UriKind.Relative));
                confirm.Lbl1.Content = "Data Gagal Di Ubah";
                confirm.Lbl2.Content = "pastikan anda memasukan data dengan lengkap";
                confirm.Lbl3.Content = "";
                confirm.ShowDialog();
            }
        }
    }
}