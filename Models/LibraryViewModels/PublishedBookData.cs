using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryModel.Models.LibraryViewModels
{
    public class PublishedBookData
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }
    }
}
