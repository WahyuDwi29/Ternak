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
            var ds = _model.ShowProduct();
            var dataProducts = new List<DataProduct>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var imageURI = string.Concat(
                    System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                    "\\img\\", Convert.ToString(dr["gambar"]));
                dataProducts.Add(
                    new DataProduct(Convert.ToInt32(dr["id_produk"]), Convert.ToString(dr["nama"]),
                        Convert.ToInt32(dr["harga"]),
                        imageURI));
            }

            return dataProducts;
        }
    }
}