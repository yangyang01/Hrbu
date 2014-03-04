using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class TeacherBasicInfoContext:DBContext<TeacherBasicInfo>
    {
        public static List<TeacherBasicInfo> GetTeacherInfoByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeacherBasicInfo>()
                          orderby t.Id
                          select t;
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
        public static TeacherBasicInfo GetTeacherInfoById(int Id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeacherBasicInfo>()
                          where t.Id == Id
                          select t;
                return sql.FirstOrDefault();
            }
        }

    }
}
