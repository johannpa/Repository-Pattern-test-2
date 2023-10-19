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
