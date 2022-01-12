using Ternak_Admin.Model;
using Ternak_Admin.View;

namespace Ternak_Admin.Controller
{
    public class HistoryController
    {
        private HistoryModel _model;
        private HistoryPage _view;

        public HistoryController(HistoryPage view)
        {
            _model = new HistoryModel();
            _view = view;
        }

        public void DataHistory()
        {
            var ds = _model.ShowHistory();
            _view.DgPembelian.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}