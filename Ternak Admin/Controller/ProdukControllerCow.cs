using System;
using System.Collections.Generic;
using System.Data;
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
            var ds = _model.ShowProduct();
            var goathProducts = new List<DataProduct>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var imageUri = String.Concat(
                    System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                    "\\img\\", Convert.ToString(dr["gambar"]));
                goathProducts.Add(
                    new DataProduct(Convert.ToInt32(dr["id_produk"]), Convert.ToString(dr["nama"]),
                        Convert.ToInt32(dr["harga"]),
                        imageUri));
            }

            return goathProducts;
        }
    }
}