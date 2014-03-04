using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class DataDicContext : DBContext<DataDic>
    {
        public static List<DataDic> GetDateListByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from d in ctx.Set<DataDic>()
                         // where UserNo == "00001"
                          orderby d.id
                          select d;
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
    }
}
