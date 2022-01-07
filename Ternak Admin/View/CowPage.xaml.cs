using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using Ternak_Admin.Controller;
using Ternak_Admin.Model;

namespace Ternak_Admin.View
{
    public partial class CowPage : Page
    {
        private ProdukControllerCow _produkControllerCow;
        //private BuyProductController _buyProductController;

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
            var buy = new BuyProductWindow();
            buy.ShowDialog();
        }

        private void ListViewProducts_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}