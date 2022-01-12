using System.Data;

namespace Ternak_Admin.Model
{
    public class HistoryModel
    {
        private ModelTemplate _template;

        public int id_pembelian { get; set; }
        public string nama_pembeli { get; set; }
        public string alamat_pembeli { get; set; }

        public HistoryModel()
        {
            _template = new ModelTemplate();
        }

        public DataSet ShowHistory()
        {
            var ds = _template.SelectData("pembelian",
                "SELECT nama_pembeli, no_telp, alamat_pembeli, nama_produk, harga_produk, metode_pembayaran FROM pembelian");
            return ds;
        }
    }
}