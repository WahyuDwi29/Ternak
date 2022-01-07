﻿using System.Data;

namespace Ternak_Admin.Model
{
    public class ProdukModelCow
    {
        private ModelTemplate _template;
        
        public int id { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public string jenis { get; set; }

        public ProdukModelCow()
        {
            _template = new ModelTemplate();
        }

        public DataSet ShowProduct()
        {
            return _template.Select("produk", "jenis='Sapi'");
        }
        
    }
}