using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBooks_Logic.model;

namespace OnlineBooks_Logic.Abstract
{
    public interface IBooks
    {
        IEnumerable<Books> GetBooks { get; }
    }
}
