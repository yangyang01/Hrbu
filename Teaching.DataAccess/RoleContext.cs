using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.DataAccess;


namespace Teaching.DataAccess
{
    public class RoleContext : DBContext<Role>
    {
        public static List<Role> GetRoleListByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from r in ctx.Set<Role>()
                          // where UserNo == "00001"
                          orderby r.Id
                          select r;
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
        public static Role GetRoleByRoleId(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from r in ctx.Set<Role>()
                          where r.Id==Id
                          select r;
                return sql.FirstOrDefault();
            }
        }
    }
}
