using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class FriendListRepository : RepositoryBase<FriendList> , IFriendListRepository
    {
        public FriendListRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
