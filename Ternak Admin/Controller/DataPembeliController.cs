using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class DataPembeliController
    {
        private DataPembeliModel _model;
        private DataPembeliPage _view;
        private MainWindow _main;

        public DataPembeliController(DataPembeliPage view)
        {
            _model = new DataPembeliModel();
            _view = view;
        }

        public DataPembeliController(MainWindow main)
        {
            _model = new DataPembeliModel();
            _main = main;
        }


        public void DataHistory()
        {
            
            var ds = _model.ShowPembeli();
            _view.DgPembelian.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}