using BookLoanProject.Domain.Entities;
using BookLoanProject.Domain.Interfaces;
using BookLoanProject.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Services
{
    internal class LoanService
    {
        private readonly BookRepository _bookRepository;
        private readonly LoanRepository _loanRepository;
        private readonly IRepository<Book> _book;
        private readonly IRepository<Loan> _Loan;

        public LoanService(BookRepository bookRepository, LoanRepository loanRepository)
        {
            _bookRepository = bookRepository;
            _loanRepository = loanRepository;
        }

        public void BorrowBook(int memberId, int bookId)
        {
            var bookIsAvailable = _book.GetById(bookId);

            if (bookIsAvailable == null) { throw new ArgumentNullException(nameof(bookId), "Book Id cannot be null."); }


        }
    }
}
