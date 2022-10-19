using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using WorkerBee.Stores;

namespace WorkerBee.ViewModels
{
    public class LayoutViewModel : ViewModelBase
    {

        private readonly LayoutNavigationStore _layoutNavigationStore;



        public ViewModelBase? ContentViewModel =>
            _layoutNavigationStore.CurrentContentViewModel;



        public LayoutViewModel(LayoutNavigationStore layoutNavigationStore)
        {
            _layoutNavigationStore = layoutNavigationStore;

            _layoutNavigationStore.CurrentContentViewModelChanged +=
                OnContentViewModelChanged;
        }



        private void OnContentViewModelChanged()
        {
            OnPropertyChanged(nameof(ContentViewModel));
        }
    }
}
