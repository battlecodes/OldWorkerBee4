using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerBee.ViewModels;

namespace WorkerBee.Stores
{
    public class NavigationStore
    {
        // Backing Fields
        private ViewModelBase? currentMainViewModel;



        public ViewModelBase? CurrentMainViewModel
        {
            get => currentMainViewModel;
            set
            {
                currentMainViewModel = value;
                OnCurrentMainViewModelChanged();
            }
        }



        public event Action? CurrentMainViewModelChanged;



        public void OnCurrentMainViewModelChanged()
        {
            CurrentMainViewModelChanged?.Invoke();
        }
    }
}
