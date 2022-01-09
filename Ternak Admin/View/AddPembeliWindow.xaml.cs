using System;
using System.Windows;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class AddPembeliWindow : Window
    {
        private BuyProductController _controller;

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);

        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }

        public AddPembeliWindow()
        {
            InitializeComponent();
            _controller = new BuyProductController(this);
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            _controller.AddPembeli();
            var args = new UpdateEventArgs();
            UpdateEventHandler!.Invoke(this, args);
        }
    }
}