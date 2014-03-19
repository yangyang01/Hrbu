using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class CourseInfoContext:DBContext<CourseInfo>
    {
        public static List<CourseInfo> GetCourseNameList()
        {
            using (var ctx = CreateContext())
            {
                var sql = from c in ctx.Set<CourseInfo>()
                          select c;
                return sql.ToList();
            }
        }
    }
}
