using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CommentRepository : RepositoryBase<Comment> , ICommentRepository
    {
        public CommentRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
