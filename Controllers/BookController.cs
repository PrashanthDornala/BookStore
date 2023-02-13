using BookstorewithcoreMVC.Models;
using BookstorewithcoreMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookstorewithcoreMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data) ;
        }
        public ViewResult GetBook(int id)
        {
            var book= _bookRepository.GetBook(id);
            return View(book);   
        }
        public List<BookModel> SearchBook(string bookName, string bookAuthor)
        {
            return _bookRepository.SearchBook(bookName, bookAuthor);
        }
    }
}
