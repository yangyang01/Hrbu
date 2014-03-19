using Hrbu.Teaching.DataAccess;
using Hrbu.Teaching.Model;
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
        public static List<UserInfo> GetUserListByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          join r in ctx.Set<Role>() on u.RoleId equals r.Id
                           into r1
                          from r2 in r1.DefaultIfEmpty()
                          orderby u.Id
                          select new UserInfo
                          {
                              User = u,
                              RoleName = r2.describe
                          };
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
        public static UserInfo GetUserInfoById(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          join r in ctx.Set<Role>() on u.RoleId equals r.Id
                          where u.Id == Id
                          select new UserInfo
                          {
                              User = u,
                              RoleName = r.describe
                          };
                return sql.FirstOrDefault();
            }
        }
    }
}
