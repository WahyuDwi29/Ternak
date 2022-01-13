using System;
using System.Collections.Generic;
using System.Data;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class ProdukControllerGoath
    {
        private ProdukModelGoath _model;
        private GoathPage _view;

        public ProdukControllerGoath(GoathPage goathPage)
        {
            _model = new ProdukModelGoath();
            _view = goathPage;
        }

        public List<DataProduct> ShowProductGoath()
        {
            return _model.ShowProductGoath();
        }
    }
}