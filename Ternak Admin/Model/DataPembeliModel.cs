using System.Data;

namespace Ternak_Admin.Model
{
    public class DataPembeliModel
    {
        private ModelTemplate _template;

        public int id_pembelian { get; set; }
        public string nama_pembeli { get; set; }
        public string alamat_pembeli { get; set; }
        public string nama_produk { get; set; }
        public int harga_produk { get; set; }
        public string no_telp { get; set; }
        public string metode_pembayaran { get; set; }

        public DataPembeliModel()
        {
            _template = new ModelTemplate();
        }

        public DataSet ShowPembeli()
        {
            var ds = new DataSet();
           
            ds = _template.SelectData("pembelian",
                "SELECT nama_pembeli, no_telp, alamat_pembeli, nama_produk, harga_produk, metode_pembayaran FROM pembelian");

            return ds;
        }
    }
}