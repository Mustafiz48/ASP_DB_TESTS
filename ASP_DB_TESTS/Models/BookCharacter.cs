using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_DB_TESTS.Models
{
    public class BookCharacter
    {
        [Key]
        public int Id { get; set; }

        public string CharacterName { get; set; }

        public int BookId { get; set; }
        public Book book { get; set; }

    }
}
