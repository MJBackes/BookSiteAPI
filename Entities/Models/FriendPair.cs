using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class FriendPair
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("List")]
        public Guid ListId { get; set; }
        public FriendList List { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Friend")]
        public Guid FriendId { get; set; }
        public Member Friend { get; set; }
    }
}
