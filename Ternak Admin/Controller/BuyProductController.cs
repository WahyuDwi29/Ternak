﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class BuyProductController
    {
        private BuyProductModel _model;
        private BuyProductWindow _view;

        public BuyProductController(BuyProductWindow view)
        {
            _view = view;
            _model = new BuyProductModel();
        }

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


            if (MessageBox.Show("Apakah anda yakin membeli produk?", "Konfirmasi", MessageBoxButton.YesNo,
                    MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
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
        }
    }
}