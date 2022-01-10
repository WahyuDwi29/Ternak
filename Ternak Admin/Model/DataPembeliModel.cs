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

            ds = _template.Select("pembelian", null);

            return ds;
        }

        public bool UpdateData()
        {
            var data = $"nama_pembeli ={nama_pembeli}, alamat_pembeli = {alamat_pembeli}, nama_produk = {nama_produk}, harga_produk = {harga_produk}, no_telp = {no_telp}, metode_pembayaran = {metode_pembayaran}";
            return _template.Update("produk", data, $"id_pembelian = {id_pembelian}");
        }
    }
}