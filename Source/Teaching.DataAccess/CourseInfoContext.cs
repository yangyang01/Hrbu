using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.Model;

namespace Teaching.DataAccess
{
    public class CourseInfoContext : DBContext<CourseInfo>
    {
        public static List<Course> GetCourseInfoByPage(QueryString query, int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from c in ctx.Set<CourseInfo>()
                          join d in ctx.Set<DataDicInfo>() on c.CourseProperty equals d.Id
                          into d1
                          from d2 in d1.DefaultIfEmpty()
                          join dd in ctx.Set<DataDicInfo>() on c.CourseType equals dd.Id
                          into dd1
                          from dd2 in dd1.DefaultIfEmpty()
                          orderby c.Id
                          select new Course
                          {
                              CourseInfo = c,
                              CoursePropertyCn = d2.InfoName,
                              CourseTypeCn = dd2.InfoName,
                          };
                if (query.CourseCode != null)
                {
                    sql = sql.Where(x => x.CourseInfo.CourseCode == query.CourseCode);
                }
                if (!string.IsNullOrWhiteSpace(query.CourseName))
                {
                    sql = sql.Where(x => x.CourseInfo.CourseName.Contains(query.CourseName));
                }
                totalCount = sql.Count();
                return sql.ToList();
            }
        }
        public static List<CourseInfo> GetCourseNameList()
        {
            using (var ctx = CreateContext())
            {
                var sql = from c in ctx.Set<CourseInfo>()
                          select c;
                return sql.ToList();
            }
        }
        public static CourseInfo GetCourseInfoById(int id)
        {
            using (var ctx = CreateContext())
            {
                var sql = from c in ctx.Set<CourseInfo>()
                          where c.Id == id
                          select c;
                return sql.FirstOrDefault();
            }
        }
        public static bool IsExitCourseCode(int code)
        {
            using (var ctx = CreateContext())
            {
                var sql = from c in ctx.Set<CourseInfo>()
                          where c.CourseCode == code
                          select c;
                return sql.Count() > 0;
            }
        }
    }
}
