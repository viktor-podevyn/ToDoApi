using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Properties.Models
{
    public class Artist
    {

        public int Id { get; set; }

        public string Name { get; set; }
        
        public int Age { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Song { get; set; }

    }
}