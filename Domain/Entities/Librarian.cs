using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Entities
{
    internal class Librarian : LibraryUser
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override int GetLoanLimit()
        {
            return int.MaxValue;
        }
    }
}
