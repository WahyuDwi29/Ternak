using System;
using System.Windows;
using System.Windows.Controls;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class HomePage : Page
    {
        private readonly HomeController _controller;

        public HomePage()
        {
            InitializeComponent();
            _controller = new HomeController(this);
            _controller.ShowAllData();
            _controller.dataName();
        }
    }
}