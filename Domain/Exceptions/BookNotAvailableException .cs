using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Exceptions
{
    internal class BookNotAvailableException : Exception
    {
        public int ViolatingRule { get; set; }
        public int RawLine { get; set; }

        public BookNotAvailableException(string message) : base(message) { }

        public BookNotAvailableException(string message, int violatingRule, int rawLine) :
                base($"Exception message: {message} | Violating Rule:{violatingRule} | RawLine: {rawLine}")
        {
            ViolatingRule = violatingRule;
            RawLine = rawLine;
        }
    }
}
