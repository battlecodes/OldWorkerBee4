using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerBee.Stores;

namespace WorkerBee.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private readonly NavigationStore _navigationStore;



        public ViewModelBase? CurrentMainViewModel =>
            _navigationStore.CurrentMainViewModel;



        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentMainViewModelChanged +=
                OnCurrentMainViewModelChanged;
        }



        private void OnCurrentMainViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentMainViewModel));
        }
    }
}
