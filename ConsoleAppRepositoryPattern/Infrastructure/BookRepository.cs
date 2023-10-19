using ConsoleAppRepositoryPattern.Entities;
using ConsoleAppRepositoryPattern.Interfaces;

namespace ConsoleAppRepositoryPattern.Infrastructure
{
    public class BookRepository : IRepository<Book>
    {
        public void Add(Book entity)
        {
            //Add logic
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            //Delete logic
            throw new NotImplementedException();
        }

        public Book Get(Guid id)
        {
            //Get logic
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            //Update logic
            throw new NotImplementedException();
        }
    }
}
