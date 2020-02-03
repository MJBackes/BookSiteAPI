using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    class BookDetailsDTO
    {
        public Book Book { get; set; }
        public List<Book> RelatedBooks { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
