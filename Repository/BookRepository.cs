using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    public class BookRepository : RepositoryBase<Book> , IBookRepository
    {
        public BookRepository(RepositoryContext context) : base(context)
        {

        }
        public IEnumerable<Book> GetAllBooks(bool trackChanges) => FindAll(trackChanges).ToList();
    }
}
