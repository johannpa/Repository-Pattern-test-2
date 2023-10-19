using ConsoleAppRepositoryPattern.Entities;
using ConsoleAppRepositoryPattern.Infrastructure;
using ConsoleAppRepositoryPattern.Services;

namespace ConsoleAppRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new BookRepository();

            // Get Error here in new BookService without an other constructor in BookService
            var service = new BookService(repository);

            service.AddBook(new Book("Harry Potter"));
        }
    }
}