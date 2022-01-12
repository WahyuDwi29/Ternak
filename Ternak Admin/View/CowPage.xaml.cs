using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Ternak_Admin.Controller;
using Ternak_Admin.Model;

namespace Ternak_Admin.View
{
    public partial class CowPage : Page
    {
        private ProdukControllerCow _produkControllerCow;

        //private BuyProductController _buyProductController;
        public static string image;
        public static string name;
        public static int price;

        public CowPage()
        {
            _produkControllerCow = new ProdukControllerCow(this);

            InitializeComponent();
            var product = GetProduct();
            if (product.Count > 0)
            {
                ListViewProducts.ItemsSource = product;
            }
        }
        private List<DataProduct> GetProduct()
        {
            return _produkControllerCow.ShowProductCow();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // setData(imgProduk.ImageSource.ToString(), txtNama.Text, Convert.ToInt32(txtHarga.Text));
            var buy = new BuyProductWindow();
            buy.ShowDialog();
        }

        public void setData(string gambar, string nama, int harga)
        {
            gambar = image;
            nama = name;
            harga = price;
        }
    }
}