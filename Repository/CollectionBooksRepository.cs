using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CollectionBooksRepository : RepositoryBase<CollectionBooks> , ICollectionBooksRepository
    {
        public CollectionBooksRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
