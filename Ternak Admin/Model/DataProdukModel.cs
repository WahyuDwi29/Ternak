using System.Data;

namespace Ternak_Admin.Model
{
    public class DataProdukModel
    {
        private ModelTemplate _template;

        public int id { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public string jenis { get; set; }


        public DataProdukModel()
        {
            _template = new ModelTemplate();
        }

        public DataSet ShowData()
        {
            return _template.SelectData("produk", "SELECT nama, harga, gambar, jenis FROM produk");
        }

        public bool InsertData()
        {
            var data = "'" + nama + "','" + harga + "','" + gambar + "','" + jenis + "'";
            return _template.Insert("produk", data);
        }
    }
}