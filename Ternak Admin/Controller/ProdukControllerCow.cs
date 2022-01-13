using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;
using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class ProdukControllerCow
    {
        private ProdukModelCow _model;
        private CowPage _view;

        public ProdukControllerCow(CowPage cowPage)
        {
            _model = new ProdukModelCow();
            _view = cowPage;
        }

        public List<DataProduct> ShowProductCow()
        {
            return _model.ShowProduct();
        }
    }
}