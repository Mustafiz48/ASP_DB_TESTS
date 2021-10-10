using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_DB_TESTS.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public IList<BookCharacter> character { get; set; }

    }
}
