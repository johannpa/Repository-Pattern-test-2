using ConsoleAppRepositoryPattern.Entities;
using ConsoleAppRepositoryPattern.Infrastructure;
using ConsoleAppRepositoryPattern.Interfaces;

namespace ConsoleAppRepositoryPattern.Services
{
    public class BookService
    {
        private readonly IRepository<Book> _bookRepository;
        private BookRepository _repository;

        // Make this to avoid the Error in program.cs but is it good
        public BookService(BookRepository repository)
        {
            _repository = repository;
        }

        private BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }

    }
}
