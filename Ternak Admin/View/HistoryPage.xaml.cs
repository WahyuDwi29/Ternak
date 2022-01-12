using System;
using System.Windows;
using System.Windows.Controls;
using Ternak_Admin.Controller;

namespace Ternak_Admin.View
{
    public partial class HistoryPage : Page
    {
        private HistoryController _controller;

        public HistoryPage()
        {
            InitializeComponent();
            _controller = new HistoryController(this);
            _controller.DataHistory();
        }
    }
}