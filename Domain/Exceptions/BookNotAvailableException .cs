using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Exceptions
{
    internal class BookNotAvailableException : Exception
    {
        public int RawLine { get; set; }

        public BookNotAvailableException(string message) : base(message) { }

        public BookNotAvailableException(string message,  int rawLine) :
                base($"Exception message: {message}  RawLine: {rawLine}")
        {
            RawLine = rawLine;
        }
    }
}
