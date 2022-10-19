using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using WorkerBee.Models;
using WorkerBee.Stores;

namespace WorkerBee.ViewModels
{
    public class LayoutViewModel : ViewModelBase
    {

        private readonly BookStore _bookStore;


        private readonly LayoutNavigationStore _layoutNavigationStore;



        public ViewModelBase? ContentViewModel =>
            _layoutNavigationStore.CurrentContentViewModel;


        public Book? CurrentBook =>
            _bookStore.CurrentBook;


        public string CurrentBookName =>
            CurrentBook == null ? "No Active Book" : CurrentBook.Name;



        public LayoutViewModel(LayoutNavigationStore layoutNavigationStore,
            BookStore bookStore)
        {
            _bookStore = bookStore;
            _layoutNavigationStore = layoutNavigationStore;

            _bookStore.CurrentBookChanged += OnCurrentBookChanged;
            _layoutNavigationStore.CurrentContentViewModelChanged +=
                OnContentViewModelChanged;
        }



        private void OnContentViewModelChanged()
        {
            OnPropertyChanged(nameof(ContentViewModel));
        }


        private void OnCurrentBookChanged()
        {
            OnPropertyChanged(nameof(CurrentBook));
            OnPropertyChanged(nameof(CurrentBookName));
        }
    }
}
