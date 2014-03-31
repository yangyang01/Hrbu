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
    public class TrainingProgramInfoContext : DBContext<TrainingProgramInfo>
    {
        public static bool IsExitTrainInfo(int SchoolYear, int SchoolSemester, int CourseCode, int Grade)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TrainingProgramInfo>()
                          where t.SchoolSemester == SchoolSemester && t.SchoolYear == SchoolYear
                          && t.CourseCode == CourseCode && t.Grade == Grade
                          select t;
                return sql.Count() > 0;
            }
        }
        public static List<TrainingProgramCourseInfo> GetTrainCourseByPage(QueryString query, int startPage, int pageSize, out int totalCount)
        {
            using (var ctx = CreateContext())
            {
                var sql = from t in ctx.Set<TrainingProgramInfo>()
                          join c in ctx.Set<CourseInfo>() on t.CourseCode equals c.CourseCode
                          join d in ctx.Set<DataDicInfo>() on c.CourseProperty equals d.Id
                          into d1
                          from d2 in d1.DefaultIfEmpty()
                          join dd in ctx.Set<DataDicInfo>() on c.CourseType equals dd.Id
                          into dd1
                          from dd2 in dd1.DefaultIfEmpty()
                          join dy in ctx.Set<DataDicInfo>() on t.SchoolYear equals dy.Id
                          into dy1
                          from dy2 in dy1.DefaultIfEmpty()
                          join ds in ctx.Set<DataDicInfo>() on t.SchoolSemester equals ds.Id
                          into ds1
                          from ds2 in ds1.DefaultIfEmpty()
                          join dp in ctx.Set<DataDicInfo>() on t.ProfessionalEmphasis equals dp.Id
                          into dp1
                          from dp2 in dp1.DefaultIfEmpty()
                          join de in ctx.Set<DataDicInfo>() on t.EvaluationMode equals de.Id
                          into de1
                          from de2 in de1.DefaultIfEmpty()
                          orderby t.id
                          select new TrainingProgramCourseInfo
                          {
                              TrainingProgramInfo = t,
                              CourseName = c.CourseName,
                              CoursePropertyCn = d2.InfoName,
                              CourseTypeCn = dd2.InfoName,
                              Credit = c.Credit,
                              PeriodTotal = c.PeriodTotal,
                              SchoolYear=dy2.InfoName,
                              SchoolSemester=ds2.InfoName,
                              ProfessionalEmphasis=dp2.InfoName,
                              EvaluationMode=de2.InfoName
                          };
                if (query.SchoolYear != null)
                {
                    sql = sql.Where(x => x.TrainingProgramInfo.SchoolYear == query.SchoolYear);
                }
                if (query.SchoolSemester != null)
                {
                    sql = sql.Where(x => x.TrainingProgramInfo.SchoolSemester == query.SchoolSemester);
                }
                if (query.Grade != null)
                {
                    sql = sql.Where(x => x.TrainingProgramInfo.Grade == query.Grade);
                }
                totalCount = sql.Count();
                return sql.Skip(pageSize * (startPage - 1)).Take(pageSize).ToList();
            }

        }
    }
}
