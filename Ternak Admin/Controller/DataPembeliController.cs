using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class DataPembeliController
    {
        private DataPembeliModel _model;
        private DataPembeliPage _view;

        public DataPembeliController(DataPembeliPage view)
        {
            _model = new DataPembeliModel();
            _view = view;
        }

        public void DataHistory()
        {
            var ds = _model.ShowHistory();
            _view.DgPembelian.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}