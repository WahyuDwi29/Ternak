using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class HomeController
    {
        private HomeModel _model;
        private HomePage _view;

        public HomeController(HomePage view)
        {
            _view = view;
            _model = new HomeModel();
        }

        public void ShowAllData()
        {
            _view.lblProduk.Content = _model.ShowTotalProduk();
            _view.lblPembeli.Content = _model.ShowTotalPembeli();
            _view.lblJumlahUser.Content = _model.ShowTotalUser();
            _view.lblSapi.Content = _model.ShowTotalProdukCow();
            _view.lblKambing.Content = _model.ShowTotalProdukGoath();
            _view.lblAyam.Content = _model.ShowTotalProdukChicken();
            _view.lblPresensi.Content = "Selamat Datang " + UsersModel.UserName;
        }

        public void dataName()
        {
            var ds = _model.ShowUser();
            _view.dgUser.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}