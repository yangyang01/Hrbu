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
        public static List<UserInfo> GetUserListByPage(QueryString query,int startPage, int pageSize, out int totalCount)
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
                if (!string.IsNullOrWhiteSpace(query.UserNo))
                {
                    sql = sql.Where(x => x.User.UserNo.Contains(query.UserNo));
                }
                if (!string.IsNullOrWhiteSpace(query.UserName))
                {
                    sql = sql.Where(x => x.User.UserName.Contains(query.UserName));
                }
                totalCount = sql.Count();
                return sql.Skip(pageSize * (startPage - 1)).Take(pageSize).ToList();
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
        public static bool IsExitUserNo(string UserNo)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          where u.UserNo == UserNo
                          select u;
                return sql.Count() > 0;

            }
        }
        public static List<User> GetUserList()
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          select u;
                return sql.ToList();

            }
        }
        public static bool IsStudentNo(int roleId)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          where roleId ==4
                          select u;
                return sql.Count() > 0;

            }
        }
        public static User GetUserInfoByNo(string stuNo)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          where u.UserNo == stuNo
                          select u;
                return sql.FirstOrDefault();

            }
        }

    }
}
