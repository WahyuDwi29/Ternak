using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Final_Project_Pemrograman_Lanjut.controller;
using Microsoft.Win32;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class AddProductWindow : Window
    {
        private DataProdukController _controller;
        private Microsoft.Win32.OpenFileDialog _openFileDialog;

        public AddProductWindow()
        {
            InitializeComponent();
            _controller = new DataProdukController(this);
            _openFileDialog = new OpenFileDialog();
        }

        private void BtnBrowse_OnClick(object sender, RoutedEventArgs e)
        {
            _openFileDialog.Filter = "Image File (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (_openFileDialog.ShowDialog() == true)
            {
                string selectedName = _openFileDialog.FileName;
                BitmapImage bitMap = new BitmapImage();
                bitMap.BeginInit();
                bitMap.UriSource = new Uri(selectedName);
                bitMap.EndInit();
                Image.Source = bitMap;
            }
        }

        private void BtnSimpan_OnClick(object sender, RoutedEventArgs e)
        {
            // copy image to directory /foto
            string fileName = TbNameProduk.Text + ".jpg";
            var path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                       "\\img\\" + fileName;
            System.IO.File.Copy(_openFileDialog.FileName, path, true);


            //insert
            _controller.InsertData();
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}