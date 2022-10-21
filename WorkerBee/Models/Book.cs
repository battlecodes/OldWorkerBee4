using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerBee.Models
{
    public class Book
    {

        public int Id { get; private set; }


        public string Name { get; set; } = string.Empty;



        public void AssignId(int id)
        {
            Id = id;
        }
    }
}
