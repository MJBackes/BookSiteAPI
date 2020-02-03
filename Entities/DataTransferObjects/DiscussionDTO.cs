using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    class DiscussionDTO
    {
        public List<Comment> Comments { get; set; }
        public Discussion Discussion { get; set; }
        public Member Member { get; set; }
        public Book Book { get; set; }
    }
}
