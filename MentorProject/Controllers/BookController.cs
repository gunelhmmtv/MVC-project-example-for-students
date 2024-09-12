using MentorProject.Contexts;
using MentorProject.Models;
using MentorProject.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace MentorProject.Controllers
{
    public class BookController : Controller
    {
        private readonly BookTechDbContext _context;
        public BookController()
        {
            _context = new BookTechDbContext();
        }
        public async Task<IActionResult> Index()
        {
          var books =  await  _context.Books
               
                .Select(x=> new BookModel
                {
                    Id = x.Id,
                    BookName = x.BookName,
                    Price = x.Price,
                    InStock = x.InStock
                })
                .ToListAsync();
            return View(books);
        }

        [HttpGet]
        public async Task<IActionResult> AddBook()
        {
            Book book = new();
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return View(book);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return RedirectToAction("Index", "Book");
            }

            var bookModel = new Book()
            {
               BookName = book.BookName,
               Price = book.Price,
               InStock = book.InStock
            };

            ViewData["Id"] = book.Id;

            return View(bookModel);
        }

        [HttpPost]
        public IActionResult Edit(int id,Book book)
        {
            var books = _context.Books.Find(id);

            if (book == null)
            {
                return RedirectToAction("Index", "Book");
            }


            books.BookName = book.BookName;
            books.Price = book.Price;
            books.InStock = book.InStock;


            _context.SaveChanges();

            return RedirectToAction("Index", "Book");
        }
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return RedirectToAction("Index", "Book");
            }


            _context.Books.Remove(book);
            _context.SaveChanges();

            return RedirectToAction("Index", "Book");
        }

    }
}
