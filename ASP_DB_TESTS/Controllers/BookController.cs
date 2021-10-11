using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_DB_TESTS.Data;
using ASP_DB_TESTS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_DB_TESTS.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Book> objList = _db.Books; 

            return View(objList);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
            return RedirectToAction("Books");
        }

        public IActionResult BookCharacter()
        {
            IList<BookCharacter> charater = _db.BookCharacters.Include( x=> x.book).ToList();

            return View(charater);
        }

        public IActionResult AddCharacters()
        {
            IList<Book> books = _db.Books.ToList();

            ViewBag.booklist = books;
            return View();
        }

        [HttpPost]
        public IActionResult AddCharacters( BookCharacter character)
        {
            Book newbook;
            try
            {
                newbook = _db.Books.Single(x => x.Id == character.BookId);
            }

            catch
            {
                return NotFound("Given BookId Not Found!");
            }


            BookCharacter newcharacter = new BookCharacter
            {
                CharacterName = character.CharacterName,
                BookId = character.BookId,
                book = newbook,

            };
                
                    
            _db.BookCharacters.Add(newcharacter);
            _db.SaveChanges();
            return RedirectToAction("BookCharacter");
        }
        
        public IActionResult CharacterOfBook(int id)
        {

            Book book = _db.Books.Include(x => x.character).Single( x => x.Id == id);

            return View(book);
        }


    }
}
