using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.Interface;

namespace Teaching.DataAccess
{
    public class LoginContext : DBContext<User>
    {
        public static List<User> GetUserInfoById(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          join r in ctx.Set<Role>() on u.RoleId equals r.Id
                          select u;
                return sql.ToList();
            }
        }
        public static bool GetUserByNoAndPass(string No,string password)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          join r in ctx.Set<Role>() on u.RoleId equals r.Id
                          where u.UserNo == No && u.Password == password
                          select u;
                return sql.Any();
            }
        }
        public static bool GetRoleByNo(String No)
        {
            using (var ctx = CreateContext())
            {
                var sql = from u in ctx.Set<User>()
                          join r in ctx.Set<Role>() on u.RoleId equals r.Id
                          where u.RoleId == r.Id&&u.UserNo==No
                          select u;
                return sql.IsNotEmpty();

            }
        }

        public static List<string> GetAllRole()
        {
            using (var ctx = CreateContext())
            {
                var sql = from r in ctx.Set<Role>()
                          select r.roleName;
                return sql.ToList();
            }
        }
    }
}
