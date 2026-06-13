using BookLoanProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Interfaces
{
    internal interface ILoanRepository : IRepository<Loan>
    {
        Loan GetActiveLoansByMember(int memberId);
    }
}
