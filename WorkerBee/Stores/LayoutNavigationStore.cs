using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerBee.ViewModels;

namespace WorkerBee.Stores
{
    public class LayoutNavigationStore
    {
        // Backing Fields
        private ViewModelBase? currentContentViewModel;



        public ViewModelBase? CurrentContentViewModel
        {
            get => currentContentViewModel;
            set
            {
                currentContentViewModel = value;
                OnCurrentContentViewModelChanged();
            }
        }



        public event Action? CurrentContentViewModelChanged;



        private void OnCurrentContentViewModelChanged()
        {
            CurrentContentViewModelChanged?.Invoke();
        }
    }
}
