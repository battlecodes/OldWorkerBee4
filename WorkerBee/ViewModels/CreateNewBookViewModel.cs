using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkerBee.Commands;
using WorkerBee.Models;
using WorkerBee.Stores;

namespace WorkerBee.ViewModels
{
    public class CreateNewBookViewModel : ViewModelBase
    {

        private readonly BookStore _bookStore;



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



        public CreateNewBookViewModel(BookStore bookStore)
        {
            _bookStore = bookStore;

            CreateNewBookClickedCommand = new RelayCommand(
                new Action<object>(CreateNewBook));
        }



        private void CreateNewBook(object obj)
        {
            // Create a new book model.
            Book newBook = new Book()
            {
                Name = NewBookName,
            };


            // Validate the model's details
            // Save the Book
            // Set as the book store's current book.
        }
    }
}
