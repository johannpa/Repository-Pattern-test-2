using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRepositoryPattern.Entities
{
    public class Book
    {
        public Guid Id { get; }

        public string Name { get; set; }
        public Book(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
