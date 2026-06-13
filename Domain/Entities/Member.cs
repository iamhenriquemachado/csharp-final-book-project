using BookLoanProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Entities
{
    internal class Member : LibraryUser
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string? Email { get; set; }

        public Membership MemberType { get; set; }

        public override int GetLoanLimit()
        {
            return MemberType == Membership.Regular ? 3 : 5;

        }
    }
}
