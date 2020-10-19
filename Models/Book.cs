using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F20_BookClub.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Display(Name ="Book No.")]
        public int BookNo { get; set; }
        [Display(Name ="Series")]
        public string BookSeries { get; set; }
        [Display(Name ="Author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
