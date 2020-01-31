using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ClubMembersRepository : RepositoryBase<ClubMembers> , IClubMembersRepository
    {
        public ClubMembersRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
