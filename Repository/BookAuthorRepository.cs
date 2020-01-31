using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BookAuthorRepository : RepositoryBase<BookAuthor> , IBookAuthorRepository
    {
        public BookAuthorRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
