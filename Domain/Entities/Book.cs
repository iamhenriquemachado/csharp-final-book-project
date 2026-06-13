using BookLoanProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Entities
{
    internal class Book
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        
        public Availability IsAvailable { get; set; }
    }
}
