using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Final_Project_Pemrograman_Lanjut.controller;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class BuyProductWindow : Window
    {
        private BuyProductController _controller;
        public static string Product;
        public static string Image;

        public BuyProductWindow()
        {
            InitializeComponent();
            _controller = new BuyProductController(this);
            LblProduct.Content = Product;
            
            var path = "/img/" + Image;
            var uri = new Uri(path, UriKind.Relative);
            ImgProduct.Source = new BitmapImage(uri);
        }


        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        

        private void BtnBuy_OnClick(object sender, RoutedEventArgs e)
        {
            _controller.Purchase();
        }
    }
}