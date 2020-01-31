using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class DiscussionRepository : RepositoryBase<Discussion> , IDiscussionRepository
    {
        public DiscussionRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
