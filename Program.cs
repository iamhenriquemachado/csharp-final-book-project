using BookLoanProject.Domain.Entities;
using BookLoanProject.Domain.Enums;

Member member = new Member()
{
    Id = 1001,
    Name = "Henrique",
    Email = "henrique@gmail.com",
    MemberType = Membership.Premium
};

var memberhipType = member.MemberType.ToString();

var value = member.GetLoanLimit();
Console.WriteLine(value);