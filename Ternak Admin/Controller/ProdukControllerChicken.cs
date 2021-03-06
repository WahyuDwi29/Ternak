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
        private HomePage _home;

        public ProdukControllerChicken(ChickenPage chickenPage)
        {
            _model = new ProdukModelChicken();
            _view = chickenPage;
        }

        public ProdukControllerChicken(HomePage home)
        {
            _model = new ProdukModelChicken();
            _home = home;
        }

        public List<DataProduct> ShowProductChicken()
        {
            var ds = _model.ShowProduct();
            var dataProducts = new List<DataProduct>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var imageUri =
                    string.Concat(
                        System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                        "\\img\\",
                        Convert.ToString(dr["gambar"]));
                dataProducts.Add(
                    new DataProduct(Convert.ToInt32(dr["id_produk"]), Convert.ToString(dr["nama"]),
                        Convert.ToInt32(dr["harga"]),
                        imageUri));
            }

            return dataProducts;
        }
    }
}