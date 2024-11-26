using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBasicOperations<T>
    {
        bool Add(T entity);
        List<T> GetRows();

    }
}
