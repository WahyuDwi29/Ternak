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
            // if (search == "")
            // {
            //     ds = _template.SelectData("pembelian",
            //         "SELECT nama_pembeli, no_telp, alamat_pembeli, nama_produk, harga_produk FROM pembelian");
            // }
            // else
            // {
            //     ds = _template.SelectData("pembelian",
            //         $"SELECT * FROM pembelian WHERE nama_pembeli like '%' = {nama_pembeli} or alamat_pembeli like '%' = {alamat_pembeli} or nama_produk like '%' = {nama_produk} or harga_produk like '%' = {harga_produk} or no_telp like '%' = {no_telp} or metode_pembayaran like '%' = {metode_pembayaran}");
            // }
            ds = _template.SelectData("pembelian",
                "SELECT nama_pembeli, no_telp, alamat_pembeli, nama_produk, harga_produk FROM pembelian");

            return ds;
        }
    }
}