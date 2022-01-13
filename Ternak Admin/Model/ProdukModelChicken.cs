using System;
using System.Collections.Generic;
using System.Data;
using Ternak_Admin.View;

namespace Ternak_Admin.Model
{
    public class ProdukModelChicken
    {
        private ModelTemplate _template;

        public int id { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public string jenis { get; set; }

        public ProdukModelChicken()
        {
            _template = new ModelTemplate();
        }

        public DataSet Show()
        {
            return _template.Select("produk", "jenis='Ayam'");
        }
        
        public List<DataProduct> ShowProduct()
        {
            var ds = Show();
            var dataProducts = new List<DataProduct>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var imageUri =
                    string.Concat(
                        System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent
                            .FullName +
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