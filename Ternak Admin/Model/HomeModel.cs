using System.Data;

namespace Ternak_Admin.Model
{
    public class HomeModel
    {
        private ModelTemplate _template;

        public HomeModel()
        {
            _template = new ModelTemplate();
        }

        public string ShowTotalProduk()
        {
            var result = "0";
            var ds = new DataSet();
            ds = _template.SelectData("produk", "SELECT count(*) FROM produk");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }
        
        public string ShowTotalPembeli()
        {
            var result = "0";
            var ds = new DataSet();
            ds = _template.SelectData("pembelian", "SELECT count(*) FROM pembelian");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }
        
        public string ShowTotalUser()
        {
            var result = "0";
            var ds = new DataSet();
            ds = _template.SelectData("users", "SELECT count(*) FROM users");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public string ShowTotalProdukCow()
        {
            var result = "0";
            DataSet ds;
            ds = _template.SelectData("produk", "SELECT count(*) FROM produk WHERE jenis = 'Sapi' ");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public string ShowTotalProdukGoath()
        {
            var result = "0";
            DataSet ds;
            ds = _template.SelectData("produk", "SELECT count(*) FROM produk WHERE jenis = 'Kambing' ");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public string ShowTotalProdukChicken()
        {
            var result = "0";
            DataSet ds;
            ds = _template.SelectData("produk", "SELECT count(*) FROM produk WHERE jenis = 'Ayam' ");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public DataSet ShowUser()
        {
            var ds = _template.SelectData("users", "SELECT name FROM users");
            return ds;
        }
    }
}