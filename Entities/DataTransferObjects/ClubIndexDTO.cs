using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    class ClubIndexDTO
    {
        public BookClub Club { get; set; }
        public List<Discussion> Discussions { get; set; }
        public List<Member> Members { get; set; }
        public bool IsManager { get; set; }
        public List<Book> Books { get; set; }
    }
}
