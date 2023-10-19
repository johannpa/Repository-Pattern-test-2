using ConsoleAppRepositoryPattern.Entities;
using ConsoleAppRepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRepositoryPattern.Infrastructure
{
    public class BookRepository : IRepository<Book>
    {
        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
