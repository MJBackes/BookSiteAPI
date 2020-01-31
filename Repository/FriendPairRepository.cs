using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class FriendPairRepository : RepositoryBase<FriendPair> , IFriendPairRepository
    {
        public FriendPairRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
