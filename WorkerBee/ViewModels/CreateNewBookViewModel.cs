using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkerBee.Commands;
using WorkerBee.Models;

namespace WorkerBee.ViewModels
{
    public class CreateNewBookViewModel : ViewModelBase
    {

        // Backing Fields
        private string newBookName = string.Empty;



        public string NewBookName
        {
            get => newBookName;
            set
            {
                newBookName = value;
                OnPropertyChanged(nameof(NewBookName));
            }
        }



        public ICommand CreateNewBookClickedCommand { get; }



        public CreateNewBookViewModel()
        {
            CreateNewBookClickedCommand = new RelayCommand(
                new Action<object>(CreateNewBook));
        }



        private void CreateNewBook(object obj)
        {
            // Create a new book model and validate the 
            Book newBook = new Book()
            {
                Name = NewBookName,
            };

        }
    }
}
