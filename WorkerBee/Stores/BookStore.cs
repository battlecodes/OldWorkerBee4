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



        public int IdIndexer = 1;



        public event Action? CurrentBookChanged;



        public int AssignId()
        {
            return IdIndexer++;
        }



        private void OnCurrentBookChanged()
        {
            CurrentBookChanged?.Invoke();
        }
    }
}
