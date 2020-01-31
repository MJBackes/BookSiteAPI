using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BookDiscussionRepository : RepositoryBase<BookDiscussions> , IBookDiscussionRepository
    {
        public BookDiscussionRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
