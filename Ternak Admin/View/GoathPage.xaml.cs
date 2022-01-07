using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using Ternak_Admin.Controller;
using Ternak_Admin.Model;

namespace Ternak_Admin.View
{
    public partial class GoathPage : Page
    {
        private ProdukControllerGoath _controller;
        public GoathPage()
        {
            _controller = new ProdukControllerGoath(this);
            InitializeComponent();
            var product = GetProduct();
            if (product.Count > 0)
            {
                ListViewProducts.ItemsSource = product;
            }
        }

        private List<DataProduct> GetProduct()
        {
            return _controller.ShowProductGoath();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var buy = new BuyProductWindow();
            buy.ShowDialog();
        }
    }
}