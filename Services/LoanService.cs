using BookLoanProject.Domain.Entities;
using BookLoanProject.Domain.Interfaces;
using BookLoanProject.Infrastructure;
using BookLoanProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLoanProject.Domain.Exceptions;

namespace BookLoanProject.Services
{
    internal class LoanService
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILoanRepository _loanRepository;
        private readonly IRepository<Member> _member;

        public LoanService(IBookRepository bookRepository, ILoanRepository loanRepository, IRepository<Member> member)
        {
            _bookRepository = bookRepository;
            _loanRepository = loanRepository;
            _member = member;
        }

        public void BorrowBook(int memberId, int bookId)
        {

            var bookFound = _bookRepository.GetById(bookId);
            var memberFound = _member.GetById(memberId);

            if (bookFound == null) throw new ArgumentNullException(nameof(bookId), "Book Id cannot be null.");
            if (memberFound == null) throw new ArgumentNullException(nameof(memberId), "Member Id cannot be null.");

            if (bookFound.IsAvailable == 0) throw new BookNotAvailableException("Book is not available", bookId);

            var borrowQuantity = _loanRepository.GetActiveLoansByMember(memberId).Where(b => b.ReturnDate == null).Count();


            if(borrowQuantity >= memberFound.GetLoanLimit())
            {
                throw new
            }
        }
    }
}
