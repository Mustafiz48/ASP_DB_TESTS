using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_DB_TESTS.Models;

namespace ASP_DB_TESTS.ViewModels
{
    public class AddCharacterViewModel
    {

        public string CharacterName { get; set; }

        public int BookId { get; set; }
        public IEnumerable<Book> book { get; set; }
    }
}
