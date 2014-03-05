using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class DataDicinfoContext : DBContext<DataDicInfo>
    {
        public static List<DataDicInfo> GetDataDicListById(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from d in ctx.Set<DataDicInfo>()
                          where d.DataDicId == Id
                          orderby d.Id
                          select d;
                return sql.ToList();
            }
        }
        public static DataDicInfo GetDataDicInfoById(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from d in ctx.Set<DataDicInfo>()
                          where d.Id == Id
                          orderby d.Id
                          select d;
                return sql.FirstOrDefault();
            }
        }
    }
}
