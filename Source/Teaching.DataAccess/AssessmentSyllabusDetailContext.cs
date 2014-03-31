using Hrbu.Teaching.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching.Model;

namespace Teaching.DataAccess
{
    public class AssessmentSyllabusDetailContext : DBContext<AssessmentSyllabusDetail>
    {
        public static bool IsExitAssessmentDetailInfo(int CourseCode, string Chapter)
        {
            using (var ctx = CreateContext())
            {
                var sql = from a in ctx.Set<AssessmentSyllabusDetail>()
                          where a.CourseCode == CourseCode && a.Chapter == Chapter
                          select a;
                return sql.Count() > 0;
            }
        }

    }
}
