using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Exceptions
{
    internal class LoanLimitExceededException : Exception
    {
        public int RawLine { get; set; }

        public LoanLimitExceededException(string message) : base(message) { }

        public LoanLimitExceededException(string message, int rawLine) : base($"Message: {message} | Member Id: {rawLine}")
        {
            RawLine = rawLine;
        }
    }
}
