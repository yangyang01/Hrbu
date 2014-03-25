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
        public static DataDicInfo GetDataDicInfoById(int Id, int DicId)
        {
            using (var ctx = CreateContext())
            {
                var sql = from d in ctx.Set<DataDicInfo>()
                          join d1 in ctx.Set<DataDic>() on d.DataDicId equals d1.id
                          where d. Id== Id&&d1.id==DicId
                          orderby d.Id
                          select d;
                return sql.FirstOrDefault();
            }
        }
        public static List<DataDicInfo> GetDataDicByType(int type)
        {
            using (var ctx = CreateContext())
            {
                var list = ctx.Set<DataDicInfo>().Where(x => x.DataDicId == type)
                    .ToList();
                if (list.Count > 0 && list[0].DataDicId != null)
                    return list.OrderBy(x => x.Id).ToList();
                return list.OrderBy(x => x.Id).ToList();
            }
        }
    }
}
