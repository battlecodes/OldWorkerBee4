using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerBee.Models;

namespace WorkerBee.Stores
{
    public class BookStore
    {
        // Backing Fields
        private Book? currentBook;



        public Book? CurrentBook
        {
            get => currentBook;
            set
            {
                currentBook = value;
                OnCurrentBookChanged();
            }
        }



        public event Action? CurrentBookChanged;



        private void OnCurrentBookChanged()
        {
            CurrentBookChanged?.Invoke();
        }
    }
}
