using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BookClubRepository : RepositoryBase<BookClub> , IBookClubRepository
    {
        public BookClubRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
