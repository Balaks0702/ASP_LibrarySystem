using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F20_BookClub.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        [Required]
        [Display(Name ="Author Name")]
        public string AuthorName { get; set; }
        public string Country { get; set; }
        public string Publisher { get; set; }

        public List<Book> Books { get; set; }
    }
}
