using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Entities
{
    internal abstract class LibraryUser
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public abstract int GetLoanLimit();
    }
}
