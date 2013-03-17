using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Game
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string Studio { get; set; }

        [Required]
        public string Rating { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}