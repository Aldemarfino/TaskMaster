using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public interface IEntityOptions
    {
        SqlCommand SQLCommandInsert(SqlConnection connection);

    }
}
