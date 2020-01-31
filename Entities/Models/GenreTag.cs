using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class GenreTag
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
