using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class TeachingSyllabusBasicContext : DBContext<TeachingSyllabusBasic>
    {
        public static bool IsExitTeachingInfo(int CourseCode)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeachingSyllabusBasic>()
                          where t.CourseCode == CourseCode 
                          select t;
                return sql.Count() > 0;
            }
        }

    }
}
