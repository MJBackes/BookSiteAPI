using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ReviewRepository : RepositoryBase<Review> , IReviewRepository
    {
        public ReviewRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
