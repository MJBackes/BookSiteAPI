﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class BookDiscussions
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Book")]
        public Guid? BookId { get; set; }
        public Book Book { get; set; }
        [ForeignKey("Discussion")]
        public Guid? DiscussionId { get; set; }
        public Discussion Discussion { get; set; }
    }
}
