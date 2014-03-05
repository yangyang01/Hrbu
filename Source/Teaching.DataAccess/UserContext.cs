using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class UserContext : DBContext<User>
    {
        public static List<User> GetUserListByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          orderby u.Id
                          select u;
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
    }
}
