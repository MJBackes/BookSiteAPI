﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class CollectionBooks
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Collection")]
        public Guid CollectionId { get; set; }
        public Collection Collection { get; set; }
        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
