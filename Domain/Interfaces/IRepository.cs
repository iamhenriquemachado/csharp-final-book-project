using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanProject.Domain.Interfaces
{
    internal interface IRepository<T>
    {
        void Add(T item);
        T? GetById(int id);
        IEnumerable<T> List();
        void Delete(int id);

;
    }
}
