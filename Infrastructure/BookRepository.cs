using BookLoanProject.Domain.Entities;
using BookLoanProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Infrastructure
{
    internal class BookRepository : IBookRepository
    {
        List<Book> _books = new();
        public void Add(Book item)
        {
            _books.Add(item);
        }

        public void Delete(int id)
        {
            var bookFound = _books.FirstOrDefault(b => b.Id == id);
            if (bookFound != null)
            {
                _books.Remove(bookFound);

            }
        }

        public Book? GetById(int id)
        {
            var bookFound = _books.FirstOrDefault(b => b.Id == id);
            if (bookFound != null) { return bookFound; }
            return null;

        }

        public IEnumerable<Book> List()
        {
            return _books;
        }

        public Book Search(string keyword)
        {
            var searchBook = _books.FirstOrDefault(b => b.Name.Contains(keyword.ToLower()));
            if (searchBook != null) { return searchBook; }
            return null;
        }
    }
}
