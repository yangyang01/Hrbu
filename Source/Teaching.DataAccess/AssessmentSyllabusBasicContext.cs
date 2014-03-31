using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class AssessmentSyllabusBasicContext : DBContext<AssessmentSyllabusBasic>
    {
        public static bool IsExitAssessmentInfo(int CourseCode)
        {
            using (var ctx = CreateContext())
            {
                var sql = from a in ctx.Set<AssessmentSyllabusBasic>()
                          where a.CourseCode == CourseCode
                          select a;
                return sql.Count() > 0;
            }
        }
        public static List<AssessmentSyllabusBasic> GetAssessmentSyllabusByPage(int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from a in ctx.Set<AssessmentSyllabusBasic>()
                          orderby a.CourseCode
                          select a;
                totalCount = sql.Count();
                return sql.Skip(startPage * pageSize).Take(pageSize).ToList();
            }
        }

    }
}
