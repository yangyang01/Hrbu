using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class AuthorizationsContext : DBContext<Authorizations>
    {
        public static bool CheckRoleHasPermission(string menu, int roleId)
        {
            using (var ctx = CreateContext())
            {
                var query = from a in ctx.Set<Authorizations>()
                            join b in ctx.Set<Menu>() on a.MenuId equals b.Id
                            join c in ctx.Set<Role>() on a.RoleId equals c.Id
                            where b.NameCn == menu && c.Id == roleId
                            select a;
                return query.Any();
            }
        }

        public static List<Authorizations> GetRoleMenus(int id)
        {
            using (var ctx = CreateContext())
            {
                var query = from a in ctx.Set<Authorizations>()
                            where a.RoleId == id
                            select a;
                return query.ToList();
            }
        }

        public static int GetMenuIdByName(string name)
        {
            using (var ctx = CreateContext())
            {
                var query = from a in ctx.Set<Menu>()
                            where a.NameCn == name
                            select a.Id;
                return query.FirstOrDefault();
            }
        }

    }
}
