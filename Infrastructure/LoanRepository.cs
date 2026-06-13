using BookLoanProject.Domain.Entities;
using BookLoanProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Infrastructure
{
    internal class LoanRepository : ILoanRepository
    {
        List<Loan> _loans = new();
        public void Add(Loan item)
        {
            _loans.Add(item);
        }

        public void Delete(int id)
        {
            var loanFound = _loans.FirstOrDefault(l => l.BookId == id);
            if (loanFound != null) { _loans.Remove(loanFound); }

        }

        public Loan GetActiveLoansByMember(int memberId)
        {
            var activeLoans = _loans.FirstOrDefault(l => l.MemberId == memberId);
            
        }

        public Loan? GetById(int id)
        {
            var foundLoan = _loans.FirstOrDefault(l => l.BookId == id);

            return foundLoan;
        }

        public IEnumerable<Loan> List()
        {
            return _loans;
        }
    }
}
