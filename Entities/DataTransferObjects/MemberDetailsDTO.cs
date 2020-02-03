using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    class MemberDetailsDTO
    {
        public Member Member { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Book> Books { get; set; }
        public bool isFriend { get; set; }
    }
}
