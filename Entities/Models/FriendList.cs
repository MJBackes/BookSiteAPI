using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class FriendList
    {
        [Key]
        [ForeignKey("Member")]
        public Guid Id { get; set; }
        public Member Member { get; set; }
    }
}
