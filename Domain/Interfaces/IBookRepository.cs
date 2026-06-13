using BookLoanProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Interfaces
{
    internal interface IBookRepository : IRepository<Book>
    {
        List<Book> _books = new();
        List<Book> Search(string keyword)
        {
            var foundBook = _books.Where(k => k.Name.Contains(keyword.ToLower())).ToList();
            return foundBook;
        }
    }
}
