using ConsoleAppRepositoryPattern.Entities;
using ConsoleAppRepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRepositoryPattern.Services
{
    public class BookService
    {
        private readonly IRepository<Book> _bookRepository;

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
