using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avram_Maria_Lab2.Models.LibraryViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publishers> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
