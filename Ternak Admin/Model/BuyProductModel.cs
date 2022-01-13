namespace Ternak_Admin.Model
{
    public class BuyProductModel
    {
        private ModelTemplate _template;

        public int id_pembelian { get; set; }
        public string nama_pembeli { get; set; }
        public string alamat_pembeli { get; set; }
        public string nama_produk { get; set; }
        public int harga_produk { get; set; }
        public string metode_pembayaran { get; set; }
        public string no_telp { get; set; }
        
        public BuyProductModel()
        {
            _template = new ModelTemplate();
        }

        public bool AddPurchase()
        {
            var data = "'" + nama_pembeli + "','" + alamat_pembeli + "','" + nama_produk + "','" + harga_produk +
                       "','" + no_telp + "','" + metode_pembayaran + "'";

            return _template.Insert("pembelian", data);
        }
    }
}