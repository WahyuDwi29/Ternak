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
            var ds = _model.ShowProduct();
            var dataProducts = new List<DataProduct>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var imageUri =
                    string.Concat(
                        @"D:\DATA\Project C#\Final Project Pemrograman Lanjut\Final Project Pemrograman Lanjut\img\",
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