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
        public static List<TeachingSyllabusInfo> GetTeachingSyllabusByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TeachingSyllabusBasic>()
                          join c in ctx.Set<CourseInfo>() on t.CourseCode equals c.CourseCode
                          join d in ctx.Set<DataDicInfo>() on c.CourseProperty equals d.Id
                          into d1
                          from d2 in d1.DefaultIfEmpty()
                          join c1 in ctx.Set<CourseInfo>() on t.PrerequisiteCourse equals c1.CourseCode
                           into cc1
                          from cc2 in cc1.DefaultIfEmpty()
                          orderby t.CourseCode
                          select new TeachingSyllabusInfo
                          {
                              TeachingSyllabusBasic = t,
                              CourseName = c.CourseName,
                              Credit=c.Credit,
                              PeriodTotal=c.PeriodTotal,
                              CoursePropertyCn = d2.InfoName,
                              PrerequisiteCourseCn = cc2.CourseName
                          };
                totalCount = sql.Count();
                return sql.Skip(pageSize * (startPage - 1)).Take(pageSize).ToList();
            }
        }

    }
}
