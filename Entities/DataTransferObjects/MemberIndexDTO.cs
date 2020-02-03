using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    class MemberIndexDTO
    {
        public Guid MemberId { get; set; }
        public List<BookClub> Clubs { get; set; }
        public List<Member> Friends { get; set; }
        public List<Book> FriendsBooks { get; set; }
        public List<Book> Recommendations { get; set; }
        public List<Book> AuthorBooks { get; set; }
        public List<Book> SubjectBooks { get; set; }
    }
}
