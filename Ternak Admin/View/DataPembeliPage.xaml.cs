using System;
using System.Windows;
using System.Windows.Controls;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class DataPembeliPage : Page
    {
        private DataPembeliController _controller;

        public DataPembeliPage()
        {
            InitializeComponent();
            _controller = new DataPembeliController(this);
            _controller.DataHistory();
        }
    }
}