using System;
using System.Collections.Generic;
using System.Data;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class ProdukControllerChicken
    {
        private ProdukModelChicken _model;
        private ChickenPage _view;

        public ProdukControllerChicken(ChickenPage chickenPage)
        {
            _model = new ProdukModelChicken();
            _view = chickenPage;
        }

        public List<DataProduct> ShowProductChicken()
        {
            return _model.ShowProduct();
        }
    }
}