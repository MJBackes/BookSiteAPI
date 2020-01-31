using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class AuthorRepository : RepositoryBase<Author> , IAuthorRepository
    {
        public AuthorRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
