using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MemberRepository : RepositoryBase<Member> , IMemberRepository
    {
        public MemberRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
